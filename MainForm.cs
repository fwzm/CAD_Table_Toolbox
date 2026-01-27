using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAD_Table_Toolbox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLayers();
        }

        private void LoadLayers()
        {
            // In a real plugin, this would query AutoCAD for layers
            // For now, we will populate with some dummy data or rely on the Plugin class to pass this in
            // Ideally, the Plugin class instantiates this form and passes the layer list
            // But to keep it self-contained for now:
            cmbLayers.Items.Add("0");
            cmbLayers.SelectedIndex = 0;
        }

        public void SetLayers(List<string> layers)
        {
            cmbLayers.Items.Clear();
            foreach (var layer in layers)
            {
                cmbLayers.Items.Add(layer);
            }
            if (cmbLayers.Items.Count > 0)
                cmbLayers.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtCols.Text);
                double rowH = 0; // Default or Auto
                double colW = 0; // Default or Auto
                
                // Parse other optional values...
                
                string layer = cmbLayers.Text;
                if (!string.IsNullOrEmpty(txtNewLayer.Text))
                {
                    layer = txtNewLayer.Text;
                    // Create layer logic here or in engine
                }

                TableEngine.GenerateTable(rows, cols, layer);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCreateLayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewLayer.Text))
            {
                TableEngine.CreateLayer(txtNewLayer.Text);
                SetLayers(TableEngine.GetLayerNames());
                cmbLayers.Text = txtNewLayer.Text;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(false);
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                ExcelEngine.ImportExcel(importForm.FilePath, importForm.Settings);
                this.Close();
            }
        }

        private void btnLinkExcel_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(true);
            if (importForm.ShowDialog() == DialogResult.OK)
            {
                ExcelEngine.LinkExcel(importForm.FilePath, importForm.Settings);
                this.Close();
            }
        }

        private void btnLinesToTable_Click(object sender, EventArgs e)
        {
            this.Close(); // Close UI to allow selection
            ConversionEngine.ConvertLinesToTable();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            this.Close();
            ExcelEngine.ExportLinesToExcel();
        }

        private void btnAlignText_Click(object sender, EventArgs e)
        {
            this.Close();
            TableEngine.AlignTextInLines();
        }

        private void btnAutoAdjust_Click(object sender, EventArgs e)
        {
            this.Close();
            TableEngine.AutoAdjustTable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
