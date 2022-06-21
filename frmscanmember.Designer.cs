
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxGranted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDenied)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Scan Your Card:";
            // 
            // txtScanmembership
            // 
            this.txtScanmembership.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScanmembership.Location = new System.Drawing.Point(243, 174);
            this.txtScanmembership.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScanmembership.Name = "txtScanmembership";
            this.txtScanmembership.Size = new System.Drawing.Size(429, 22);
            this.txtScanmembership.TabIndex = 4;
            this.txtScanmembership.TextChanged += new System.EventHandler(this.txtScanmembership_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "MemberShip Number";
            // 
            // pbxGranted
            // 
            this.pbxGranted.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxGranted.Image = ((System.Drawing.Image)(resources.GetObject("pbxGranted.Image")));
            this.pbxGranted.Location = new System.Drawing.Point(271, 320);
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
            this.pbxDenied.Location = new System.Drawing.Point(271, 320);
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
            this.btnAdmin.Location = new System.Drawing.Point(896, 656);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(125, 44);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmScanQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 712);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pbxDenied);
            this.Controls.Add(this.pbxGranted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanmembership);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmScanQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGranted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDenied)).EndInit();
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
    }
}

