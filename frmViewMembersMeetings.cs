using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    //View Members Meeting Attendance
    public partial class frmViewMembersMeetings : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int MemberShipNumber = 0;
        private List<MemberMeeting> AllMemberMeetings = new List<MemberMeeting>();
        private List<Meeting> AllMeetingList = new List<Meeting>();
        private List<Member> AllMembers = new List<Member>();

        //Found Lists
        private List<MemberMeeting> MeetingsForMemberFound = new List<MemberMeeting>();

        private Member FoundMember = new Member();
        private List<Meeting> AttendenanceMeetingList = new List<Meeting>();

        public frmViewMembersMeetings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageMembers frmManageMembers = new frmManageMembers();
                this.Hide();
                frmManageMembers.ShowDialog();
                this.Close();
            }
            catch
            {
            }
        }

        private void frmViewMembersMeetings_Load(object sender, EventArgs e)
        {
            try
            {
                //Load All Meetings Member Attended
                AllMembers = db.Members.ToList();
                AllMemberMeetings = db.MemberMeetings.ToList();
                AllMeetingList = db.Meetings.ToList();
                MemberShipNumber = frmManageMembers.MemberShipNumber;
                FoundMember = AllMembers.Find(x => x.SAIMC_Nr == MemberShipNumber);
                //All Members Meetings for Specific Member
                MeetingsForMemberFound = AllMemberMeetings.FindAll(x => x.MemberId == FoundMember.MemberId);
                if (FoundMember != null)
                {
                    lblMemberName.Text = "Members Name:" + " " + FoundMember.Nickname.Trim() + " " + FoundMember.Surname;
                    lblSAIMCNr.Text = "SAIMC Number:" + " " + FoundMember.SAIMC_Nr.ToString();

                    if (MeetingsForMemberFound != null)
                    {
                        foreach (var memberMeeting in MeetingsForMemberFound)
                        {
                            if (memberMeeting.MemberId == FoundMember.MemberId)
                            {
                                foreach (var meeting in AllMeetingList)
                                {
                                    if (meeting.Meetingid == memberMeeting.Meetingid)
                                    {
                                        AttendenanceMeetingList.Add(meeting);
                                    }
                                }
                            }
                        }
                    }
                    // Group records by SAIMC_NR
                    var groups = AttendenanceMeetingList.GroupBy(c => c.Agenda);

                    // Loop through each group
                    foreach (var group in groups)
                    {
                        // Check if the group has more than one item
                        if (group.Count() > 1)
                        {
                            // Remove duplicates except for the first item
                            for (int i = 1; i < group.Count(); i++)
                            {
                                AttendenanceMeetingList.Remove(group.ElementAt(i));
                            }
                        }
                        //Display Datagrid View of Meetings
                        dgvMemberMeetings.DataSource = AttendenanceMeetingList.Select(x => new { Agenda = x.Agenda, Date = x.date, CPD_Points = x.CPDpoints }).ToList();
                        dgvMemberMeetings.AllowUserToAddRows = false;
                        dgvMemberMeetings.AllowUserToDeleteRows = true;
                        dgvMemberMeetings.AllowUserToResizeRows = false;
                        dgvMemberMeetings.RowHeadersWidthSizeMode =
                            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        dgvMemberMeetings.ColumnHeadersHeightSizeMode =
                            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dgvMemberMeetings.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Meeting> meeting = AttendenanceMeetingList.FindAll(x => x.Agenda.Contains(txtSearchMember.Text)).ToList();
                dgvMemberMeetings.DataSource = meeting;
                dgvMemberMeetings.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //List<Member> foundMembersInMeeting = new List<Member>();
                AllMembers = db.Members.ToList();
                var foundMember = AllMembers.Find(x => x.SAIMC_Nr == MemberShipNumber);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = foundMember.Nickname.Trim() + " " + foundMember.Surname.Trim() + " " + "Meeting Attendance";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    var workbook = excelApp.Workbooks.Add(Type.Missing);
                    var worksheet = (Worksheet)workbook.Sheets[1];
                    worksheet.Name = "AttendanceList";

                    int row = 1;
                    foreach (var item in AttendenanceMeetingList)
                    {
                        // Add column headings
                        worksheet.Cells[1, 1] = "Agenda";
                        worksheet.Cells[1, 2] = "Date";
                        worksheet.Cells[1, 3] = "CPD Points";

                        // Style column headings
                        var columnHeadingsRange = worksheet.Range["A1", "C1"];
                        columnHeadingsRange.Font.Bold = true;
                        columnHeadingsRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                        columnHeadingsRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                        columnHeadingsRange.Borders.Weight = XlBorderWeight.xlThin;

                        //Add Data to Excel Sheet
                        worksheet.Cells[row + 1, 1] = item.Agenda;
                        worksheet.Cells[row + 1, 2] = item.date.ToString("yyyy-MM-dd");
                        worksheet.Cells[row + 1, 3] = item.CPDpoints;
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
                    MessageBox.Show("Member Meeting Attendance List has Successfully been exported to Excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Export to Excel");
            }
        }
    }
}
