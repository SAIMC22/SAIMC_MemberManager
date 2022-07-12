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
        public static string MemberId = "";
        public frmManageMembers()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create new Members
            frmCreateMemberManual viewMeeting = new frmCreateMemberManual();
            this.Hide();
            viewMeeting.ShowDialog();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmAdmin viewMeeting = new frmAdmin();
            this.Hide();
            viewMeeting.ShowDialog();
            this.Close();
        }

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            List<Member> members = new List<Member>();
            members = db.Members.ToList();
            dgvMembers.DataSource = members;
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

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            List<Member> members = new List<Member>();
            members = db.Members.ToList();
            List<Member> member = members.FindAll(x => x.Name.Contains(txtSearchMember.Text)).ToList();
            dgvMembers.DataSource = member;
            dgvMembers.Update();
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            List<Member> members = new List<Member>();
            members = db.Members.ToList();
            List<Member> member = members.FindAll(x => x.Name.Contains(txtSearchMember.Text)).ToList();
            dgvMembers.DataSource = member;
            dgvMembers.Update();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = dgvMembers.CurrentCell.RowIndex;
            MemberId = dgvMembers.Rows[rowindex].Cells[0].Value.ToString();
            frmEditMember editmember = new frmEditMember();
            this.Hide();
            editmember.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                MemberId = dgvMembers.Rows[rowindex].Cells[0].Value.ToString();
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                Member member = members.Find(x => x.id == Convert.ToInt32(MemberId));
                db.Members.Remove(member);
                db.SaveChanges();
                List<Member> newmemberList = new List<Member>();
                newmemberList = db.Members.ToList();
                dgvMembers.DataSource = newmemberList;
                dgvMembers.Update();
            }

        }
    }
}
