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
            try
            {
                //Open New form To add a Member
                frmcreatemember createnewMemberForm = new frmcreatemember();
                this.Hide();
                createnewMemberForm.ShowDialog();
                this.Close();
            }
            catch
            {

            }
        }
        private void btnviewmeetings_Click(object sender, EventArgs e)
        {
            try { 
            frmViewMeeting viewMeeting = new frmViewMeeting();
            this.Hide();
            viewMeeting.ShowDialog();
            this.Close();
            }
            catch
            {

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try { 
            frmScanQR viewMeeting = new frmScanQR();
            this.Hide();
            viewMeeting.ShowDialog();
            this.Close();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            //Manage Members
            frmManageMembers viewMeeting = new frmManageMembers();
            this.Hide();
            viewMeeting.ShowDialog();
            this.Hide();
            }
            catch
            {

            }
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateQrCode_Click_1(object sender, EventArgs e)
        {
            try { 
            //Open New form To QrCode Generation
            frmQRGeneration QrCodeGenration = new frmQRGeneration();
            this.Hide();
            QrCodeGenration.ShowDialog();
            this.Close();
            }
            catch
            {

            }
        }

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            try { 
            //Create New Meeting
            frmCreateMeeting createMeeting = new frmCreateMeeting();
            this.Hide();
            createMeeting.ShowDialog();
            }
            catch
            {

            }

        }
    }
}
