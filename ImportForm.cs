using System;
using System.Windows.Forms;

namespace CAD_Table_Toolbox
{
    public partial class ImportForm : Form
    {
        public string FilePath => txtFilePath.Text;
        public ImportSettings Settings { get; private set; }
        private bool _isLinkMode;

        public ImportForm(bool isLinkMode)
        {
            InitializeComponent();
            _isLinkMode = isLinkMode;
            if (_isLinkMode)
            {
                this.Text = "链接Excel表格";
            }
            
            // Dummy data for dropdowns
            cmbLineLayer.Items.Add("0");
            cmbLineLayer.SelectedIndex = 0;
            cmbTextLayer.Items.Add("0");
            cmbTextLayer.SelectedIndex = 0;
            cmbFillLayer.Items.Add("0");
            cmbFillLayer.SelectedIndex = 0;
            cmbTextStyle.Items.Add("Standard");
            cmbTextStyle.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || txtFilePath.Text == "未选择文件")
            {
                MessageBox.Show("请选择Excel文件！");
                return;
            }

            Settings = new ImportSettings
            {
                IsLinkMode = _isLinkMode,
                ImportAllCells = radAllCells.Checked,
                UseExcelFontSize = radExcelHeight.Checked,
                FixedHeight = double.TryParse(txtFixedHeight.Text, out double h) ? h : 300,
                KeepBackgroundColor = chkKeepBgColor.Checked,
                KeepTextColor = chkKeepTextColor.Checked,
                LineLayer = cmbLineLayer.Text,
                FillLayer = cmbFillLayer.Text,
                TextLayer = cmbTextLayer.Text,
                TextStyle = cmbTextStyle.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class ImportSettings
    {
        public bool IsLinkMode { get; set; }
        public bool ImportAllCells { get; set; }
        public bool UseExcelFontSize { get; set; }
        public double FixedHeight { get; set; }
        public bool KeepBackgroundColor { get; set; }
        public bool KeepTextColor { get; set; }
        public string LineLayer { get; set; }
        public string FillLayer { get; set; }
        public string TextLayer { get; set; }
        public string TextStyle { get; set; }
    }
}
