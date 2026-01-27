using System;
using System.Reflection;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Excel = Microsoft.Office.Interop.Excel;

namespace CAD_Table_Toolbox
{
    public static class ExcelEngine
    {
        public static void ImportExcel(string filePath, ImportSettings settings)
        {
            ProcessExcel(filePath, settings, false);
        }

        public static void LinkExcel(string filePath, ImportSettings settings)
        {
            ProcessExcel(filePath, settings, true);
        }

        private static void ProcessExcel(string filePath, ImportSettings settings, bool link)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            Database db = doc.Database;

            Excel.Application xlApp = null;
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;
            Excel.Range range = null;

            try
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(filePath);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1]; // Default first sheet

                if (settings.ImportAllCells)
                    range = xlWorkSheet.UsedRange;
                else
                    range = xlApp.Selection as Excel.Range; // This might fail if Excel isn't visible/focused

                if (range == null) range = xlWorkSheet.UsedRange;

                int rCnt = range.Rows.Count;
                int cCnt = range.Columns.Count;

                // Create CAD Table
                using (Transaction tr = doc.TransactionManager.StartTransaction())
                {
                    BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                    BlockTableRecord btr = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);

                    Table tb = new Table();
                    tb.SetSize(rCnt, cCnt);
                    
                    // Populate Data
                    object[,] values = (object[,])range.Value2;
                    // Note: Excel range is 1-based, array might be 1-based depending on implementation
                    
                    for (int r = 0; r < rCnt; r++)
                    {
                        for (int c = 0; c < cCnt; c++)
                        {
                            try
                            {
                                // Handle 1-based index if needed, usually value2 returns 1-based array if range > 1 cell
                                object val = null;
                                if (rCnt == 1 && cCnt == 1) 
                                    val = values[0,0]; // Actually Value2 returns single object if 1 cell
                                else
                                    val = values[r + 1, c + 1];

                                if (val != null)
                                    tb.Cells[r, c].TextString = val.ToString();
                            }
                            catch { }
                        }
                    }

                    // Apply Settings (Height, Layers)
                    if (settings.UseExcelFontSize)
                    {
                         // Complex logic to map Excel points to CAD units
                    }
                    else
                    {
                        tb.Cells.TextHeight = settings.FixedHeight;
                    }

                    if (!string.IsNullOrEmpty(settings.LineLayer)) tb.Layer = settings.LineLayer;

                    // Insert
                    PromptPointResult ppr = ed.GetPoint("\nPick insertion point: ");
                    if (ppr.Status == PromptStatus.OK)
                    {
                        tb.Position = ppr.Value;
                        btr.AppendEntity(tb);
                        tr.AddNewlyCreatedDBObject(tb, true);

                        if (link)
                        {
                            // Add XData for linking
                            ResultBuffer rb = new ResultBuffer(
                                new TypedValue((int)DxfCode.ExtendedDataRegAppName, "CAD_TABLE_TOOLBOX_LINK"),
                                new TypedValue((int)DxfCode.ExtendedDataAsciiString, filePath)
                            );
                            // Register app name first
                            RegAppTable rat = (RegAppTable)tr.GetObject(db.RegAppTableId, OpenMode.ForRead);
                            if (!rat.Has("CAD_TABLE_TOOLBOX_LINK"))
                            {
                                rat.UpgradeOpen();
                                RegAppTableRecord ratr = new RegAppTableRecord();
                                ratr.Name = "CAD_TABLE_TOOLBOX_LINK";
                                rat.Add(ratr);
                                tr.AddNewlyCreatedDBObject(ratr, true);
                            }
                            tb.XData = rb;
                        }
                    }
                    
                    tr.Commit();
                }
            }
            catch (Exception ex)
            {
                ed.WriteMessage("\nError importing Excel: " + ex.Message);
            }
            finally
            {
                if (xlWorkBook != null) xlWorkBook.Close();
                if (xlApp != null) xlApp.Quit();
                
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }

        public static void ExportLinesToExcel()
        {
            // Placeholder
            Document doc = Application.DocumentManager.MdiActiveDocument;
            doc.Editor.WriteMessage("\nExport to Excel feature triggered.");
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
