using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmSelectMeetingToScanMembers : Form
    {
        private List<Meeting> MeetingList = new List<Meeting>();
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int meetingId = 0;

        public frmSelectMeetingToScanMembers()
        {
            InitializeComponent();
        }

        private void cbxMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmSelectMeetingToScanMembers_Load(object sender, EventArgs e)
        {
            try
            {
                MeetingList = db.Meetings.ToList();
                if(MeetingList.Count == 0)
                {
                    string message = "Would you like to create your first Meeting?";
                    string title = "No Meetings in the System!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        //Open New form To QAdmin Form)
                        frmAdmin frmAdmin = new frmAdmin();
                        this.Hide();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Open New form To QAdmin Form)
                        frmCreateMeeting frmCreateMeeting = new frmCreateMeeting();
                        this.Hide();
                        frmCreateMeeting.ShowDialog();
                        this.Close();
                        
                    }
                    }
                MeetingList.Sort((x, y) => x.Agenda.CompareTo(y.Agenda));
                foreach (var meeting in MeetingList)
                {
                    cbxMeetings.Items.Add(meeting.Agenda);
                }
                int latestMeetng = MeetingList.Max(x => (x.Meetingid));
                cbxMeetings.Text = MeetingList.Find(x => x.Meetingid == latestMeetng).Agenda;
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Load Select Meeting to scan Members.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Send Meeting Id through to scanning Process
                //Search by Agenda
                if (cbxMeetings.Text == "")
                {
                    MessageBox.Show("Please Select a Meeting.");
                    return;
                }
                List<Member> foundMembersInMeeting = new List<Member>();
                MeetingList = db.Meetings.ToList();
                var foundMeeting = MeetingList.Find(x => x.Agenda == cbxMeetings.Text);

                meetingId = foundMeeting.Meetingid;
                frmScanQR frmScanMembers = new frmScanQR();
                this.Hide();
                frmScanMembers.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Select Meeting.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
