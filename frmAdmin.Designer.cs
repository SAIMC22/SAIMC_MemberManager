namespace SAIMC_MemberManager
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
            this.btnviewmeetings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncreatenewMember = new System.Windows.Forms.Button();
            this.lbadmin = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnviewmeetings
            // 
            this.btnviewmeetings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnviewmeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmeetings.Location = new System.Drawing.Point(306, 378);
            this.btnviewmeetings.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewmeetings.Name = "btnviewmeetings";
            this.btnviewmeetings.Size = new System.Drawing.Size(329, 38);
            this.btnviewmeetings.TabIndex = 10;
            this.btnviewmeetings.Text = "View Meetings";
            this.btnviewmeetings.UseVisualStyleBackColor = true;
            this.btnviewmeetings.Click += new System.EventHandler(this.btnviewmeetings_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncreatenewMember
            // 
            this.btncreatenewMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncreatenewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatenewMember.Location = new System.Drawing.Point(306, 284);
            this.btncreatenewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btncreatenewMember.Name = "btncreatenewMember";
            this.btncreatenewMember.Size = new System.Drawing.Size(329, 38);
            this.btncreatenewMember.TabIndex = 8;
            this.btncreatenewMember.Text = "Create A New Member";
            this.btncreatenewMember.UseVisualStyleBackColor = true;
            this.btncreatenewMember.Click += new System.EventHandler(this.btncreatenewMember_Click);
            // 
            // lbadmin
            // 
            this.lbadmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbadmin.AutoSize = true;
            this.lbadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadmin.Location = new System.Drawing.Point(244, 210);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(454, 51);
            this.lbadmin.TabIndex = 11;
            this.lbadmin.Text = "Select Admin Function";
            this.lbadmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(306, 424);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(329, 38);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Scan Members";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 555);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lbadmin);
            this.Controls.Add(this.btnviewmeetings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncreatenewMember);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnviewmeetings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncreatenewMember;
        private System.Windows.Forms.Label lbadmin;
        private System.Windows.Forms.Button btncancel;
    }
}