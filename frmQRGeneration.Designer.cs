namespace SAIMC_MemberManager
{
    partial class frmQRGeneration
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
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picboxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadExcel.Location = new System.Drawing.Point(238, 304);
            this.btnUploadExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(408, 41);
            this.btnUploadExcel.TabIndex = 51;
            this.btnUploadExcel.Text = "Upload File";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 39);
            this.label8.TabIndex = 82;
            this.label8.Text = "Generate QR Codes";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 41);
            this.button1.TabIndex = 83;
            this.button1.Text = "Generate QR Codes From Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picboxQRCode
            // 
            this.picboxQRCode.Enabled = false;
            this.picboxQRCode.Location = new System.Drawing.Point(386, 431);
            this.picboxQRCode.Name = "picboxQRCode";
            this.picboxQRCode.Size = new System.Drawing.Size(96, 69);
            this.picboxQRCode.TabIndex = 84;
            this.picboxQRCode.TabStop = false;
            this.picboxQRCode.Visible = false;
            // 
            // frmQRGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 525);
            this.Controls.Add(this.picboxQRCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUploadExcel);
            this.Name = "frmQRGeneration";
            this.Text = "Generate QR Codes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQRGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picboxQRCode;
    }
}