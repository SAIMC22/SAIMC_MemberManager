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
                MeetingList.Sort((x, y) => x.Agenda.CompareTo(y.Agenda));
                foreach (var meeting in MeetingList)
                {
                    cbxMeetings.Items.Add(meeting.Agenda);
                }
            }
            catch
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Please Select an Agenda");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("An Error Occured trying to Open Create Meeting Form,Please Contact Admin");
            }
        }
    }
}
