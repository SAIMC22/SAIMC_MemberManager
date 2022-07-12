
namespace SAIMC_MemberManager
{
    partial class frmScanQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanQR));
            this.label2 = new System.Windows.Forms.Label();
            this.txtScanmembership = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckTick = new System.Windows.Forms.Timer(this.components);
            this.pbxGranted = new System.Windows.Forms.PictureBox();
            this.pbxDenied = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblMeetingAgenda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGranted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDenied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Scan Your Card:";
            // 
            // txtScanmembership
            // 
            this.txtScanmembership.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScanmembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanmembership.Location = new System.Drawing.Point(240, 395);
            this.txtScanmembership.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanmembership.Name = "txtScanmembership";
            this.txtScanmembership.Size = new System.Drawing.Size(481, 26);
            this.txtScanmembership.TabIndex = 4;
            this.txtScanmembership.TextChanged += new System.EventHandler(this.txtScanmembership_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "MemberShip Number:";
            // 
            // pbxGranted
            // 
            this.pbxGranted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxGranted.Image = ((System.Drawing.Image)(resources.GetObject("pbxGranted.Image")));
            this.pbxGranted.Location = new System.Drawing.Point(292, 514);
            this.pbxGranted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxGranted.Name = "pbxGranted";
            this.pbxGranted.Size = new System.Drawing.Size(385, 380);
            this.pbxGranted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGranted.TabIndex = 6;
            this.pbxGranted.TabStop = false;
            // 
            // pbxDenied
            // 
            this.pbxDenied.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxDenied.Image = ((System.Drawing.Image)(resources.GetObject("pbxDenied.Image")));
            this.pbxDenied.Location = new System.Drawing.Point(291, 514);
            this.pbxDenied.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxDenied.Name = "pbxDenied";
            this.pbxDenied.Size = new System.Drawing.Size(385, 380);
            this.pbxDenied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDenied.TabIndex = 7;
            this.pbxDenied.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(896, 699);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(125, 44);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblMeetingAgenda
            // 
            this.lblMeetingAgenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMeetingAgenda.AutoSize = true;
            this.lblMeetingAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingAgenda.Location = new System.Drawing.Point(303, 310);
            this.lblMeetingAgenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeetingAgenda.Name = "lblMeetingAgenda";
            this.lblMeetingAgenda.Size = new System.Drawing.Size(195, 29);
            this.lblMeetingAgenda.TabIndex = 9;
            this.lblMeetingAgenda.Text = "Meeting Agenda:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::SAIMC_MemberManager.Properties.Resources.SAIMC_NEW2;
            this.pictureBox1.Location = new System.Drawing.Point(229, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmScanQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 754);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMeetingAgenda);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pbxDenied);
            this.Controls.Add(this.pbxGranted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanmembership);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScanQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Scan Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGranted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDenied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScanmembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CheckTick;
        private System.Windows.Forms.PictureBox pbxGranted;
        private System.Windows.Forms.PictureBox pbxDenied;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblMeetingAgenda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

