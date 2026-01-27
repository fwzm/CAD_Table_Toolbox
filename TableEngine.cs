using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

namespace CAD_Table_Toolbox
{
    public static class TableEngine
    {
        public static List<string> GetLayerNames()
        {
            List<string> layers = new List<string>();
            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc == null) return layers;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                LayerTable lt = (LayerTable)tr.GetObject(doc.Database.LayerTableId, OpenMode.ForRead);
                foreach (ObjectId id in lt)
                {
                    LayerTableRecord ltr = (LayerTableRecord)tr.GetObject(id, OpenMode.ForRead);
                    layers.Add(ltr.Name);
                }
                tr.Commit();
            }
            layers.Sort();
            return layers;
        }

        public static void CreateLayer(string layerName)
        {
            if (string.IsNullOrEmpty(layerName)) return;

            Document doc = Application.DocumentManager.MdiActiveDocument;
            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                LayerTable lt = (LayerTable)tr.GetObject(doc.Database.LayerTableId, OpenMode.ForWrite);
                if (!lt.Has(layerName))
                {
                    LayerTableRecord ltr = new LayerTableRecord();
                    ltr.Name = layerName;
                    lt.Add(ltr);
                    tr.AddNewlyCreatedDBObject(ltr, true);
                }
                tr.Commit();
            }
        }

        public static void GenerateTable(int rows, int cols, string layerName)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            PromptPointOptions ppo = new PromptPointOptions("\nPick insertion point for table: ");
            PromptPointResult ppr = ed.GetPoint(ppo);
            if (ppr.Status != PromptStatus.OK) return;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);

                Table tb = new Table();
                tb.TableStyle = db.Tablestyle;
                tb.SetSize(rows, cols);
                tb.Position = ppr.Value;
                
                if (!string.IsNullOrEmpty(layerName))
                {
                    if (IsLayerExists(layerName, tr, db))
                        tb.Layer = layerName;
                }
                
                // Generate rows (default size)
                // In a real implementation, we would apply the specific row heights/col widths from the UI
                tb.GenerateLayout();

                btr.AppendEntity(tb);
                tr.AddNewlyCreatedDBObject(tb, true);
                tr.Commit();
            }
        }

        private static bool IsLayerExists(string name, Transaction tr, Database db)
        {
            LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
            return lt.Has(name);
        }

        public static void AutoAdjustTable()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            PromptEntityOptions peo = new PromptEntityOptions("\nSelect a table to adjust: ");
            peo.SetRejectMessage("\nMust be a table.");
            peo.AddAllowedClass(typeof(Table), true);
            
            PromptEntityResult per = ed.GetEntity(peo);
            if (per.Status != PromptStatus.OK) return;

            using (Transaction tr = doc.TransactionManager.StartTransaction())
            {
                Table tb = (Table)tr.GetObject(per.ObjectId, OpenMode.ForWrite);
                
                // Logic: Iterate cells, get text content size, resize row/col
                // This is complex, for now we re-generate layout which often auto-fits
                tb.RecomputeTableBlock(true);
                
                // A better approach iterates rows/cols:
                // tb.Rows[i].Height = ...
                // tb.Columns[i].Width = ...
                
                tr.Commit();
            }
        }

        public static void AlignTextInLines()
        {
            // Placeholder for "Line Table Text Alignment"
            // This would select text inside grid lines and center them
            ConversionEngine.AlignTextInLines();
        }
    }
}
