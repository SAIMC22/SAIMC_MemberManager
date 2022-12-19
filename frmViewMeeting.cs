using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmViewMeeting : Form
    {
        private List<Member> members = new List<Member>();
        private List<MemberMeeting> Membermeetings = new List<MemberMeeting>();
        private List<MemberMeeting> foundMemberMeetings = new List<MemberMeeting>();
        private List<Meeting> MeetingList = new List<Meeting>();
        private SAIMCEntities db = new SAIMCEntities();

        public frmViewMeeting()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Search by Agenda
                if (cbxMeetings.Text == "")
                {
                    MessageBox.Show("Please Select an Agenda");
                }
                else
                {
                    List<Member> foundMembersInMeeting = new List<Member>();
                    MeetingList = db.Meetings.ToList();
                    var foundMeeting = MeetingList.Find(x => x.Agenda == cbxMeetings.Text);
                    if (foundMeeting == null)
                    {
                        MessageBox.Show("No Meeting Found");
                    }
                    else
                    {
                        lblMeetingAgenda.Text = foundMeeting.Agenda;
                        lblCPDPointsOfMeeting.Text = foundMeeting.CPDpoints.ToString();
                        lblMeetingDate.Text = foundMeeting.date.ToString();

                        Membermeetings = db.MemberMeetings.ToList();
                        foundMemberMeetings = Membermeetings.FindAll(x => x.Meetingid == foundMeeting.Meetingid);
                        members = db.Members.ToList();

                        //Loop through MemberMeeting List to Find all Members ID's and Add Member Details to List
                        foreach (var membermeeting in foundMemberMeetings)
                        {
                            foreach (var member in members)
                            {
                                if (member.id == membermeeting.id)
                                {
                                    foundMembersInMeeting.Add(member);
                                }
                            }
                        }
                        lblMeetingAttendanceCount.Text = foundMembersInMeeting.Count.ToString();
                        dgvMeeting.DataSource = foundMembersInMeeting.Select(x => new { Name = x.Name, Surname = x.Surname, Membership_Number = x.MemberShipNo, ID_Number = x.IdNumber, Contact_Number = x.ContactNumber, Gender = x.Gender, Date_Of_Birth = x.DOB, Paid = x.Haspaid }).ToList();
                        dgvMeeting.AllowUserToAddRows = false;
                        dgvMeeting.AllowUserToDeleteRows = true;
                        dgvMeeting.AllowUserToResizeRows = false;
                        dgvMeeting.RowHeadersWidthSizeMode =
                            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        dgvMeeting.ColumnHeadersHeightSizeMode =
                            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dgvMeeting.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                        dgvMeeting.Update();
                    }
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
                frmAdmin frmAdmin = new frmAdmin();
                this.Hide();
                frmAdmin.ShowDialog();
                this.Close();
            }
            catch
            {
            }
        }

        private void frmViewMeeting_Load(object sender, EventArgs e)
        {
            try
            {
                dtpSearchDate.MaxDate = DateTime.Today;
                MeetingList = db.Meetings.ToList();
                MeetingList.Sort((y, x) => x.Agenda.CompareTo(y.Agenda));
                foreach (var meeting in MeetingList)
                {
                    cbxMeetings.Items.Add(meeting.Agenda);
                }
            }
            catch
            {
            }
        }

        private void btnSearchbyDate_Click(object sender, EventArgs e)
        {
            try
            {
                //Search by Date
                List<Member> foundMembersInMeeting = new List<Member>();
                MeetingList = db.Meetings.ToList();
                var foundMeeting = MeetingList.Find(x => x.date.Date == dtpSearchDate.Value.Date);
                if (foundMeeting == null)
                {
                    MessageBox.Show("No Meeting Found");
                }
                else
                {
                    lblMeetingAgenda.Text = foundMeeting.Agenda;
                    lblCPDPointsOfMeeting.Text = foundMeeting.CPDpoints.ToString();
                    lblMeetingDate.Text = foundMeeting.date.ToString();

                    Membermeetings = db.MemberMeetings.ToList();
                    foundMemberMeetings = Membermeetings.FindAll(x => x.Meetingid == foundMeeting.Meetingid);
                    members = db.Members.ToList();

                    //Loop through MemberMeeting List to Find all Members ID's and Add Member Details to List
                    foreach (var membermeeting in foundMemberMeetings)
                    {
                        foreach (var member in members)
                        {
                            if (member.id == membermeeting.id)
                            {
                                foundMembersInMeeting.Add(member);
                            }
                        }
                    }
                    lblMeetingAttendanceCount.Text = foundMembersInMeeting.Count.ToString();
                    dgvMeeting.DataSource = foundMembersInMeeting.Select(x => new { Name = x.Name, Surname = x.Surname, Membership_Number = x.MemberShipNo, ID_Number = x.IdNumber, Contact_Number = x.ContactNumber, Gender = x.Gender, Date_Of_Birth = x.DOB, Paid = x.Haspaid }).ToList();
                    dgvMeeting.AllowUserToAddRows = false;
                    dgvMeeting.AllowUserToDeleteRows = true;
                    dgvMeeting.AllowUserToResizeRows = false;
                    dgvMeeting.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    dgvMeeting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dgvMeeting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMeeting.Update();
                }
            }
            catch
            {
            }
        }

        private void btnsearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                frmSearchMemberForViewMeetings frmSearchAdmin = new frmSearchMemberForViewMeetings();
                this.Hide();
                frmSearchAdmin.ShowDialog();
                this.Close();
            }
            catch
            {
            }
        }
    }
}
