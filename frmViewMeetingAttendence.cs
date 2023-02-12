using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmViewMeetingAttendence : Form
    {
        private List<Member> members = new List<Member>();
        private List<MemberMeeting> Membermeetings = new List<MemberMeeting>();
        private List<MemberMeeting> foundMemberMeetings = new List<MemberMeeting>();
        private List<Meeting> MeetingList = new List<Meeting>();
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        public frmViewMeetingAttendence()
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
                                if (member.MemberId == membermeeting.MemberId)
                                {
                                    foundMembersInMeeting.Add(member);
                                }
                            }
                        }
                        if (foundMembersInMeeting.Count() == 0)
                        {
                            MessageBox.Show("No Members Attended this meeting.");
                            dgvMeeting.DataSource = null;
                        }
                        else
                        {
                            lblMeetingAttendanceCount.Text = foundMembersInMeeting.Count.ToString();
                            //Remove Duplicates before Populating Table
                            // Group records by email
                            var groups = foundMembersInMeeting.GroupBy(c => c.SAIMC_Nr);

                            // Loop through each group
                            foreach (var group in groups)
                            {
                                // Check if the group has more than one item
                                if (group.Count() > 1)
                                {
                                    // Remove duplicates except for the first item
                                    for (int i = 1; i < group.Count(); i++)
                                    {
                                        foundMembersInMeeting.Remove(group.ElementAt(i));
                                    }
                                }

                                dgvMeeting.DataSource = foundMembersInMeeting.Select(x => new { Name = x.Nickname, Surname = x.Surname, SAIMC_Nr = x.SAIMC_Nr, Contact_Number = x.MobilePhone, Paid = x.Haspaid }).ToList();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                            if (member.MemberId == membermeeting.MemberId)
                            {
                                foundMembersInMeeting.Add(member);
                            }
                        }
                    }
                    lblMeetingAttendanceCount.Text = foundMembersInMeeting.Count.ToString();
                    dgvMeeting.DataSource = foundMembersInMeeting.Select(x => new { Name = x.Nickname, Surname = x.Surname, SAIMC_Nr = x.SAIMC_Nr, Contact_Number = x.MobilePhone, Paid = x.Haspaid }).ToList();
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
    }
}
