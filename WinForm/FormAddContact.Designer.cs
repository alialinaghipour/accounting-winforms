namespace WinForm
{
    partial class FormAddContact
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
            this.btnPictureSelection = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbMobile = new System.Windows.Forms.GroupBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.gbInstagram = new System.Windows.Forms.GroupBox();
            this.tbInstagram = new System.Windows.Forms.TextBox();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbDescription.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbMobile.SuspendLayout();
            this.gbFullName.SuspendLayout();
            this.gbInstagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPictureSelection
            // 
            this.btnPictureSelection.Location = new System.Drawing.Point(12, 386);
            this.btnPictureSelection.Name = "btnPictureSelection";
            this.btnPictureSelection.Size = new System.Drawing.Size(105, 35);
            this.btnPictureSelection.TabIndex = 17;
            this.btnPictureSelection.Text = "انتخاب تضویر";
            this.btnPictureSelection.UseVisualStyleBackColor = true;
            this.btnPictureSelection.Click += new System.EventHandler(this.btnPictureSelection_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.ForeColor = System.Drawing.Color.Gold;
            this.gbImage.Location = new System.Drawing.Point(12, 12);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(253, 365);
            this.gbImage.TabIndex = 15;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "تصویر";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::WinForm.Properties.Resources.no_profile_image;
            this.pbImage.Location = new System.Drawing.Point(6, 22);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(241, 337);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.tbDescription);
            this.gbDescription.ForeColor = System.Drawing.Color.Gold;
            this.gbDescription.Location = new System.Drawing.Point(271, 275);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(200, 102);
            this.gbDescription.TabIndex = 14;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "توضیحات";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(6, 22);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(188, 71);
            this.tbDescription.TabIndex = 0;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.tbEmail);
            this.gbEmail.ForeColor = System.Drawing.Color.Gold;
            this.gbEmail.Location = new System.Drawing.Point(271, 142);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(200, 59);
            this.gbEmail.TabIndex = 13;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "ایمیل";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 22);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 23);
            this.tbEmail.TabIndex = 0;
            // 
            // gbMobile
            // 
            this.gbMobile.Controls.Add(this.tbMobile);
            this.gbMobile.ForeColor = System.Drawing.Color.Gold;
            this.gbMobile.Location = new System.Drawing.Point(271, 77);
            this.gbMobile.Name = "gbMobile";
            this.gbMobile.Size = new System.Drawing.Size(200, 59);
            this.gbMobile.TabIndex = 12;
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
            // gbFullName
            // 
            this.gbFullName.Controls.Add(this.tbFullName);
            this.gbFullName.ForeColor = System.Drawing.Color.Gold;
            this.gbFullName.Location = new System.Drawing.Point(271, 12);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Size = new System.Drawing.Size(200, 59);
            this.gbFullName.TabIndex = 11;
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
            // gbInstagram
            // 
            this.gbInstagram.Controls.Add(this.tbInstagram);
            this.gbInstagram.ForeColor = System.Drawing.Color.Gold;
            this.gbInstagram.Location = new System.Drawing.Point(271, 207);
            this.gbInstagram.Name = "gbInstagram";
            this.gbInstagram.Size = new System.Drawing.Size(200, 59);
            this.gbInstagram.TabIndex = 14;
            this.gbInstagram.TabStop = false;
            this.gbInstagram.Text = "اینستاگرام";
            // 
            // tbInstagram
            // 
            this.tbInstagram.Location = new System.Drawing.Point(6, 22);
            this.tbInstagram.Name = "tbInstagram";
            this.tbInstagram.Size = new System.Drawing.Size(188, 23);
            this.tbInstagram.TabIndex = 0;
            // 
            // FormAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(486, 431);
            this.Controls.Add(this.gbInstagram);
            this.Controls.Add(this.btnPictureSelection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.gbEmail);
            this.Controls.Add(this.gbMobile);
            this.Controls.Add(this.gbFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت کارمند";
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbMobile.ResumeLayout(false);
            this.gbMobile.PerformLayout();
            this.gbFullName.ResumeLayout(false);
            this.gbFullName.PerformLayout();
            this.gbInstagram.ResumeLayout(false);
            this.gbInstagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPictureSelection;
        private Button btnSave;
        private GroupBox gbImage;
        private PictureBox pbImage;
        private GroupBox gbDescription;
        private TextBox tbDescription;
        private GroupBox gbEmail;
        private TextBox tbEmail;
        private GroupBox gbMobile;
        private TextBox tbMobile;
        private GroupBox gbFullName;
        private TextBox tbFullName;
        private GroupBox gbInstagram;
        private TextBox tbInstagram;
    }
}