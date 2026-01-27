namespace CAD_Table_Toolbox
{
    partial class ImportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpRange = new System.Windows.Forms.GroupBox();
            this.radSelectedCells = new System.Windows.Forms.RadioButton();
            this.radAllCells = new System.Windows.Forms.RadioButton();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.cmbTextStyle = new System.Windows.Forms.ComboBox();
            this.lblTextStyle = new System.Windows.Forms.Label();
            this.cmbTextLayer = new System.Windows.Forms.ComboBox();
            this.lblTextLayer = new System.Windows.Forms.Label();
            this.cmbFillLayer = new System.Windows.Forms.ComboBox();
            this.lblFillLayer = new System.Windows.Forms.Label();
            this.cmbLineLayer = new System.Windows.Forms.ComboBox();
            this.lblLineLayer = new System.Windows.Forms.Label();
            this.chkKeepTextColor = new System.Windows.Forms.CheckBox();
            this.chkKeepBgColor = new System.Windows.Forms.CheckBox();
            this.txtFixedHeight = new System.Windows.Forms.TextBox();
            this.radFixedHeight = new System.Windows.Forms.RadioButton();
            this.radExcelHeight = new System.Windows.Forms.RadioButton();
            this.lblHeightMode = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.grpRange.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRange
            // 
            this.grpRange.Controls.Add(this.radSelectedCells);
            this.grpRange.Controls.Add(this.radAllCells);
            this.grpRange.Location = new System.Drawing.Point(12, 12);
            this.grpRange.Name = "grpRange";
            this.grpRange.Size = new System.Drawing.Size(460, 60);
            this.grpRange.TabIndex = 0;
            this.grpRange.TabStop = false;
            this.grpRange.Text = "选择需要导入表格的范围";
            // 
            // radSelectedCells
            // 
            this.radSelectedCells.AutoSize = true;
            this.radSelectedCells.Location = new System.Drawing.Point(250, 25);
            this.radSelectedCells.Name = "radSelectedCells";
            this.radSelectedCells.Size = new System.Drawing.Size(131, 16);
            this.radSelectedCells.TabIndex = 1;
            this.radSelectedCells.Text = "工作表中选定单元格";
            this.radSelectedCells.UseVisualStyleBackColor = true;
            // 
            // radAllCells
            // 
            this.radAllCells.AutoSize = true;
            this.radAllCells.Checked = true;
            this.radAllCells.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radAllCells.Location = new System.Drawing.Point(20, 25);
            this.radAllCells.Name = "radAllCells";
            this.radAllCells.Size = new System.Drawing.Size(134, 21);
            this.radAllCells.TabIndex = 0;
            this.radAllCells.TabStop = true;
            this.radAllCells.Text = "工作表中全部单元格";
            this.radAllCells.UseVisualStyleBackColor = true;
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.btnBrowse);
            this.grpFile.Controls.Add(this.txtFilePath);
            this.grpFile.Controls.Add(this.lblPath);
            this.grpFile.Location = new System.Drawing.Point(12, 80);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(460, 60);
            this.grpFile.TabIndex = 1;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "选择需要导入的表格文件";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(370, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "选择文件";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(80, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(280, 21);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "未选择文件";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(15, 25);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(59, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "文件路径:";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.cmbTextStyle);
            this.grpSettings.Controls.Add(this.lblTextStyle);
            this.grpSettings.Controls.Add(this.cmbTextLayer);
            this.grpSettings.Controls.Add(this.lblTextLayer);
            this.grpSettings.Controls.Add(this.cmbFillLayer);
            this.grpSettings.Controls.Add(this.lblFillLayer);
            this.grpSettings.Controls.Add(this.cmbLineLayer);
            this.grpSettings.Controls.Add(this.lblLineLayer);
            this.grpSettings.Controls.Add(this.chkKeepTextColor);
            this.grpSettings.Controls.Add(this.chkKeepBgColor);
            this.grpSettings.Controls.Add(this.txtFixedHeight);
            this.grpSettings.Controls.Add(this.radFixedHeight);
            this.grpSettings.Controls.Add(this.radExcelHeight);
            this.grpSettings.Controls.Add(this.lblHeightMode);
            this.grpSettings.Location = new System.Drawing.Point(12, 150);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(460, 160);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "导入设置";
            // 
            // cmbTextStyle
            // 
            this.cmbTextStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextStyle.FormattingEnabled = true;
            this.cmbTextStyle.Location = new System.Drawing.Point(300, 125);
            this.cmbTextStyle.Name = "cmbTextStyle";
            this.cmbTextStyle.Size = new System.Drawing.Size(120, 20);
            this.cmbTextStyle.TabIndex = 13;
            // 
            // lblTextStyle
            // 
            this.lblTextStyle.AutoSize = true;
            this.lblTextStyle.Location = new System.Drawing.Point(230, 128);
            this.lblTextStyle.Name = "lblTextStyle";
            this.lblTextStyle.Size = new System.Drawing.Size(59, 12);
            this.lblTextStyle.TabIndex = 12;
            this.lblTextStyle.Text = "文字样式:";
            // 
            // cmbTextLayer
            // 
            this.cmbTextLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTextLayer.FormattingEnabled = true;
            this.cmbTextLayer.Location = new System.Drawing.Point(300, 95);
            this.cmbTextLayer.Name = "cmbTextLayer";
            this.cmbTextLayer.Size = new System.Drawing.Size(120, 20);
            this.cmbTextLayer.TabIndex = 11;
            // 
            // lblTextLayer
            // 
            this.lblTextLayer.AutoSize = true;
            this.lblTextLayer.Location = new System.Drawing.Point(230, 98);
            this.lblTextLayer.Name = "lblTextLayer";
            this.lblTextLayer.Size = new System.Drawing.Size(59, 12);
            this.lblTextLayer.TabIndex = 10;
            this.lblTextLayer.Text = "文字图层:";
            // 
            // cmbFillLayer
            // 
            this.cmbFillLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillLayer.FormattingEnabled = true;
            this.cmbFillLayer.Location = new System.Drawing.Point(80, 125);
            this.cmbFillLayer.Name = "cmbFillLayer";
            this.cmbFillLayer.Size = new System.Drawing.Size(120, 20);
            this.cmbFillLayer.TabIndex = 9;
            // 
            // lblFillLayer
            // 
            this.lblFillLayer.AutoSize = true;
            this.lblFillLayer.Location = new System.Drawing.Point(15, 128);
            this.lblFillLayer.Name = "lblFillLayer";
            this.lblFillLayer.Size = new System.Drawing.Size(59, 12);
            this.lblFillLayer.TabIndex = 8;
            this.lblFillLayer.Text = "填充图层:";
            // 
            // cmbLineLayer
            // 
            this.cmbLineLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineLayer.FormattingEnabled = true;
            this.cmbLineLayer.Location = new System.Drawing.Point(80, 95);
            this.cmbLineLayer.Name = "cmbLineLayer";
            this.cmbLineLayer.Size = new System.Drawing.Size(120, 20);
            this.cmbLineLayer.TabIndex = 7;
            // 
            // lblLineLayer
            // 
            this.lblLineLayer.AutoSize = true;
            this.lblLineLayer.Location = new System.Drawing.Point(15, 98);
            this.lblLineLayer.Name = "lblLineLayer";
            this.lblLineLayer.Size = new System.Drawing.Size(59, 12);
            this.lblLineLayer.TabIndex = 6;
            this.lblLineLayer.Text = "表格线图层:";
            // 
            // chkKeepTextColor
            // 
            this.chkKeepTextColor.AutoSize = true;
            this.chkKeepTextColor.Location = new System.Drawing.Point(230, 65);
            this.chkKeepTextColor.Name = "chkKeepTextColor";
            this.chkKeepTextColor.Size = new System.Drawing.Size(144, 16);
            this.chkKeepTextColor.TabIndex = 5;
            this.chkKeepTextColor.Text = "是否保留Excel文本颜色";
            this.chkKeepTextColor.UseVisualStyleBackColor = true;
            // 
            // chkKeepBgColor
            // 
            this.chkKeepBgColor.AutoSize = true;
            this.chkKeepBgColor.Location = new System.Drawing.Point(17, 65);
            this.chkKeepBgColor.Name = "chkKeepBgColor";
            this.chkKeepBgColor.Size = new System.Drawing.Size(168, 16);
            this.chkKeepBgColor.TabIndex = 4;
            this.chkKeepBgColor.Text = "是否保留Excel填充背景颜色";
            this.chkKeepBgColor.UseVisualStyleBackColor = true;
            // 
            // txtFixedHeight
            // 
            this.txtFixedHeight.Location = new System.Drawing.Point(380, 33);
            this.txtFixedHeight.Name = "txtFixedHeight";
            this.txtFixedHeight.Size = new System.Drawing.Size(60, 21);
            this.txtFixedHeight.TabIndex = 3;
            this.txtFixedHeight.Text = "300";
            // 
            // radFixedHeight
            // 
            this.radFixedHeight.AutoSize = true;
            this.radFixedHeight.Location = new System.Drawing.Point(300, 35);
            this.radFixedHeight.Name = "radFixedHeight";
            this.radFixedHeight.Size = new System.Drawing.Size(77, 16);
            this.radFixedHeight.TabIndex = 2;
            this.radFixedHeight.Text = "统一高度:";
            this.radFixedHeight.UseVisualStyleBackColor = true;
            // 
            // radExcelHeight
            // 
            this.radExcelHeight.AutoSize = true;
            this.radExcelHeight.Checked = true;
            this.radExcelHeight.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radExcelHeight.Location = new System.Drawing.Point(17, 33);
            this.radExcelHeight.Name = "radExcelHeight";
            this.radExcelHeight.Size = new System.Drawing.Size(277, 21);
            this.radExcelHeight.TabIndex = 1;
            this.radExcelHeight.TabStop = true;
            this.radExcelHeight.Text = "按Excel实际字号 (高度=字号×3/11)";
            this.radExcelHeight.UseVisualStyleBackColor = true;
            // 
            // lblHeightMode
            // 
            this.lblHeightMode.AutoSize = true;
            this.lblHeightMode.Location = new System.Drawing.Point(15, 17);
            this.lblHeightMode.Name = "lblHeightMode";
            this.lblHeightMode.Size = new System.Drawing.Size(83, 12);
            this.lblHeightMode.TabIndex = 0;
            this.lblHeightMode.Text = "文字高度模式:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(380, 320);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(80, 30);
            this.btnMore.TabIndex = 5;
            this.btnMore.Text = "更多插件";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.grpRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Excel导入CAD";
            this.grpRange.ResumeLayout(false);
            this.grpRange.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpRange;
        private System.Windows.Forms.RadioButton radSelectedCells;
        private System.Windows.Forms.RadioButton radAllCells;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label lblHeightMode;
        private System.Windows.Forms.RadioButton radFixedHeight;
        private System.Windows.Forms.RadioButton radExcelHeight;
        private System.Windows.Forms.TextBox txtFixedHeight;
        private System.Windows.Forms.CheckBox chkKeepTextColor;
        private System.Windows.Forms.CheckBox chkKeepBgColor;
        private System.Windows.Forms.ComboBox cmbTextStyle;
        private System.Windows.Forms.Label lblTextStyle;
        private System.Windows.Forms.ComboBox cmbTextLayer;
        private System.Windows.Forms.Label lblTextLayer;
        private System.Windows.Forms.ComboBox cmbFillLayer;
        private System.Windows.Forms.Label lblFillLayer;
        private System.Windows.Forms.ComboBox cmbLineLayer;
        private System.Windows.Forms.Label lblLineLayer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMore;
    }
}
