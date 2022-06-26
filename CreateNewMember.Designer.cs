
namespace SAIMC_MemberManager
{
    partial class frmcreatemember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcreatemember));
            this.btnSaveMem = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxselectcamera = new System.Windows.Forms.ComboBox();
            this.picboxQRCode = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCaptureProfilepic = new System.Windows.Forms.Button();
            this.btntakepic = new System.Windows.Forms.Button();
            this.btnretakepic = new System.Windows.Forms.Button();
            this.Timercheck = new System.Windows.Forms.Timer(this.components);
            this.btnSaveinAccess = new System.Windows.Forms.Button();
            this.txtmembershipno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdnumber = new System.Windows.Forms.TextBox();
            this.txtcontactnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxgender = new System.Windows.Forms.ComboBox();
            this.cbxpayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picboximagecapture = new System.Windows.Forms.PictureBox();
            this.picboxprofilepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboximagecapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxprofilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveMem
            // 
            this.btnSaveMem.Location = new System.Drawing.Point(273, 415);
            this.btnSaveMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveMem.Name = "btnSaveMem";
            this.btnSaveMem.Size = new System.Drawing.Size(337, 34);
            this.btnSaveMem.TabIndex = 4;
            this.btnSaveMem.Text = "Save New Member";
            this.btnSaveMem.UseVisualStyleBackColor = true;
            this.btnSaveMem.Click += new System.EventHandler(this.btnSaveMem_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(273, 457);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(337, 34);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(823, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Select Camera:";
            // 
            // cbxselectcamera
            // 
            this.cbxselectcamera.FormattingEnabled = true;
            this.cbxselectcamera.Location = new System.Drawing.Point(700, 91);
            this.cbxselectcamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxselectcamera.Name = "cbxselectcamera";
            this.cbxselectcamera.Size = new System.Drawing.Size(384, 24);
            this.cbxselectcamera.TabIndex = 20;
            // 
            // picboxQRCode
            // 
            this.picboxQRCode.Location = new System.Drawing.Point(1149, 132);
            this.picboxQRCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxQRCode.Name = "picboxQRCode";
            this.picboxQRCode.Size = new System.Drawing.Size(385, 367);
            this.picboxQRCode.TabIndex = 21;
            this.picboxQRCode.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1225, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "New Members QR Code";
            // 
            // btnCaptureProfilepic
            // 
            this.btnCaptureProfilepic.Location = new System.Drawing.Point(700, 506);
            this.btnCaptureProfilepic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaptureProfilepic.Name = "btnCaptureProfilepic";
            this.btnCaptureProfilepic.Size = new System.Drawing.Size(385, 34);
            this.btnCaptureProfilepic.TabIndex = 23;
            this.btnCaptureProfilepic.Text = "Capture Profile Picture";
            this.btnCaptureProfilepic.UseVisualStyleBackColor = true;
            this.btnCaptureProfilepic.Click += new System.EventHandler(this.btnCaptureProfilepic_Click);
            // 
            // btntakepic
            // 
            this.btntakepic.Location = new System.Drawing.Point(700, 548);
            this.btntakepic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntakepic.Name = "btntakepic";
            this.btntakepic.Size = new System.Drawing.Size(385, 34);
            this.btntakepic.TabIndex = 24;
            this.btntakepic.Text = "Take Picture";
            this.btntakepic.UseVisualStyleBackColor = true;
            this.btntakepic.Click += new System.EventHandler(this.btntakepic_Click);
            // 
            // btnretakepic
            // 
            this.btnretakepic.Location = new System.Drawing.Point(700, 590);
            this.btnretakepic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretakepic.Name = "btnretakepic";
            this.btnretakepic.Size = new System.Drawing.Size(385, 34);
            this.btnretakepic.TabIndex = 26;
            this.btnretakepic.Text = "Retake Picture";
            this.btnretakepic.UseVisualStyleBackColor = true;
            this.btnretakepic.Click += new System.EventHandler(this.btnretakepic_Click);
            // 
            // Timercheck
            // 
            this.Timercheck.Interval = 50;
            this.Timercheck.Tick += new System.EventHandler(this.Timercheck_Tick);
            // 
            // btnSaveinAccess
            // 
            this.btnSaveinAccess.Location = new System.Drawing.Point(273, 498);
            this.btnSaveinAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveinAccess.Name = "btnSaveinAccess";
            this.btnSaveinAccess.Size = new System.Drawing.Size(337, 34);
            this.btnSaveinAccess.TabIndex = 31;
            this.btnSaveinAccess.Text = "Save Access";
            this.btnSaveinAccess.UseVisualStyleBackColor = true;
            this.btnSaveinAccess.Click += new System.EventHandler(this.btnSaveinAccess_Click);
            // 
            // txtmembershipno
            // 
            this.txtmembershipno.Location = new System.Drawing.Point(273, 94);
            this.txtmembershipno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmembershipno.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtmembershipno.Name = "txtmembershipno";
            this.txtmembershipno.Size = new System.Drawing.Size(336, 22);
            this.txtmembershipno.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Membership Number:";
            // 
            // txtIdnumber
            // 
            this.txtIdnumber.Location = new System.Drawing.Point(273, 268);
            this.txtIdnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdnumber.Name = "txtIdnumber";
            this.txtIdnumber.Size = new System.Drawing.Size(336, 22);
            this.txtIdnumber.TabIndex = 52;
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Location = new System.Drawing.Point(273, 225);
            this.txtcontactnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.Size = new System.Drawing.Size(336, 22);
            this.txtcontactnumber.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cell Number:";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(273, 300);
            this.dob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(336, 22);
            this.dob.TabIndex = 47;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(273, 180);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(336, 22);
            this.txtSurname.TabIndex = 46;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 134);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 22);
            this.txtName.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Surname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(175, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Name:";
            // 
            // cbxgender
            // 
            this.cbxgender.FormattingEnabled = true;
            this.cbxgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxgender.Location = new System.Drawing.Point(273, 332);
            this.cbxgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxgender.Name = "cbxgender";
            this.cbxgender.Size = new System.Drawing.Size(336, 24);
            this.cbxgender.TabIndex = 55;
            // 
            // cbxpayment
            // 
            this.cbxpayment.FormattingEnabled = true;
            this.cbxpayment.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cbxpayment.Location = new System.Drawing.Point(273, 366);
            this.cbxpayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxpayment.Name = "cbxpayment";
            this.cbxpayment.Size = new System.Drawing.Size(336, 24);
            this.cbxpayment.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Payment:";
            // 
            // picboximagecapture
            // 
            this.picboximagecapture.Location = new System.Drawing.Point(700, 132);
            this.picboximagecapture.Margin = new System.Windows.Forms.Padding(4);
            this.picboximagecapture.Name = "picboximagecapture";
            this.picboximagecapture.Size = new System.Drawing.Size(385, 367);
            this.picboximagecapture.TabIndex = 17;
            this.picboximagecapture.TabStop = false;
            // 
            // picboxprofilepic
            // 
            this.picboxprofilepic.Location = new System.Drawing.Point(700, 132);
            this.picboxprofilepic.Margin = new System.Windows.Forms.Padding(4);
            this.picboxprofilepic.Name = "picboxprofilepic";
            this.picboxprofilepic.Size = new System.Drawing.Size(385, 367);
            this.picboxprofilepic.TabIndex = 25;
            this.picboxprofilepic.TabStop = false;
            this.picboxprofilepic.Visible = false;
            // 
            // frmcreatemember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 757);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxpayment);
            this.Controls.Add(this.cbxgender);
            this.Controls.Add(this.txtmembershipno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdnumber);
            this.Controls.Add(this.txtcontactnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveinAccess);
            this.Controls.Add(this.btnretakepic);
            this.Controls.Add(this.picboxprofilepic);
            this.Controls.Add(this.btntakepic);
            this.Controls.Add(this.btnCaptureProfilepic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picboxQRCode);
            this.Controls.Add(this.cbxselectcamera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.picboximagecapture);
            this.Controls.Add(this.btnSaveMem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmcreatemember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Member";
            this.Load += new System.EventHandler(this.frmcreatemember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboximagecapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxprofilepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveMem;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxselectcamera;
        private System.Windows.Forms.PictureBox picboxQRCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCaptureProfilepic;
        private System.Windows.Forms.Button btntakepic;
        private System.Windows.Forms.Button btnretakepic;
        private System.Windows.Forms.Timer Timercheck;
        private System.Windows.Forms.Button btnSaveinAccess;
        private System.Windows.Forms.TextBox txtmembershipno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdnumber;
        private System.Windows.Forms.TextBox txtcontactnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxgender;
        private System.Windows.Forms.ComboBox cbxpayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picboximagecapture;
        private System.Windows.Forms.PictureBox picboxprofilepic;
    }
}