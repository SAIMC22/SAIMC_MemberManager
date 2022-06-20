
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
            this.label2 = new System.Windows.Forms.Label();
            this.btncreatenewMember = new System.Windows.Forms.Button();
            this.txtScanmembership = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckTick = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnviewmeetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Scan Your Card:";
            // 
            // btncreatenewMember
            // 
            this.btncreatenewMember.Location = new System.Drawing.Point(841, 59);
            this.btncreatenewMember.Name = "btncreatenewMember";
            this.btncreatenewMember.Size = new System.Drawing.Size(247, 31);
            this.btncreatenewMember.TabIndex = 3;
            this.btncreatenewMember.Text = "Create A New Member";
            this.btncreatenewMember.UseVisualStyleBackColor = true;
            this.btncreatenewMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScanmembership
            // 
            this.txtScanmembership.Location = new System.Drawing.Point(376, 111);
            this.txtScanmembership.Name = "txtScanmembership";
            this.txtScanmembership.Size = new System.Drawing.Size(323, 20);
            this.txtScanmembership.TabIndex = 4;
            this.txtScanmembership.TextChanged += new System.EventHandler(this.txtScanmembership_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MemberShip Number";
            // 
            // CheckTick
            // 
            this.CheckTick.Interval = 5000;
            this.CheckTick.Tick += new System.EventHandler(this.CheckTick_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnviewmeetings
            // 
            this.btnviewmeetings.Location = new System.Drawing.Point(841, 136);
            this.btnviewmeetings.Name = "btnviewmeetings";
            this.btnviewmeetings.Size = new System.Drawing.Size(247, 31);
            this.btnviewmeetings.TabIndex = 7;
            this.btnviewmeetings.Text = "View Meetings";
            this.btnviewmeetings.UseVisualStyleBackColor = true;
            this.btnviewmeetings.Click += new System.EventHandler(this.btnviewmeetings_Click);
            // 
            // frmScanQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 659);
            this.Controls.Add(this.btnviewmeetings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanmembership);
            this.Controls.Add(this.btncreatenewMember);
            this.Controls.Add(this.label2);
            this.Name = "frmScanQR";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncreatenewMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profileImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn memberQRCodeDataGridViewImageColumn;
        private System.Windows.Forms.TextBox txtScanmembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CheckTick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnviewmeetings;
    }
}

