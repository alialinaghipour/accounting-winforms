namespace WinForm
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tsHeader = new System.Windows.Forms.ToolStrip();
            this.btnProfile = new System.Windows.Forms.ToolStripButton();
            this.btnListConatcts = new System.Windows.Forms.ToolStripButton();
            this.btnAccounting = new System.Windows.Forms.ToolStripButton();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.timerDateTimeNow = new System.Windows.Forms.Timer(this.components);
            this.tsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHeader
            // 
            this.tsHeader.ImageScalingSize = new System.Drawing.Size(46, 16);
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfile,
            this.btnListConatcts,
            this.btnAccounting});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.Size = new System.Drawing.Size(233, 86);
            this.tsHeader.TabIndex = 0;
            this.tsHeader.Text = "toolStrip1";
            // 
            // btnProfile
            // 
            this.btnProfile.Image = global::WinForm.Properties.Resources.profile;
            this.btnProfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(68, 83);
            this.btnProfile.Text = "پروفایل";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnListConatcts
            // 
            this.btnListConatcts.Image = global::WinForm.Properties.Resources.contact;
            this.btnListConatcts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListConatcts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListConatcts.Name = "btnListConatcts";
            this.btnListConatcts.Size = new System.Drawing.Size(68, 83);
            this.btnListConatcts.Text = "مخاظبین";
            this.btnListConatcts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListConatcts.ToolTipText = "مخاظبین";
            this.btnListConatcts.Click += new System.EventHandler(this.btnListConatcts_Click);
            // 
            // btnAccounting
            // 
            this.btnAccounting.Image = global::WinForm.Properties.Resources.accounting_116483__1_;
            this.btnAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(68, 83);
            this.btnAccounting.Text = "حسابداری";
            this.btnAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccounting.ToolTipText = "حسابداری";
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.AutoSize = true;
            this.lblDateTimeNow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDateTimeNow.Location = new System.Drawing.Point(95, 94);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(38, 15);
            this.lblDateTimeNow.TabIndex = 1;
            this.lblDateTimeNow.Text = "ساعت";
            // 
            // timerDateTimeNow
            // 
            this.timerDateTimeNow.Enabled = true;
            this.timerDateTimeNow.Interval = 1000;
            this.timerDateTimeNow.Tick += new System.EventHandler(this.timerDateTimeNow_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(233, 118);
            this.Controls.Add(this.lblDateTimeNow);
            this.Controls.Add(this.tsHeader);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsHeader;
        private ToolStripButton btnProfile;
        private ToolStripButton btnListConatcts;
        private ToolStripButton btnAccounting;
        private Label lblDateTimeNow;
        private System.Windows.Forms.Timer timerDateTimeNow;
    }
}