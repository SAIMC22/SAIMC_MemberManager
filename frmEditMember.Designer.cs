namespace SAIMC_MemberManager
{
    partial class frmEditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMember));
            this.label8 = new System.Windows.Forms.Label();
            this.nudCellNumber = new System.Windows.Forms.NumericUpDown();
            this.nudIdNumber = new System.Windows.Forms.NumericUpDown();
            this.nudMembershipNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxpayment = new System.Windows.Forms.ComboBox();
            this.cbxgender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSaveMem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCellNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMembershipNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, -64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 39);
            this.label8.TabIndex = 100;
            this.label8.Text = "Create New Member";
            // 
            // nudCellNumber
            // 
            this.nudCellNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudCellNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCellNumber.Location = new System.Drawing.Point(410, 312);
            this.nudCellNumber.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudCellNumber.Name = "nudCellNumber";
            this.nudCellNumber.Size = new System.Drawing.Size(336, 26);
            this.nudCellNumber.TabIndex = 99;
            // 
            // nudIdNumber
            // 
            this.nudIdNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdNumber.Location = new System.Drawing.Point(410, 362);
            this.nudIdNumber.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudIdNumber.Name = "nudIdNumber";
            this.nudIdNumber.Size = new System.Drawing.Size(336, 26);
            this.nudIdNumber.TabIndex = 98;
            // 
            // nudMembershipNumber
            // 
            this.nudMembershipNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudMembershipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMembershipNumber.Location = new System.Drawing.Point(410, 158);
            this.nudMembershipNumber.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.nudMembershipNumber.Name = "nudMembershipNumber";
            this.nudMembershipNumber.Size = new System.Drawing.Size(336, 26);
            this.nudMembershipNumber.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Payment:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Gender:";
            // 
            // cbxpayment
            // 
            this.cbxpayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxpayment.FormattingEnabled = true;
            this.cbxpayment.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cbxpayment.Location = new System.Drawing.Point(410, 503);
            this.cbxpayment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxpayment.Name = "cbxpayment";
            this.cbxpayment.Size = new System.Drawing.Size(336, 28);
            this.cbxpayment.TabIndex = 94;
            // 
            // cbxgender
            // 
            this.cbxgender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgender.FormattingEnabled = true;
            this.cbxgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxgender.Location = new System.Drawing.Point(410, 450);
            this.cbxgender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxgender.Name = "cbxgender";
            this.cbxgender.Size = new System.Drawing.Size(336, 28);
            this.cbxgender.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Membership Number:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "ID Number:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Cell Number:";
            // 
            // dob
            // 
            this.dob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(410, 406);
            this.dob.Margin = new System.Windows.Forms.Padding(4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(336, 26);
            this.dob.TabIndex = 88;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(410, 260);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(336, 26);
            this.txtSurname.TabIndex = 87;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(410, 206);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 26);
            this.txtName.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 85;
            this.label7.Text = "Surname:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 84;
            this.label11.Text = "Name:";
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(411, 595);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(337, 34);
            this.btncancel.TabIndex = 83;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSaveMem
            // 
            this.btnSaveMem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMem.Location = new System.Drawing.Point(411, 553);
            this.btnSaveMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMem.Name = "btnSaveMem";
            this.btnSaveMem.Size = new System.Drawing.Size(337, 34);
            this.btnSaveMem.TabIndex = 82;
            this.btnSaveMem.Text = "Edit Member";
            this.btnSaveMem.UseVisualStyleBackColor = true;
            this.btnSaveMem.Click += new System.EventHandler(this.btnSaveMem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 39);
            this.label9.TabIndex = 101;
            this.label9.Text = "Edit Member";
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 660);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCellNumber);
            this.Controls.Add(this.nudIdNumber);
            this.Controls.Add(this.nudMembershipNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxpayment);
            this.Controls.Add(this.cbxgender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnSaveMem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditMember";
            this.Text = "Edit Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCellNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMembershipNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCellNumber;
        private System.Windows.Forms.NumericUpDown nudIdNumber;
        private System.Windows.Forms.NumericUpDown nudMembershipNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxpayment;
        private System.Windows.Forms.ComboBox cbxgender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSaveMem;
        private System.Windows.Forms.Label label9;
    }
}