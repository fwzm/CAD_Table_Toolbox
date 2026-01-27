namespace CAD_Table_Toolbox
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpGenerate = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpLayer = new System.Windows.Forms.GroupBox();
            this.btnCreateLayer = new System.Windows.Forms.Button();
            this.txtNewLayer = new System.Windows.Forms.TextBox();
            this.lblNewLayer = new System.Windows.Forms.Label();
            this.cmbLayers = new System.Windows.Forms.ComboBox();
            this.lblSelectLayer = new System.Windows.Forms.Label();
            this.grpBorder = new System.Windows.Forms.GroupBox();
            this.txtInnerWidth = new System.Windows.Forms.TextBox();
            this.lblInnerWidth = new System.Windows.Forms.Label();
            this.txtBorderWidth = new System.Windows.Forms.TextBox();
            this.lblBorderWidth = new System.Windows.Forms.Label();
            this.chkBoldBorder = new System.Windows.Forms.CheckBox();
            this.grpBasic = new System.Windows.Forms.GroupBox();
            this.txtOtherCol = new System.Windows.Forms.TextBox();
            this.lblOtherCol = new System.Windows.Forms.Label();
            this.txtFirstCol = new System.Windows.Forms.TextBox();
            this.lblFirstCol = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtOtherRow = new System.Windows.Forms.TextBox();
            this.lblOtherRow = new System.Windows.Forms.Label();
            this.txtFirstRow = new System.Windows.Forms.TextBox();
            this.lblFirstRow = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.grpImport = new System.Windows.Forms.GroupBox();
            this.btnLinkExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.grpConvert = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnLinesToTable = new System.Windows.Forms.Button();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnAutoAdjust = new System.Windows.Forms.Button();
            this.btnAlignText = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.grpGenerate.SuspendLayout();
            this.grpLayer.SuspendLayout();
            this.grpBorder.SuspendLayout();
            this.grpBasic.SuspendLayout();
            this.grpImport.SuspendLayout();
            this.grpConvert.SuspendLayout();
            this.grpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenerate
            // 
            this.grpGenerate.Controls.Add(this.btnGenerate);
            this.grpGenerate.Controls.Add(this.grpLayer);
            this.grpGenerate.Controls.Add(this.grpBorder);
            this.grpGenerate.Controls.Add(this.grpBasic);
            this.grpGenerate.Location = new System.Drawing.Point(12, 12);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(560, 260);
            this.grpGenerate.TabIndex = 0;
            this.grpGenerate.TabStop = false;
            this.grpGenerate.Text = "表格生成";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerate.Location = new System.Drawing.Point(400, 220);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "生成表格";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpLayer
            // 
            this.grpLayer.Controls.Add(this.btnCreateLayer);
            this.grpLayer.Controls.Add(this.txtNewLayer);
            this.grpLayer.Controls.Add(this.lblNewLayer);
            this.grpLayer.Controls.Add(this.cmbLayers);
            this.grpLayer.Controls.Add(this.lblSelectLayer);
            this.grpLayer.Location = new System.Drawing.Point(280, 110);
            this.grpLayer.Name = "grpLayer";
            this.grpLayer.Size = new System.Drawing.Size(260, 100);
            this.grpLayer.TabIndex = 2;
            this.grpLayer.TabStop = false;
            this.grpLayer.Text = "图层设置";
            // 
            // btnCreateLayer
            // 
            this.btnCreateLayer.Location = new System.Drawing.Point(20, 70);
            this.btnCreateLayer.Name = "btnCreateLayer";
            this.btnCreateLayer.Size = new System.Drawing.Size(220, 23);
            this.btnCreateLayer.TabIndex = 4;
            this.btnCreateLayer.Text = "创建新图层";
            this.btnCreateLayer.UseVisualStyleBackColor = true;
            this.btnCreateLayer.Click += new System.EventHandler(this.btnCreateLayer_Click);
            // 
            // txtNewLayer
            // 
            this.txtNewLayer.Location = new System.Drawing.Point(90, 45);
            this.txtNewLayer.Name = "txtNewLayer";
            this.txtNewLayer.Size = new System.Drawing.Size(150, 21);
            this.txtNewLayer.TabIndex = 3;
            // 
            // lblNewLayer
            // 
            this.lblNewLayer.AutoSize = true;
            this.lblNewLayer.Location = new System.Drawing.Point(18, 48);
            this.lblNewLayer.Name = "lblNewLayer";
            this.lblNewLayer.Size = new System.Drawing.Size(71, 12);
            this.lblNewLayer.TabIndex = 2;
            this.lblNewLayer.Text = "新建图层名:";
            // 
            // cmbLayers
            // 
            this.cmbLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLayers.FormattingEnabled = true;
            this.cmbLayers.Location = new System.Drawing.Point(90, 18);
            this.cmbLayers.Name = "cmbLayers";
            this.cmbLayers.Size = new System.Drawing.Size(150, 20);
            this.cmbLayers.TabIndex = 1;
            // 
            // lblSelectLayer
            // 
            this.lblSelectLayer.AutoSize = true;
            this.lblSelectLayer.Location = new System.Drawing.Point(18, 21);
            this.lblSelectLayer.Name = "lblSelectLayer";
            this.lblSelectLayer.Size = new System.Drawing.Size(59, 12);
            this.lblSelectLayer.TabIndex = 0;
            this.lblSelectLayer.Text = "选择图层:";
            // 
            // grpBorder
            // 
            this.grpBorder.Controls.Add(this.txtInnerWidth);
            this.grpBorder.Controls.Add(this.lblInnerWidth);
            this.grpBorder.Controls.Add(this.txtBorderWidth);
            this.grpBorder.Controls.Add(this.lblBorderWidth);
            this.grpBorder.Controls.Add(this.chkBoldBorder);
            this.grpBorder.Location = new System.Drawing.Point(20, 110);
            this.grpBorder.Name = "grpBorder";
            this.grpBorder.Size = new System.Drawing.Size(240, 100);
            this.grpBorder.TabIndex = 1;
            this.grpBorder.TabStop = false;
            this.grpBorder.Text = "边框设置";
            // 
            // txtInnerWidth
            // 
            this.txtInnerWidth.Location = new System.Drawing.Point(80, 70);
            this.txtInnerWidth.Name = "txtInnerWidth";
            this.txtInnerWidth.Size = new System.Drawing.Size(100, 21);
            this.txtInnerWidth.TabIndex = 4;
            this.txtInnerWidth.Text = "0.0";
            // 
            // lblInnerWidth
            // 
            this.lblInnerWidth.AutoSize = true;
            this.lblInnerWidth.Location = new System.Drawing.Point(15, 73);
            this.lblInnerWidth.Name = "lblInnerWidth";
            this.lblInnerWidth.Size = new System.Drawing.Size(59, 12);
            this.lblInnerWidth.TabIndex = 3;
            this.lblInnerWidth.Text = "内部线宽:";
            // 
            // txtBorderWidth
            // 
            this.txtBorderWidth.Location = new System.Drawing.Point(80, 43);
            this.txtBorderWidth.Name = "txtBorderWidth";
            this.txtBorderWidth.Size = new System.Drawing.Size(100, 21);
            this.txtBorderWidth.TabIndex = 2;
            this.txtBorderWidth.Text = "0.6";
            // 
            // lblBorderWidth
            // 
            this.lblBorderWidth.AutoSize = true;
            this.lblBorderWidth.Location = new System.Drawing.Point(15, 46);
            this.lblBorderWidth.Name = "lblBorderWidth";
            this.lblBorderWidth.Size = new System.Drawing.Size(59, 12);
            this.lblBorderWidth.TabIndex = 1;
            this.lblBorderWidth.Text = "边框线宽:";
            // 
            // chkBoldBorder
            // 
            this.chkBoldBorder.AutoSize = true;
            this.chkBoldBorder.Location = new System.Drawing.Point(17, 20);
            this.chkBoldBorder.Name = "chkBoldBorder";
            this.chkBoldBorder.Size = new System.Drawing.Size(72, 16);
            this.chkBoldBorder.TabIndex = 0;
            this.chkBoldBorder.Text = "边框加粗";
            this.chkBoldBorder.UseVisualStyleBackColor = true;
            // 
            // grpBasic
            // 
            this.grpBasic.Controls.Add(this.txtOtherCol);
            this.grpBasic.Controls.Add(this.lblOtherCol);
            this.grpBasic.Controls.Add(this.txtFirstCol);
            this.grpBasic.Controls.Add(this.lblFirstCol);
            this.grpBasic.Controls.Add(this.txtCols);
            this.grpBasic.Controls.Add(this.lblCols);
            this.grpBasic.Controls.Add(this.txtOtherRow);
            this.grpBasic.Controls.Add(this.lblOtherRow);
            this.grpBasic.Controls.Add(this.txtFirstRow);
            this.grpBasic.Controls.Add(this.lblFirstRow);
            this.grpBasic.Controls.Add(this.txtRows);
            this.grpBasic.Controls.Add(this.lblRows);
            this.grpBasic.Location = new System.Drawing.Point(20, 20);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(520, 80);
            this.grpBasic.TabIndex = 0;
            this.grpBasic.TabStop = false;
            this.grpBasic.Text = "基本设置（行列距留空自动均分）";
            // 
            // txtOtherCol
            // 
            this.txtOtherCol.Location = new System.Drawing.Point(400, 48);
            this.txtOtherCol.Name = "txtOtherCol";
            this.txtOtherCol.Size = new System.Drawing.Size(100, 21);
            this.txtOtherCol.TabIndex = 11;
            // 
            // lblOtherCol
            // 
            this.lblOtherCol.AutoSize = true;
            this.lblOtherCol.Location = new System.Drawing.Point(320, 51);
            this.lblOtherCol.Name = "lblOtherCol";
            this.lblOtherCol.Size = new System.Drawing.Size(71, 12);
            this.lblOtherCol.TabIndex = 10;
            this.lblOtherCol.Text = "其他列列距:";
            // 
            // txtFirstCol
            // 
            this.txtFirstCol.Location = new System.Drawing.Point(400, 20);
            this.txtFirstCol.Name = "txtFirstCol";
            this.txtFirstCol.Size = new System.Drawing.Size(100, 21);
            this.txtFirstCol.TabIndex = 9;
            // 
            // lblFirstCol
            // 
            this.lblFirstCol.AutoSize = true;
            this.lblFirstCol.Location = new System.Drawing.Point(320, 23);
            this.lblFirstCol.Name = "lblFirstCol";
            this.lblFirstCol.Size = new System.Drawing.Size(71, 12);
            this.lblFirstCol.TabIndex = 8;
            this.lblFirstCol.Text = "第一列列距:";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(210, 20);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(80, 21);
            this.txtCols.TabIndex = 7;
            this.txtCols.Text = "5";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(170, 23);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(35, 12);
            this.lblCols.TabIndex = 6;
            this.lblCols.Text = "列数:";
            // 
            // txtOtherRow
            // 
            this.txtOtherRow.Location = new System.Drawing.Point(210, 48);
            this.txtOtherRow.Name = "txtOtherRow";
            this.txtOtherRow.Size = new System.Drawing.Size(80, 21);
            this.txtOtherRow.TabIndex = 5;
            // 
            // lblOtherRow
            // 
            this.lblOtherRow.AutoSize = true;
            this.lblOtherRow.Location = new System.Drawing.Point(135, 51);
            this.lblOtherRow.Name = "lblOtherRow";
            this.lblOtherRow.Size = new System.Drawing.Size(71, 12);
            this.lblOtherRow.TabIndex = 4;
            this.lblOtherRow.Text = "其他行行距:";
            // 
            // txtFirstRow
            // 
            this.txtFirstRow.Location = new System.Drawing.Point(80, 48);
            this.txtFirstRow.Name = "txtFirstRow";
            this.txtFirstRow.Size = new System.Drawing.Size(50, 21);
            this.txtFirstRow.TabIndex = 3;
            // 
            // lblFirstRow
            // 
            this.lblFirstRow.AutoSize = true;
            this.lblFirstRow.Location = new System.Drawing.Point(6, 51);
            this.lblFirstRow.Name = "lblFirstRow";
            this.lblFirstRow.Size = new System.Drawing.Size(71, 12);
            this.lblFirstRow.TabIndex = 2;
            this.lblFirstRow.Text = "第一行行距:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(80, 20);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(50, 21);
            this.txtRows.TabIndex = 1;
            this.txtRows.Text = "5";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(6, 23);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 12);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "行数:";
            // 
            // grpImport
            // 
            this.grpImport.Controls.Add(this.btnLinkExcel);
            this.grpImport.Controls.Add(this.btnImportExcel);
            this.grpImport.Location = new System.Drawing.Point(12, 278);
            this.grpImport.Name = "grpImport";
            this.grpImport.Size = new System.Drawing.Size(560, 60);
            this.grpImport.TabIndex = 1;
            this.grpImport.TabStop = false;
            this.grpImport.Text = "表格导入";
            // 
            // btnLinkExcel
            // 
            this.btnLinkExcel.Location = new System.Drawing.Point(360, 20);
            this.btnLinkExcel.Name = "btnLinkExcel";
            this.btnLinkExcel.Size = new System.Drawing.Size(150, 30);
            this.btnLinkExcel.TabIndex = 1;
            this.btnLinkExcel.Text = "链接Excel表格";
            this.btnLinkExcel.UseVisualStyleBackColor = true;
            this.btnLinkExcel.Click += new System.EventHandler(this.btnLinkExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(40, 20);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(150, 30);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "导入Excel表格";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // grpConvert
            // 
            this.grpConvert.Controls.Add(this.btnExportExcel);
            this.grpConvert.Controls.Add(this.btnLinesToTable);
            this.grpConvert.Location = new System.Drawing.Point(12, 344);
            this.grpConvert.Name = "grpConvert";
            this.grpConvert.Size = new System.Drawing.Size(560, 60);
            this.grpConvert.TabIndex = 2;
            this.grpConvert.TabStop = false;
            this.grpConvert.Text = "表格转换";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(360, 20);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(150, 30);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "线条表格导出到Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnLinesToTable
            // 
            this.btnLinesToTable.Location = new System.Drawing.Point(40, 20);
            this.btnLinesToTable.Name = "btnLinesToTable";
            this.btnLinesToTable.Size = new System.Drawing.Size(150, 30);
            this.btnLinesToTable.TabIndex = 0;
            this.btnLinesToTable.Text = "线条表格转table表格";
            this.btnLinesToTable.UseVisualStyleBackColor = true;
            this.btnLinesToTable.Click += new System.EventHandler(this.btnLinesToTable_Click);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.btnAutoAdjust);
            this.grpEdit.Controls.Add(this.btnAlignText);
            this.grpEdit.Location = new System.Drawing.Point(12, 410);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(560, 60);
            this.grpEdit.TabIndex = 3;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "表格编辑";
            // 
            // btnAutoAdjust
            // 
            this.btnAutoAdjust.Location = new System.Drawing.Point(330, 20);
            this.btnAutoAdjust.Name = "btnAutoAdjust";
            this.btnAutoAdjust.Size = new System.Drawing.Size(180, 30);
            this.btnAutoAdjust.TabIndex = 1;
            this.btnAutoAdjust.Text = "自动调整Table表格行高列宽";
            this.btnAutoAdjust.UseVisualStyleBackColor = true;
            this.btnAutoAdjust.Click += new System.EventHandler(this.btnAutoAdjust_Click);
            // 
            // btnAlignText
            // 
            this.btnAlignText.Location = new System.Drawing.Point(40, 20);
            this.btnAlignText.Name = "btnAlignText";
            this.btnAlignText.Size = new System.Drawing.Size(150, 30);
            this.btnAlignText.TabIndex = 0;
            this.btnAlignText.Text = "线条表格文字批量对齐";
            this.btnAlignText.UseVisualStyleBackColor = true;
            this.btnAlignText.Click += new System.EventHandler(this.btnAlignText_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(320, 480);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(80, 30);
            this.btnMore.TabIndex = 5;
            this.btnMore.Text = "更多插件";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.grpConvert);
            this.Controls.Add(this.grpImport);
            this.Controls.Add(this.grpGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "表格工具箱V4.0版 (CAD自学网) by 周站长";
            this.grpGenerate.ResumeLayout(false);
            this.grpLayer.ResumeLayout(false);
            this.grpLayer.PerformLayout();
            this.grpBorder.ResumeLayout(false);
            this.grpBorder.PerformLayout();
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.grpImport.ResumeLayout(false);
            this.grpConvert.ResumeLayout(false);
            this.grpEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenerate;
        private System.Windows.Forms.GroupBox grpBasic;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtOtherRow;
        private System.Windows.Forms.Label lblOtherRow;
        private System.Windows.Forms.TextBox txtFirstRow;
        private System.Windows.Forms.Label lblFirstRow;
        private System.Windows.Forms.TextBox txtOtherCol;
        private System.Windows.Forms.Label lblOtherCol;
        private System.Windows.Forms.TextBox txtFirstCol;
        private System.Windows.Forms.Label lblFirstCol;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.GroupBox grpBorder;
        private System.Windows.Forms.CheckBox chkBoldBorder;
        private System.Windows.Forms.TextBox txtInnerWidth;
        private System.Windows.Forms.Label lblInnerWidth;
        private System.Windows.Forms.TextBox txtBorderWidth;
        private System.Windows.Forms.Label lblBorderWidth;
        private System.Windows.Forms.GroupBox grpLayer;
        private System.Windows.Forms.ComboBox cmbLayers;
        private System.Windows.Forms.Label lblSelectLayer;
        private System.Windows.Forms.TextBox txtNewLayer;
        private System.Windows.Forms.Label lblNewLayer;
        private System.Windows.Forms.Button btnCreateLayer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpImport;
        private System.Windows.Forms.Button btnLinkExcel;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.GroupBox grpConvert;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnLinesToTable;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnAutoAdjust;
        private System.Windows.Forms.Button btnAlignText;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMore;
    }
}
