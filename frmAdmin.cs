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
                frmViewMeetingAttendence viewMeeting = new frmViewMeetingAttendence();
                this.Hide();
                viewMeeting.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open View Meetings Form.");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectMeetingToScanMembers selectMeetingForSCanning = new frmSelectMeetingToScanMembers();
                this.Hide();
                selectMeetingForSCanning.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Scan QR code Form");
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
                MessageBox.Show("An Error Occured trying to Open View Meetings Form");
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
                MessageBox.Show("An Error Occured trying to Open Generate QR Form");
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
                MessageBox.Show("An Error Occured trying to Open Create Meeting Form");
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
            catch
            {
                MessageBox.Show("An Error Occured trying to Open Upload Excel Form");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Upload Excel Form Location
                frmViewAllMeetings viewAllMeetings = new frmViewAllMeetings();
                this.Hide();
                viewAllMeetings.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An Error Occured trying to Open View All Meetings Form");
            }
        }
    }
}
