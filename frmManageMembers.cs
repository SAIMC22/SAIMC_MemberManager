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
        public frmManageMembers()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create new Members
            frmcreatemember viewMeeting = new frmcreatemember();
            viewMeeting.ShowDialog();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmAdmin viewMeeting = new frmAdmin();
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
            Member member = members.Where(x => x.Name == txtSearchMember.Text).FirstOrDefault();
            dgvMembers.DataSource = member;
            dgvMembers.Update();
        }
    }
}
