namespace WinForm
{
    partial class frmProfile
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
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.gbMobile = new System.Windows.Forms.GroupBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.gbInstagram = new System.Windows.Forms.GroupBox();
            this.tbInstageram = new System.Windows.Forms.TextBox();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPictureSelection = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbFullName.SuspendLayout();
            this.gbMobile.SuspendLayout();
            this.gbInstagram.SuspendLayout();
            this.gbDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFullName
            // 
            this.gbFullName.Controls.Add(this.tbFullName);
            this.gbFullName.ForeColor = System.Drawing.Color.Gold;
            this.gbFullName.Location = new System.Drawing.Point(271, 35);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Size = new System.Drawing.Size(200, 59);
            this.gbFullName.TabIndex = 0;
            this.gbFullName.TabStop = false;
            this.gbFullName.Text = "نام و نام خانوادگی";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(6, 22);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(188, 23);
            this.tbFullName.TabIndex = 0;
            // 
            // gbMobile
            // 
            this.gbMobile.Controls.Add(this.tbMobile);
            this.gbMobile.ForeColor = System.Drawing.Color.Gold;
            this.gbMobile.Location = new System.Drawing.Point(271, 100);
            this.gbMobile.Name = "gbMobile";
            this.gbMobile.Size = new System.Drawing.Size(200, 59);
            this.gbMobile.TabIndex = 1;
            this.gbMobile.TabStop = false;
            this.gbMobile.Text = "موبایل";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(6, 22);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(188, 23);
            this.tbMobile.TabIndex = 0;
            // 
            // gbInstagram
            // 
            this.gbInstagram.Controls.Add(this.tbInstageram);
            this.gbInstagram.ForeColor = System.Drawing.Color.Gold;
            this.gbInstagram.Location = new System.Drawing.Point(271, 165);
            this.gbInstagram.Name = "gbInstagram";
            this.gbInstagram.Size = new System.Drawing.Size(200, 59);
            this.gbInstagram.TabIndex = 2;
            this.gbInstagram.TabStop = false;
            this.gbInstagram.Text = "اینستاگرام";
            // 
            // tbInstageram
            // 
            this.tbInstageram.Location = new System.Drawing.Point(6, 22);
            this.tbInstageram.Name = "tbInstageram";
            this.tbInstageram.Size = new System.Drawing.Size(188, 23);
            this.tbInstageram.TabIndex = 0;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.tbDescription);
            this.gbDescription.ForeColor = System.Drawing.Color.Gold;
            this.gbDescription.Location = new System.Drawing.Point(271, 230);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(200, 132);
            this.gbDescription.TabIndex = 3;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "توضیحات";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(6, 22);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(188, 95);
            this.tbDescription.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Image = global::WinForm.Properties.Resources.no_profile_image;
            this.pbImage.Location = new System.Drawing.Point(6, 22);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(228, 299);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.ForeColor = System.Drawing.Color.Gold;
            this.gbImage.Location = new System.Drawing.Point(12, 26);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(240, 336);
            this.gbImage.TabIndex = 5;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "تصویر";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره تغییرات";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPictureSelection
            // 
            this.btnPictureSelection.Location = new System.Drawing.Point(138, 368);
            this.btnPictureSelection.Name = "btnPictureSelection";
            this.btnPictureSelection.Size = new System.Drawing.Size(105, 35);
            this.btnPictureSelection.TabIndex = 8;
            this.btnPictureSelection.Text = "انتخاب تضویر";
            this.btnPictureSelection.UseVisualStyleBackColor = true;
            this.btnPictureSelection.Click += new System.EventHandler(this.btnPictureSelection_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "خروج از برنامه";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "تغییر رمز";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPictureSelection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.gbInstagram);
            this.Controls.Add(this.gbMobile);
            this.Controls.Add(this.gbFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پروفایل";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.gbFullName.ResumeLayout(false);
            this.gbFullName.PerformLayout();
            this.gbMobile.ResumeLayout(false);
            this.gbMobile.PerformLayout();
            this.gbInstagram.ResumeLayout(false);
            this.gbInstagram.PerformLayout();
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbFullName;
        private TextBox tbFullName;
        private GroupBox gbMobile;
        private TextBox tbMobile;
        private GroupBox gbInstagram;
        private TextBox tbInstageram;
        private GroupBox gbDescription;
        private TextBox tbDescription;
        private PictureBox pbImage;
        private GroupBox gbImage;
        private Button btnSave;
        private Button btnPictureSelection;
        private Button btnExit;
        private Button button2;
    }
}