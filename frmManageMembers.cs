using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmManageMembers : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int MemberShipNumber = 0;

        public frmManageMembers()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("An Error occured trying to open the View Meetings Form.");
            }
        }

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
                MessageBox.Show("An Error occured trying to open the View Meetings Form.");
            }
        }

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
                MessageBox.Show("An Error Occured Loading the Members");
            }
        }

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
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured trying to search for Member.");
            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show("An Error occured trying to search for Member.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvMembers.CurrentCell.RowIndex;
                MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[0].Value.ToString());
                frmEditMember editmember = new frmEditMember();
                this.Hide();
                editmember.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An Error occured trying to edit a Member.");
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure you want to delete? All meeting record for this member will be lost!";
                string title = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
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
            catch
            {
                MessageBox.Show("An Error occured trying to delete a Member.");
            }
        }

        private void btnViewMemberAttendence_Click(object sender, EventArgs e)
        {
            //View Members Attendance for all Meetings
            try
            {
                int rowindex = dgvMembers.CurrentCell.RowIndex;
                MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[0].Value);
                frmViewMembersMeetings ViewMembersMeetingAttendance = new frmViewMembersMeetings();
                this.Hide();
                ViewMembersMeetingAttendance.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open View Member Attendance Form");
            }
        }
    }
}
