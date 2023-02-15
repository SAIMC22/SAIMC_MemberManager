namespace SAIMC_MemberManager
{
    partial class frmViewAllMeetings
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
            this.dgvMeetings = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateMeeeting = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnDeleteMeeting = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtSearchMeeting = new System.Windows.Forms.TextBox();
            this.lblmembername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeetings
            // 
            this.dgvMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeetings.Location = new System.Drawing.Point(12, 128);
            this.dgvMeetings.Name = "dgvMeetings";
            this.dgvMeetings.RowHeadersWidth = 51;
            this.dgvMeetings.RowTemplate.Height = 24;
            this.dgvMeetings.Size = new System.Drawing.Size(1358, 622);
            this.dgvMeetings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "View All Meetings";
            // 
            // btnCreateMeeeting
            // 
            this.btnCreateMeeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMeeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMeeeting.Location = new System.Drawing.Point(927, 33);
            this.btnCreateMeeeting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateMeeeting.Name = "btnCreateMeeeting";
            this.btnCreateMeeeting.Size = new System.Drawing.Size(225, 34);
            this.btnCreateMeeeting.TabIndex = 5;
            this.btnCreateMeeeting.Text = "Create New Meeting";
            this.btnCreateMeeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeeting.Click += new System.EventHandler(this.btnCreateMeeeting_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(927, 71);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(225, 34);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit Meeting";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnDeleteMeeting
            // 
            this.btnDeleteMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMeeting.Location = new System.Drawing.Point(1158, 33);
            this.btnDeleteMeeting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMeeting.Name = "btnDeleteMeeting";
            this.btnDeleteMeeting.Size = new System.Drawing.Size(191, 34);
            this.btnDeleteMeeting.TabIndex = 7;
            this.btnDeleteMeeting.Text = "Delete Meeting";
            this.btnDeleteMeeting.UseVisualStyleBackColor = true;
            this.btnDeleteMeeting.Click += new System.EventHandler(this.btnDeleteMeeting_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1158, 71);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(191, 34);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtSearchMeeting
            // 
            this.txtSearchMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMeeting.Location = new System.Drawing.Point(188, 73);
            this.txtSearchMeeting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMeeting.Name = "txtSearchMeeting";
            this.txtSearchMeeting.Size = new System.Drawing.Size(305, 30);
            this.txtSearchMeeting.TabIndex = 10;
            this.txtSearchMeeting.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // lblmembername
            // 
            this.lblmembername.AutoSize = true;
            this.lblmembername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembername.Location = new System.Drawing.Point(12, 76);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(162, 25);
            this.lblmembername.TabIndex = 11;
            this.lblmembername.Text = "Meeting Agenda:";
            // 
            // frmViewAllMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 762);
            this.Controls.Add(this.lblmembername);
            this.Controls.Add(this.txtSearchMeeting);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDeleteMeeting);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnCreateMeeeting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMeetings);
            this.Name = "frmViewAllMeetings";
            this.Text = "View All Meetings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewAllMeetings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeetings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateMeeeting;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnDeleteMeeting;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtSearchMeeting;
        private System.Windows.Forms.Label lblmembername;
    }
}