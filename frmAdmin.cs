using System;
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
                MessageBox.Show("An Error Occured trying to Open Create new Member Form,Please Contact Admin");
            }
        }

        private void btnviewmeetings_Click(object sender, EventArgs e)
        {
            try
            {
                frmViewMeeting viewMeeting = new frmViewMeeting();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open View Meetings Form,Please Contact Admin");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                frmScanQR viewMeeting = new frmScanQR();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Scan QR code Form,Please Contact Admin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Manage Members
                frmManageMembers viewMeeting = new frmManageMembers();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Manage Members Form,Please Contact Admin");
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
            try
            {
                //Open New form To QrCode Generation
                frmQRGeneration QrCodeGenration = new frmQRGeneration();
                this.Hide();
                QrCodeGenration.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Generate QR Form,Please Contact Admin");
            }
        }

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                //Create New Meeting
                frmCreateMeeting createMeeting = new frmCreateMeeting();
                this.Hide();
                createMeeting.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Create Meeting Form,Please Contact Admin");
            }
        }

        private void uploadExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Upload Excel Form Location
                frmUploadExcel uploadExcel = new frmUploadExcel();
                this.Hide();
                uploadExcel.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("An Error Occured trying to Open Upload Excel Form,Please Contact Admin");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
