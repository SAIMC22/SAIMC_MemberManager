﻿namespace SAIMC_MemberManager
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnviewmeetings = new System.Windows.Forms.Button();
            this.btnGenerateQrCode = new System.Windows.Forms.Button();
            this.lbadmin = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnviewmeetings
            // 
            this.btnviewmeetings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnviewmeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmeetings.Location = new System.Drawing.Point(230, 382);
            this.btnviewmeetings.Name = "btnviewmeetings";
            this.btnviewmeetings.Size = new System.Drawing.Size(247, 31);
            this.btnviewmeetings.TabIndex = 10;
            this.btnviewmeetings.Text = "View Meetings";
            this.btnviewmeetings.UseVisualStyleBackColor = true;
            this.btnviewmeetings.Click += new System.EventHandler(this.btnviewmeetings_Click);
            // 
            // btnGenerateQrCode
            // 
            this.btnGenerateQrCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerateQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQrCode.Location = new System.Drawing.Point(230, 270);
            this.btnGenerateQrCode.Name = "btnGenerateQrCode";
            this.btnGenerateQrCode.Size = new System.Drawing.Size(247, 31);
            this.btnGenerateQrCode.TabIndex = 9;
            this.btnGenerateQrCode.Text = "Generate QR Codes";
            this.btnGenerateQrCode.UseVisualStyleBackColor = true;
            this.btnGenerateQrCode.Click += new System.EventHandler(this.btnGenerateQrCode_Click_1);
            // 
            // lbadmin
            // 
            this.lbadmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbadmin.AutoSize = true;
            this.lbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadmin.Location = new System.Drawing.Point(183, 191);
            this.lbadmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(364, 39);
            this.lbadmin.TabIndex = 11;
            this.lbadmin.Text = "Select Admin Function";
            this.lbadmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(230, 419);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(247, 31);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Scan Members";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(230, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Manage Members";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCloseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApplication.Location = new System.Drawing.Point(230, 457);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(247, 31);
            this.btnCloseApplication.TabIndex = 14;
            this.btnCloseApplication.Text = "Exit Application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::SAIMC_MemberManager.Properties.Resources.SAIMC_NEW2;
            this.pictureBox1.Location = new System.Drawing.Point(104, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMeeting.Location = new System.Drawing.Point(230, 344);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(247, 31);
            this.btnCreateMeeting.TabIndex = 16;
            this.btnCreateMeeting.Text = "Create New Meeting";
            this.btnCreateMeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 491);
            this.Controls.Add(this.btnCreateMeeting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lbadmin);
            this.Controls.Add(this.btnviewmeetings);
            this.Controls.Add(this.btnGenerateQrCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnviewmeetings;
        private System.Windows.Forms.Button btnGenerateQrCode;
        private System.Windows.Forms.Label lbadmin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateMeeting;
    }
}