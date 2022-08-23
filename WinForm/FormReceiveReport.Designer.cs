namespace WinForm
{
    partial class FormReceiveReport
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
            this.tsHeader = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDateTiemNow = new System.Windows.Forms.Button();
            this.mtbEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbContactsName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReports = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsHeader.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tsHeader
            // 
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnDelete,
            this.toolStripLabel1,
            this.btnRefresh,
            this.btnReport});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.Size = new System.Drawing.Size(746, 86);
            this.tsHeader.TabIndex = 1;
            this.tsHeader.Text = "toolStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::WinForm.Properties.Resources.EditContact;
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 83);
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WinForm.Properties.Resources.DeleteContent;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 83);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(440, 83);
            this.toolStripLabel1.Text = "\"امام علی علیه اسلام : خداوند براى هر كارى پاداشى قرار داده است و براى هر چيزى حس" +
    "ابى\"";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::WinForm.Properties.Resources.Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 83);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::WinForm.Properties.Resources.Print;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(68, 83);
            this.btnReport.Text = "چاپ";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.btnDateTiemNow);
            this.gbSearch.Controls.Add(this.mtbEndDate);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.mtbStartDate);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.cbContactsName);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Location = new System.Drawing.Point(14, 89);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(720, 74);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "جستجو";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Location = new System.Drawing.Point(6, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بگرد";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDateTiemNow
            // 
            this.btnDateTiemNow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDateTiemNow.Location = new System.Drawing.Point(137, 30);
            this.btnDateTiemNow.Name = "btnDateTiemNow";
            this.btnDateTiemNow.Size = new System.Drawing.Size(43, 23);
            this.btnDateTiemNow.TabIndex = 2;
            this.btnDateTiemNow.Text = "امروز";
            this.btnDateTiemNow.UseVisualStyleBackColor = false;
            this.btnDateTiemNow.Click += new System.EventHandler(this.btnDateTiemNow_Click);
            // 
            // mtbEndDate
            // 
            this.mtbEndDate.Location = new System.Drawing.Point(186, 30);
            this.mtbEndDate.Mask = "0000/00/00";
            this.mtbEndDate.Name = "mtbEndDate";
            this.mtbEndDate.Size = new System.Drawing.Size(100, 23);
            this.mtbEndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "تا تاریخ : ";
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.Location = new System.Drawing.Point(348, 30);
            this.mtbStartDate.Mask = "0000/00/00";
            this.mtbStartDate.Name = "mtbStartDate";
            this.mtbStartDate.Size = new System.Drawing.Size(100, 23);
            this.mtbStartDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ : ";
            // 
            // cbContactsName
            // 
            this.cbContactsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactsName.FormattingEnabled = true;
            this.cbContactsName.Location = new System.Drawing.Point(511, 30);
            this.cbContactsName.Name = "cbContactsName";
            this.cbContactsName.Size = new System.Drawing.Size(121, 23);
            this.cbContactsName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "طرف حساب : ";
            // 
            // gbReports
            // 
            this.gbReports.Controls.Add(this.dgvReport);
            this.gbReports.Location = new System.Drawing.Point(14, 169);
            this.gbReports.Name = "gbReports";
            this.gbReports.Size = new System.Drawing.Size(720, 270);
            this.gbReports.TabIndex = 3;
            this.gbReports.TabStop = false;
            this.gbReports.Text = "گزارش";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FullName,
            this.Amount,
            this.CreationDate,
            this.Description});
            this.dgvReport.Location = new System.Drawing.Point(6, 22);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Height = 25;
            this.dgvReport.Size = new System.Drawing.Size(708, 242);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "طرف حساب";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "تاریخ";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FormReceiveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 448);
            this.Controls.Add(this.gbReports);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.tsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReceiveReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دریافتی";
            this.Load += new System.EventHandler(this.FormReceiveReport_Load);
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsHeader;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnDelete;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnRefresh;
        private ToolStripButton btnReport;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Button btnDateTiemNow;
        private MaskedTextBox mtbEndDate;
        private Label label3;
        private MaskedTextBox mtbStartDate;
        private Label label2;
        private ComboBox cbContactsName;
        private Label label1;
        private GroupBox gbReports;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn Description;
    }
}