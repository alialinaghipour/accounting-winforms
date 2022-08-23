namespace WinForm
{
    partial class frmContacts
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
            this.btnAddContact = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateContact = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteContact = new System.Windows.Forms.ToolStripButton();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContacts = new System.Windows.Forms.GroupBox();
            this.tsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.gbContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHeader
            // 
            this.tsHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddContact,
            this.btnUpdateContact,
            this.btnDeleteContact,
            this.lblSearch,
            this.tbSearch,
            this.tbRefresh});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsHeader.Size = new System.Drawing.Size(543, 86);
            this.tsHeader.TabIndex = 0;
            this.tsHeader.Text = "مخاطبین";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Image = global::WinForm.Properties.Resources.AddContact;
            this.btnAddContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(111, 83);
            this.btnAddContact.Text = "افزودن مخاطب جدید";
            this.btnAddContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Image = global::WinForm.Properties.Resources.EditContact;
            this.btnUpdateContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdateContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(83, 83);
            this.btnUpdateContact.Text = "ویرایش شخص";
            this.btnUpdateContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Image = global::WinForm.Properties.Resources.DeleteContent;
            this.btnDeleteContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(72, 83);
            this.btnDeleteContact.Text = "حذف شخص";
            this.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 83);
            this.lblSearch.Text = "جستجو کنید : ";
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 86);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbRefresh
            // 
            this.tbRefresh.Image = global::WinForm.Properties.Resources.Refresh;
            this.tbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(72, 83);
            this.tbRefresh.Text = "حذف شخص";
            this.tbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Mobile,
            this.Instagram});
            this.dgvContacts.Location = new System.Drawing.Point(12, 22);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowTemplate.Height = 25;
            this.dgvContacts.Size = new System.Drawing.Size(519, 296);
            this.dgvContacts.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Instagram
            // 
            this.Instagram.DataPropertyName = "Instagram";
            this.Instagram.HeaderText = "اینستاگرام";
            this.Instagram.Name = "Instagram";
            this.Instagram.ReadOnly = true;
            // 
            // gbContacts
            // 
            this.gbContacts.Controls.Add(this.dgvContacts);
            this.gbContacts.Location = new System.Drawing.Point(0, 89);
            this.gbContacts.Name = "gbContacts";
            this.gbContacts.Size = new System.Drawing.Size(543, 324);
            this.gbContacts.TabIndex = 2;
            this.gbContacts.TabStop = false;
            this.gbContacts.Text = "فهرست مخاطبین";
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 425);
            this.Controls.Add(this.gbContacts);
            this.Controls.Add(this.tsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContacts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مخاطبین";
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.gbContacts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsHeader;
        private ToolStripButton btnAddContact;
        private ToolStripButton btnUpdateContact;
        private ToolStripButton btnDeleteContact;
        private ToolStripLabel lblSearch;
        private ToolStripTextBox tbSearch;
        private ToolStripButton tbRefresh;
        private DataGridView dgvContacts;
        private GroupBox gbContacts;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Instagram;
    }
}