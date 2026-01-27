using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using System.Windows.Forms;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;

[assembly: CommandClass(typeof(CAD_Table_Toolbox.Plugin))]

namespace CAD_Table_Toolbox
{
    public class Plugin
    {
        [CommandMethod("TableToolbox")]
        public void ShowTableToolbox()
        {
            try
            {
                MainForm mainForm = new MainForm();
                // Pass current layers to the form
                mainForm.SetLayers(TableEngine.GetLayerNames());
                
                // Show as modeless or modal. Modal is easier for now to block CAD interaction while setting up.
                // However, "Show" is better for "Toolbox" feel, but "ShowDialog" is safer for simple implementation.
                Application.ShowModalDialog(mainForm);
            }
            catch (System.Exception ex)
            {
                Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("\nError showing Table Toolbox: " + ex.Message);
            }
        }
    }
}
