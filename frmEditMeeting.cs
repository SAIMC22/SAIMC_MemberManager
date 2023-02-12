using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmEditMeeting : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int meetingId = 0;

        public frmEditMeeting()
        {
            InitializeComponent();
        }

        private void frmEditMeeting_Load(object sender, EventArgs e)
        {
            try
            {
                meetingId = frmViewAllMeetings.meetingId;
                List<Meeting> meetings = new List<Meeting>();
                meetings = db.Meetings.ToList();
                //members.FirstOrDefault(x => x.id == MemberId);
                foreach (Meeting meet in meetings)
                {
                    if (meet != null)
                    {
                        if (Convert.ToInt32(meet.Meetingid) == meetingId)
                        {
                            txtagenda.Text = meet.Agenda.TrimEnd();
                            nudCPDPoints.Value = Convert.ToInt16(meet.CPDpoints);
                            dtpDate.Value = meet.date;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Edit Member,Please try Again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meeting mymeeting = new Meeting();
            List<Meeting> AllMeetingsList = new List<Meeting>();
            AllMeetingsList = db.Meetings.ToList();
            try
            {
                mymeeting = AllMeetingsList.Find(x => Convert.ToInt32(x.Meetingid) == meetingId);
                //Add Member Details to system and Create a QR Code for that Member
                if (txtagenda.Text != "" && nudCPDPoints.Value != 0 && dtpDate.Value != null)
                {
                    //Save edited Member to Database
                    mymeeting.Agenda = txtagenda.Text;
                    mymeeting.CPDpoints = Convert.ToInt32(nudCPDPoints.Value);
                    mymeeting.date = dtpDate.Value;

                    string message = "Please confirm edit of: " + txtagenda.Text;
                    string title = "Please Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                    }
                    else
                    {
                        db.SaveChanges();
                        MessageBox.Show("Meeting Sucessfully Edited");
                        frmViewAllMeetings frmViewAllMeetings = new frmViewAllMeetings();
                        this.Hide();
                        frmViewAllMeetings.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill in All required Fields");
                }
            }
            catch
            {
                MessageBox.Show("Edit Failed,Please try Again");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            frmViewAllMeetings frmViewAllMeetings = new frmViewAllMeetings();
            this.Hide();
            frmViewAllMeetings.ShowDialog();
            this.Close();
        }
    }
}
