using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmViewAllMeetings : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int meetingId = 0;

        public frmViewAllMeetings()
        {
            InitializeComponent();
        }

        private void ViewAllMeetings_Load(object sender, EventArgs e)
        {
            try
            {
                List<Meeting> Meetings = new List<Meeting>();
                Meetings = db.Meetings.ToList();
                dgvMeetings.DataSource = Meetings.Select(x => new { MeetingId = x.Meetingid, Agenda = x.Agenda, Date = x.date, CPD_Points = x.CPDpoints }).ToList();
                dgvMeetings.AllowUserToAddRows = false;
                dgvMeetings.AllowUserToDeleteRows = true;
                dgvMeetings.AllowUserToResizeRows = false;
                dgvMeetings.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMeetings.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMeetings.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Load All meeetings.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdmin viewMeeting = new frmAdmin();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Load Admin Form");
            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Meeting> meetings = new List<Meeting>();
                meetings = db.Meetings.ToList();
                if (meetings.Count != 0)
                {
                    List<Meeting> meetingsList = meetings.FindAll(x => x.Agenda.Contains(txtSearchMeeting.Text)).ToList();
                    dgvMeetings.DataSource = meetingsList.Select(x => new { MeetingId = x.Meetingid, Agenda = x.Agenda, Date = x.date, CPD_Points = x.CPDpoints }).ToList();
                    dgvMeetings.AllowUserToAddRows = false;
                    dgvMeetings.AllowUserToDeleteRows = true;
                    dgvMeetings.AllowUserToResizeRows = false;
                    dgvMeetings.RowHeadersWidthSizeMode =
                        DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgvMeetings.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dgvMeetings.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMeetings.Update();
                }
            }
            catch
            {
                MessageBox.Show("Error occured trying to search All meetings");
            }
        }

        private void btnCreateMeeeting_Click(object sender, EventArgs e)
        {
            try
            {
                //Create New Meeting
                frmCreateMeeting createMeeting = new frmCreateMeeting();
                this.Hide();
                createMeeting.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Create Meeting Form");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMeetings.Rows.Count == 0)
                {
                    MessageBox.Show("No Meetings to be edited");
                }
                else
                {
                    int rowindex = dgvMeetings.CurrentCell.RowIndex;
                    meetingId = Convert.ToInt32(dgvMeetings.Rows[rowindex].Cells[0].Value);
                    frmEditMeeting editMeeting = new frmEditMeeting();
                    this.Hide();
                    editMeeting.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Error Occured trying to load Edit Member form");
            }
        }

        private void btnDeleteMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMeetings.Rows.Count == 0)
                {
                    MessageBox.Show("No Meetings to be Deleted.");
                }
                else
                {
                    string message = "Are you sure you want to delete? All Attendance for this meeting will be lost!";
                    string title = "Please Confirm Deletion";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                    }
                    else
                    {
                        int rowindex = dgvMeetings.CurrentCell.RowIndex;
                        meetingId = Convert.ToInt32(dgvMeetings.Rows[rowindex].Cells[0].Value);
                        List<Meeting> meetings = new List<Meeting>();
                        meetings = db.Meetings.ToList();
                        Meeting meeting = meetings.Find(x => Convert.ToInt32(x.Meetingid) == Convert.ToInt32(meetingId));
                        db.Meetings.Remove(meeting);
                        db.SaveChanges();
                        //Display Same updated Meeting List
                        List<Meeting> Meetings = new List<Meeting>();
                        Meetings = db.Meetings.ToList();
                        dgvMeetings.DataSource = Meetings.Select(x => new { MeetingId = x.Meetingid, Agenda = x.Agenda, Date = x.date, CPD_Points = x.CPDpoints }).ToList();
                        dgvMeetings.AllowUserToAddRows = false;
                        dgvMeetings.AllowUserToDeleteRows = true;
                        dgvMeetings.AllowUserToResizeRows = false;
                        dgvMeetings.RowHeadersWidthSizeMode =
                            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        dgvMeetings.ColumnHeadersHeightSizeMode =
                            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dgvMeetings.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Deletion Failed,Please Try Again");
            }
        }
    }
}
