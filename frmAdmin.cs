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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncreatenewMember_Click(object sender, EventArgs e)
        {
            //Open New form To add a Member
            frmcreatemember createnewMemberForm = new frmcreatemember();
            createnewMemberForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open New form To Create a Meeting
            frmCreateMeeting Createmeeting = new frmCreateMeeting();
            Createmeeting.ShowDialog();
            this.Close();
        }

        private void btnviewmeetings_Click(object sender, EventArgs e)
        {
            frmViewMeeting viewMeeting = new frmViewMeeting();
            viewMeeting.ShowDialog();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmScanQR viewMeeting = new frmScanQR();
            viewMeeting.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Manage Members
            frmManageMembers viewMeeting = new frmManageMembers();
            viewMeeting.ShowDialog();
            this.Close();
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
