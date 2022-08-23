namespace WinForm
{
    partial class FormAccounting
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
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnListPayment = new System.Windows.Forms.ToolStripButton();
            this.btnListReceive = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDateTiemNow = new System.Windows.Forms.Button();
            this.mtbEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblRevice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsHeader
            // 
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewTransaction,
            this.btnListPayment,
            this.btnListReceive});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.Size = new System.Drawing.Size(304, 112);
            this.tsHeader.TabIndex = 0;
            this.tsHeader.Text = "toolStrip1";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = global::WinForm.Properties.Resources.newT;
            this.btnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(94, 109);
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // btnListPayment
            // 
            this.btnListPayment.Image = global::WinForm.Properties.Resources.listPrdakhti;
            this.btnListPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListPayment.Name = "btnListPayment";
            this.btnListPayment.Size = new System.Drawing.Size(95, 109);
            this.btnListPayment.Text = "لیست پرداختی ها";
            this.btnListPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListPayment.Click += new System.EventHandler(this.btnListPayment_Click);
            // 
            // btnListReceive
            // 
            this.btnListReceive.Image = global::WinForm.Properties.Resources.listDaryafti;
            this.btnListReceive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListReceive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListReceive.Name = "btnListReceive";
            this.btnListReceive.Size = new System.Drawing.Size(96, 109);
            this.btnListReceive.Text = "لیست دریافتی ها";
            this.btnListReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListReceive.Click += new System.EventHandler(this.btnListReceive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDateTiemNow);
            this.groupBox1.Controls.Add(this.mtbEndDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbStartDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPayment);
            this.groupBox1.Controls.Add(this.lblRevice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش مالی همین ماه";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Location = new System.Drawing.Point(6, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "بگرد";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDateTiemNow
            // 
            this.btnDateTiemNow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDateTiemNow.Location = new System.Drawing.Point(33, 56);
            this.btnDateTiemNow.Name = "btnDateTiemNow";
            this.btnDateTiemNow.Size = new System.Drawing.Size(44, 23);
            this.btnDateTiemNow.TabIndex = 6;
            this.btnDateTiemNow.Text = "امروز";
            this.btnDateTiemNow.UseVisualStyleBackColor = false;
            this.btnDateTiemNow.Click += new System.EventHandler(this.btnDateTiemNow_Click);
            // 
            // mtbEndDate
            // 
            this.mtbEndDate.Location = new System.Drawing.Point(83, 57);
            this.mtbEndDate.Mask = "0000/00/00";
            this.mtbEndDate.Name = "mtbEndDate";
            this.mtbEndDate.Size = new System.Drawing.Size(100, 23);
            this.mtbEndDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "تا تاریخ : ";
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.Location = new System.Drawing.Point(83, 24);
            this.mtbStartDate.Mask = "0000/00/00";
            this.mtbStartDate.Name = "mtbStartDate";
            this.mtbStartDate.Size = new System.Drawing.Size(100, 23);
            this.mtbStartDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "از تاریخ : ";
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(37, 164);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(130, 15);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "مانده :";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(154, 131);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(13, 15);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "0";
            // 
            // lblRevice
            // 
            this.lblRevice.AutoSize = true;
            this.lblRevice.Location = new System.Drawing.Point(154, 95);
            this.lblRevice.Name = "lblRevice";
            this.lblRevice.Size = new System.Drawing.Size(13, 15);
            this.lblRevice.TabIndex = 2;
            this.lblRevice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // FormAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAccounting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.FormAccounting_Load);
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsHeader;
        private ToolStripButton btnNewTransaction;
        private ToolStripButton btnListPayment;
        private ToolStripButton btnListReceive;
        private GroupBox groupBox1;
        private Label lblRevice;
        private Label label2;
        private Label label1;
        private Label lblPayment;
        private Label lblBalance;
        private Label label4;
        private Button btnDateTiemNow;
        private MaskedTextBox mtbEndDate;
        private Label label3;
        private MaskedTextBox mtbStartDate;
        private Label label5;
        private Button btnSearch;
    }
}