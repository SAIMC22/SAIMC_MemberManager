﻿namespace SAIMC_MemberManager
{
    partial class frmViewMeeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMeeting));
            this.dgvMeeting = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMeetings = new System.Windows.Forms.ComboBox();
            this.btnSearchbyDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMeetingAgenda = new System.Windows.Forms.Label();
            this.lblMeetingAttendanceCount = new System.Windows.Forms.Label();
            this.lblCPDPointsOfMeeting = new System.Windows.Forms.Label();
            this.lblMeetingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeeting
            // 
            this.dgvMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeeting.Location = new System.Drawing.Point(29, 162);
            this.dgvMeeting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMeeting.Name = "dgvMeeting";
            this.dgvMeeting.RowHeadersWidth = 51;
            this.dgvMeeting.RowTemplate.Height = 24;
            this.dgvMeeting.Size = new System.Drawing.Size(1432, 704);
            this.dgvMeeting.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(929, 69);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(225, 34);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search by Agenda";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Meetings";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1160, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by Agenda:";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpSearchDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearchDate.Location = new System.Drawing.Point(221, 110);
            this.dtpSearchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(700, 30);
            this.dtpSearchDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search by Date:";
            // 
            // cbxMeetings
            // 
            this.cbxMeetings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMeetings.FormattingEnabled = true;
            this.cbxMeetings.Location = new System.Drawing.Point(221, 71);
            this.cbxMeetings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMeetings.Name = "cbxMeetings";
            this.cbxMeetings.Size = new System.Drawing.Size(700, 33);
            this.cbxMeetings.TabIndex = 9;
            // 
            // btnSearchbyDate
            // 
            this.btnSearchbyDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchbyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbyDate.Location = new System.Drawing.Point(928, 110);
            this.btnSearchbyDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchbyDate.Name = "btnSearchbyDate";
            this.btnSearchbyDate.Size = new System.Drawing.Size(227, 34);
            this.btnSearchbyDate.TabIndex = 10;
            this.btnSearchbyDate.Text = "Search by Date";
            this.btnSearchbyDate.UseVisualStyleBackColor = true;
            this.btnSearchbyDate.Click += new System.EventHandler(this.btnSearchbyDate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 880);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Meeting Agenda:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(873, 880);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Meeting:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 921);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Meeting Attendance:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 921);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPD Points of Meeting:";
            // 
            // lblMeetingAgenda
            // 
            this.lblMeetingAgenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMeetingAgenda.AutoSize = true;
            this.lblMeetingAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingAgenda.Location = new System.Drawing.Point(341, 880);
            this.lblMeetingAgenda.Name = "lblMeetingAgenda";
            this.lblMeetingAgenda.Size = new System.Drawing.Size(0, 29);
            this.lblMeetingAgenda.TabIndex = 17;
            // 
            // lblMeetingAttendanceCount
            // 
            this.lblMeetingAttendanceCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMeetingAttendanceCount.AutoSize = true;
            this.lblMeetingAttendanceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingAttendanceCount.Location = new System.Drawing.Point(341, 921);
            this.lblMeetingAttendanceCount.Name = "lblMeetingAttendanceCount";
            this.lblMeetingAttendanceCount.Size = new System.Drawing.Size(0, 29);
            this.lblMeetingAttendanceCount.TabIndex = 18;
            // 
            // lblCPDPointsOfMeeting
            // 
            this.lblCPDPointsOfMeeting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCPDPointsOfMeeting.AutoSize = true;
            this.lblCPDPointsOfMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPDPointsOfMeeting.Location = new System.Drawing.Point(1153, 921);
            this.lblCPDPointsOfMeeting.Name = "lblCPDPointsOfMeeting";
            this.lblCPDPointsOfMeeting.Size = new System.Drawing.Size(0, 29);
            this.lblCPDPointsOfMeeting.TabIndex = 19;
            // 
            // lblMeetingDate
            // 
            this.lblMeetingDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMeetingDate.AutoSize = true;
            this.lblMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingDate.Location = new System.Drawing.Point(1155, 880);
            this.lblMeetingDate.Name = "lblMeetingDate";
            this.lblMeetingDate.Size = new System.Drawing.Size(0, 29);
            this.lblMeetingDate.TabIndex = 20;
            // 
            // frmViewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 988);
            this.Controls.Add(this.lblMeetingDate);
            this.Controls.Add(this.lblCPDPointsOfMeeting);
            this.Controls.Add(this.lblMeetingAttendanceCount);
            this.Controls.Add(this.lblMeetingAgenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchbyDate);
            this.Controls.Add(this.cbxMeetings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgvMeeting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1499, 1027);
            this.Name = "frmViewMeeting";
            this.Text = "View Meetings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewMeeting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeeting;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMeetings;
        private System.Windows.Forms.Button btnSearchbyDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMeetingAgenda;
        private System.Windows.Forms.Label lblMeetingAttendanceCount;
        private System.Windows.Forms.Label lblCPDPointsOfMeeting;
        private System.Windows.Forms.Label lblMeetingDate;
    }
}