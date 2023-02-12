using Microsoft.Office.Interop.Excel;
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
        private List<Member> foundMembersInMeeting = new List<Member>();

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
                    //List<Member> foundMembersInMeeting = new List<Member>();
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
                            // Group records by SAIMC_NR
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
                                //Display Export Button
                                btnExportToExcel.Enabled = true;
                                btnExportToExcel.Visible = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Occured trying to few Member's meeting attendance");
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
                MessageBox.Show("An Error occured trying to Load Admin Form");
            }
        }

        private void frmViewMeeting_Load(object sender, EventArgs e)
        {
            try
            {
                btnExportToExcel.Enabled = false;
                btnExportToExcel.Visible = false;
                dtpSearchDate.MaxDate = DateTime.Today;
                MeetingList = db.Meetings.ToList();
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
                MessageBox.Show("An Error occured trying to View Meetings");
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
                    //Display Export Button
                    btnExportToExcel.Enabled = true;
                    btnExportToExcel.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("An Error occured trying to Search Meeting that Member has Attended");
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //List<Member> foundMembersInMeeting = new List<Member>();
                MeetingList = db.Meetings.ToList();
                var foundMeeting = MeetingList.Find(x => x.Agenda == cbxMeetings.Text);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "Agenda" + " " + foundMeeting.Agenda + " " + "Date " + foundMeeting.date.ToString("yyyy-MM-dd");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    var workbook = excelApp.Workbooks.Add(Type.Missing);
                    var worksheet = (Worksheet)workbook.Sheets[1];
                    worksheet.Name = "AttendanceList";

                    int row = 1;
                    foreach (var item in foundMembersInMeeting)
                    {
                        // Add column headings
                        worksheet.Cells[1, 1] = "SAIMC_Nr";
                        worksheet.Cells[1, 2] = "Title";
                        worksheet.Cells[1, 3] = "Nickname";
                        worksheet.Cells[1, 4] = "Surname";
                        worksheet.Cells[1, 5] = "MobilePhone";
                        worksheet.Cells[1, 6] = "Haspaid";

                        // Style column headings
                        var columnHeadingsRange = worksheet.Range["A1", "F1"];
                        columnHeadingsRange.Font.Bold = true;
                        columnHeadingsRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                        columnHeadingsRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                        columnHeadingsRange.Borders.Weight = XlBorderWeight.xlThin;

                        //Add Data to Excel Sheet
                        worksheet.Cells[row + 1, 1] = item.SAIMC_Nr;
                        worksheet.Cells[row + 1, 2] = item.Title;
                        worksheet.Cells[row + 1, 3] = item.Nickname;
                        worksheet.Cells[row + 1, 4] = item.Surname;
                        worksheet.Cells[row + 1, 5] = item.MobilePhone;
                        if (item.Haspaid == true)
                        {
                            worksheet.Cells[row, 6] = "Yes";
                        }
                        else
                        {
                            worksheet.Cells[row, 6] = "No";
                        }
                        row++;
                    }
                    //Style Cells
                    var usedRange = worksheet.UsedRange;
                    // Add a border around all cells with data
                    usedRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    usedRange.Borders.Weight = XlBorderWeight.xlThin;

                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    workbook.Close();
                    excelApp.Quit();
                    MessageBox.Show("Attendance List has Successfully been exported to Excel");
                }
            }
            catch
            {
                MessageBox.Show("Failed to Export to Excel");
            }
        }
    }
}
