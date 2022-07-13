using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmManageMembers : Form
    {
        SAIMCEntities db = new SAIMCEntities();
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
            { }
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
            catch { }
        }

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                dgvMembers.DataSource = members.Select(x => new { Name = x.Name, Surname = x.Surname, Membership_Number = x.MemberShipNo, ID_Number = x.IdNumber, Contact_Number = x.ContactNumber, Gender = x.Gender, Date_Of_Birth = x.DOB, Paid = x.Haspaid }).ToList();
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
            catch { }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                List<Member> member = members.FindAll(x => x.Name.Contains(txtSearchMember.Text)).ToList();
                dgvMembers.DataSource = member;
                dgvMembers.Update();
            }
            catch
            {

            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                List<Member> member = members.FindAll(x => x.Name.Contains(txtSearchMember.Text)).ToList();
                dgvMembers.DataSource = member;
                dgvMembers.Update();
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvMembers.CurrentCell.RowIndex;
                MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[2].Value.ToString());
                frmEditMember editmember = new frmEditMember();
                this.Hide();
                editmember.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure you want to delete?";
                string title = "Please Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {

                }
                else
                {
                    int rowindex = dgvMembers.CurrentCell.RowIndex;
                    MemberShipNumber = Convert.ToInt32(dgvMembers.Rows[rowindex].Cells[2].Value.ToString());
                    List<Member> members = new List<Member>();
                    members = db.Members.ToList();
                    Member member = members.Find(x => Convert.ToInt32(x.MemberShipNo) == Convert.ToInt32(MemberShipNumber));
                    db.Members.Remove(member);
                    db.SaveChanges();
                    List<Member> newmemberList = new List<Member>();
                    newmemberList = db.Members.ToList();
                    dgvMembers.DataSource = newmemberList;
                    dgvMembers.Update();
                }
            }
            catch
            {
                MessageBox.Show("Member Belongs to Past Meetings");
            }

        }
    }
}
