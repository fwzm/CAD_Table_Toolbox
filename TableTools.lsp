;;; ==========================================================================
;;; CAD Table Tools (LISP Edition)
;;; Version: 1.0.0
;;; Author: CAD Pair Programmer
;;; Date: 2026-01-28
;;; Description: Lightweight tools for drawing tables and exporting text to CSV.
;;; Target: AutoCAD 2018+
;;; ==========================================================================

(vl-load-com)

;;; ==========================================================================
;;; Global Defaults
;;; ==========================================================================
(if (not *QT-RowHeight*) (setq *QT-RowHeight* 10.0))
(if (not *QT-ColWidth*)  (setq *QT-ColWidth* 30.0))
(if (not *QT-Rows*)      (setq *QT-Rows* 5))
(if (not *QT-Cols*)      (setq *QT-Cols* 4))

;;; ==========================================================================
;;; Error Handler
;;; ==========================================================================
(defun *error* (msg)
  (if (and msg (not (wcmatch (strcase msg) "*BREAK*,*CANCEL*,*EXIT*")))
    (princ (strcat "\nError: " msg))
  )
  (setvar "CMDECHO" 1)
  (princ)
)

;;; ==========================================================================
;;; Command: QT_DRAW
;;; Description: Draws a grid of lines (Table)
;;; ==========================================================================
(defun c:QT_DRAW (/ pt rows cols rh cw i x y p1 p2)
  (setvar "CMDECHO" 0)
  
  ;; 1. Get User Inputs with defaults
  (initget 6) ; Non-negative, non-zero
  (setq rows (getint (strcat "\nEnter number of rows <" (itoa *QT-Rows*) ">: ")))
  (if (not rows) (setq rows *QT-Rows*) (setq *QT-Rows* rows))
  
  (initget 6)
  (setq cols (getint (strcat "\nEnter number of columns <" (itoa *QT-Cols*) ">: ")))
  (if (not cols) (setq cols *QT-Cols*) (setq *QT-Cols* cols))
  
  (initget 6)
  (setq rh (getdist (strcat "\nEnter row height <" (rtos *QT-RowHeight* 2 2) ">: ")))
  (if (not rh) (setq rh *QT-RowHeight*) (setq *QT-RowHeight* rh))
  
  (initget 6)
  (setq cw (getdist (strcat "\nEnter column width <" (rtos *QT-ColWidth* 2 2) ">: ")))
  (if (not cw) (setq cw *QT-ColWidth*) (setq *QT-ColWidth* cw))
  
  (setq pt (getpoint "\nSpecify insertion point (Top-Left): "))
  
  ;; 2. Draw Geometry
  (if pt
    (progn
      ;; Horizontal Lines
      (setq i 0)
      (repeat (1+ rows)
        (setq x (car pt))
        (setq y (- (cadr pt) (* i rh)))
        (setq p1 (list x y (caddr pt)))
        (setq p2 (list (+ x (* cols cw)) y (caddr pt)))
        (command "_.LINE" p1 p2 "")
        (setq i (1+ i))
      )
      
      ;; Vertical Lines
      (setq i 0)
      (repeat (1+ cols)
        (setq x (+ (car pt) (* i cw)))
        (setq y (cadr pt))
        (setq p1 (list x y (caddr pt)))
        (setq p2 (list x (- y (* rows rh)) (caddr pt)))
        (command "_.LINE" p1 p2 "")
        (setq i (1+ i))
      )
      (princ (strcat "\nTable drawn (" (itoa rows) "x" (itoa cols) ")."))
    )
    (princ "\nInsertion point not specified.")
  )
  
  (setvar "CMDECHO" 1)
  (princ)
)

;;; ==========================================================================
;;; Command: QT_EXPORT
;;; Description: Exports selected Text/MText to CSV based on visual position
;;; ==========================================================================
(defun c:QT_EXPORT (/ ss file path i ent elist txt inspt lst sorted_lst row_y csv_line fuzz)
  (setvar "CMDECHO" 0)
  
  (princ "\nSelect Text or MText objects to export:")
  (setq ss (ssget '((0 . "TEXT,MTEXT"))))
  
  (if ss
    (progn
      ;; 1. Collect Data: ((Y X Text) ...)
      (setq i 0)
      (setq lst '())
      (repeat (sslength ss)
        (setq ent (ssname ss i))
        (setq elist (entget ent))
        (setq txt (cdr (assoc 1 elist)))
        (setq inspt (cdr (assoc 10 elist)))
        ;; MText needs careful handling of formatting codes, simplified here
        (setq lst (cons (list (cadr inspt) (car inspt) txt) lst))
        (setq i (1+ i))
      )
      
      ;; 2. Sort Data
      ;; Sort by Y Descending (Top to Bottom), then X Ascending (Left to Right)
      ;; Fuzz factor: treat Y values within 10% of text height as same row
      (setq fuzz (* (getvar "TEXTSIZE") 0.5)) 
      
      (setq sorted_lst 
        (vl-sort lst 
          (function (lambda (a b)
            (if (equal (car a) (car b) fuzz)
              (< (cadr a) (cadr b)) ; Same Row: Sort Left to Right
              (> (car a) (car b))   ; Diff Row: Sort Top to Bottom
            )
          ))
        )
      )
      
      ;; 3. Write CSV
      (setq path (getfiled "Save CSV File" "TableData" "csv" 1))
      (if path
        (progn
          (setq file (open path "w"))
          (setq row_y nil)
          (setq csv_line "")
          
          (foreach item sorted_lst
            ;; Check if new row
            (if (or (null row_y) (not (equal (car item) row_y fuzz)))
              (progn
                (if row_y (write-line (substr csv_line 1 (1- (strlen csv_line))) file))
                (setq csv_line "")
                (setq row_y (car item))
              )
            )
            ;; Escape commas in text
            (setq txt (caddr item))
            (if (wcmatch txt "*,*") (setq txt (strcat "\"" txt "\"")))
            (setq csv_line (strcat csv_line txt ","))
          )
          ;; Write last line
          (if (/= csv_line "")
            (write-line (substr csv_line 1 (1- (strlen csv_line))) file)
          )
          
          (close file)
          (princ (strcat "\nSuccessfully exported to: " path))
        )
        (princ "\nExport cancelled.")
      )
    )
    (princ "\nNo text objects selected.")
  )
  (setvar "CMDECHO" 1)
  (princ)
)

(princ "\n>>> LISP Table Tools Loaded <<<")
(princ "\nCommands:")
(princ "\n  QT_DRAW   : Draw a simple table grid")
(princ "\n  QT_EXPORT : Export selected text to CSV")
(princ)
