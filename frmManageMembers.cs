using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;

namespace SAIMC_MemberManager
{
    public partial class frmManageMembers : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int MemberShipNumber = 0;
        List<Member> AllMembersList = new List<Member>();

        public frmManageMembers()
        {
            InitializeComponent();
        }
        //Create Member Function
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //Create new Members
                frmCreateMemberManual viewMeeting = new frmCreateMemberManual();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Close();
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error occured trying to open the View Meetings Form.");
            }
        }
        //Back Button Click
        private void btncancel_Click(object sender, EventArgs e)
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
                System.Windows.MessageBox.Show("An Error occured trying to open the View Meetings Form.");
            }
        }
        //Form Load
        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                dgvMembers.DataSource = members.Select(x => new { SAIMC_Nr = x.SAIMC_Nr, NickName = x.Nickname, Surname = x.Surname, Mobile_Phone = x.MobilePhone, Paid = x.Haspaid }).ToList();
                dgvMembers.AllowUserToAddRows = false;
                dgvMembers.AllowUserToDeleteRows = true;
                dgvMembers.AllowUserToResizeRows = false;
                dgvMembers.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMembers.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMembers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error Occured Loading the Members");
            }
        }
        //Search Member Button
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                List<Member> member = members.FindAll(x => x.Nickname.Contains(txtSearchMember.Text)).ToList();
                dgvMembers.DataSource = member;
                dgvMembers.Update();
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error occured trying to search for Member.");
            }
        }
        //On Change Search Member
        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                List<Member> member = members.FindAll(x => x.Nickname.Contains(txtSearchMember.Text)).ToList();
                dgvMembers.DataSource = member.Select(x => new { SAIMC_Nr = x.SAIMC_Nr, NickName = x.Nickname, Surname = x.Surname, Mobile_Phone = x.MobilePhone, Paid = x.Haspaid }).ToList();
                dgvMembers.AllowUserToAddRows = false;
                dgvMembers.AllowUserToDeleteRows = true;
                dgvMembers.AllowUserToResizeRows = false;
                dgvMembers.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvMembers.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvMembers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMembers.Update();
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error occured trying to search for Member.");
            }
        }
        //Edit Member
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMembers.Rows.Count != 0)
                {
                    int rowindex = dgvMembers.CurrentCell.RowIndex;
                    MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[0].Value.ToString());
                    frmEditMember editmember = new frmEditMember();
                    this.Hide();
                    editmember.ShowDialog();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Member was select or None exist");
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error occured trying to edit a Member.");
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //Delete Member
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMembers.Rows.Count != 0)
                {
                    string message = "Are you sure you want to delete? All meeting record for this member will be lost!";
                    string title = "Please Confirm Deletion";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = System.Windows.Forms.MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                    }
                    else
                    {
                        int rowindex = dgvMembers.CurrentCell.RowIndex;
                        MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[0].Value.ToString());
                        List<Member> members = new List<Member>();
                        members = db.Members.ToList();
                        Member member = members.Find(x => Convert.ToInt32(x.SAIMC_Nr) == Convert.ToInt32(MemberShipNumber));
                        db.Members.Remove(member);
                        db.SaveChanges();
                        //Load Same DGV as Before
                        List<Member> newmembers = new List<Member>();
                        newmembers = db.Members.ToList();
                        dgvMembers.DataSource = newmembers.Select(x => new { SAIMC_Nr = x.SAIMC_Nr, NickName = x.Nickname, Surname = x.Surname, Mobile_Phone = x.MobilePhone, Paid = x.Haspaid }).ToList();
                        dgvMembers.AllowUserToAddRows = false;
                        dgvMembers.AllowUserToDeleteRows = true;
                        dgvMembers.AllowUserToResizeRows = false;
                        dgvMembers.RowHeadersWidthSizeMode =
                            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        dgvMembers.ColumnHeadersHeightSizeMode =
                            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dgvMembers.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Member was select or None exist");
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error occured trying to delete a Member.");
            }
        }

        private void btnViewMemberAttendence_Click(object sender, EventArgs e)
        {
            //View Members Attendance for all Meetings
            try
            {
                if (dgvMembers.Rows.Count != 0)
                {
                    int rowindex = dgvMembers.CurrentCell.RowIndex;
                    MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[0].Value);
                    frmViewMembersMeetings ViewMembersMeetingAttendance = new frmViewMembersMeetings();
                    this.Hide();
                    ViewMembersMeetingAttendance.ShowDialog();
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Member was select or None exist");
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("An Error Occured trying to Open View Member Attendance Form");
            }
        }
        //Export Member List to excel
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BusyIndicator busyIndicator = new BusyIndicator();
                //List<Member> foundMembersInMeeting = new List<Member>();
                AllMembersList = db.Members.ToList();
                if (AllMembersList.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No Members in the System to export");
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = "List Of All Members" + "Date " + DateTime.Now.ToString("yyyy-MM-dd");

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var excelApp = new Microsoft.Office.Interop.Excel.Application();
                        var workbook = excelApp.Workbooks.Add(Type.Missing);
                        var worksheet = (Worksheet)workbook.Sheets[1];
                        worksheet.Name = "Members List";

                        int row = 1;
                        foreach (var item in AllMembersList)
                        {
                            // Add column headings
                            worksheet.Cells[1, 1] = "SAIMC_Nr";
                            worksheet.Cells[1, 2] = "Invoice Type";
                            worksheet.Cells[1, 3] = "Members Rating";
                            worksheet.Cells[1, 4] = "Branch";
                            worksheet.Cells[1, 5] = "Title";
                            worksheet.Cells[1, 6] = "Initial";
                            worksheet.Cells[1, 7] = "Nickname";
                            worksheet.Cells[1, 8] = "Surname";
                            worksheet.Cells[1, 9] = "E-Mail";
                            worksheet.Cells[1, 10] = "MobilePhone";
                            worksheet.Cells[1, 11] = "ECSA";
                            worksheet.Cells[1, 12] = "Paid";
                            worksheet.Cells[1, 13] = "Balance";
                            worksheet.Cells[1, 14] = "Haspaid";

                            // Style column headings
                            var columnHeadingsRange = worksheet.Range["A1", "N1"];
                            columnHeadingsRange.Font.Bold = true;
                            columnHeadingsRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                            columnHeadingsRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                            columnHeadingsRange.Borders.Weight = XlBorderWeight.xlThin;

                            //Add Data to Excel Sheet
                            worksheet.Cells[row + 1, 1] = item.SAIMC_Nr;
                            worksheet.Cells[row + 1, 2] = item.Invoice_Type;
                            worksheet.Cells[row + 1, 3] = item.Members_Rating;
                            worksheet.Cells[row + 1, 4] = item.Branch;
                            worksheet.Cells[row + 1, 5] = item.Title;
                            worksheet.Cells[row + 1, 6] = item.Initial;
                            worksheet.Cells[row + 1, 7] = item.Nickname;
                            worksheet.Cells[row + 1, 8] = item.Surname;
                            worksheet.Cells[row + 1, 9] = item.E_Mail;
                            worksheet.Cells[row + 1, 10] = item.MobilePhone;
                            worksheet.Cells[row + 1, 11] = item.ECSA;
                            worksheet.Cells[row + 1, 12] = (double)Convert.ToDouble(item.Paid);
                            worksheet.Cells[row + 1, 13] = (double)Convert.ToDouble(item.Balance);
                            if (item.Haspaid == true)
                            {
                                worksheet.Cells[row + 1, 14] = "Yes";
                            }
                            else
                            {
                                worksheet.Cells[row + 1, 14] = "No";
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
                        System.Windows.MessageBox.Show("Members List has Successfully been exported to Excel");
                    }
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Failed to Export to Excel");
            }

        }
        }
}
       /* private void LoaderDisplay()
        { 
                // Show the loader
                LoadingPanel.Visible = true;

                // Start a new thread to simulate a long-running operation
                Thread backgroundThread = new Thread(new ThreadStart(BackgroundOperation));
                backgroundThread.Start();
            }

            private void BackgroundOperation()
            {
                // Simulate a long-running operation
                Thread.Sleep(5000);

                // Update the UI on the main thread
                this.Invoke((MethodInvoker)delegate
                {
                    // Hide the loader
                    LoadingPanel.Visible = false;
                    // Show a message to indicate the operation has completed
                    System.Windows.Forms.MessageBox.Show("The operation has completed.", "Loader Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
        }
    }
}*/