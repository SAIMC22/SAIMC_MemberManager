using System;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmCreateMeeting : Form
    {
        public frmCreateMeeting()
        {
            InitializeComponent();
        }

        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        private void frmCreateMeeting_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtagenda.Text == "")
            {
                MessageBox.Show("Please fill in all Information");
            }
            else
            {
                if (nudCPDPoints.Value < 1)
                {
                    string message = "Is this Meetings CPD points 0?";
                    string title = "Please Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                    }
                    else
                    {
                        Meeting meeting = new Meeting();
                        meeting.Agenda = txtagenda.Text;
                        meeting.date = DateTime.Now;
                        meeting.CPDpoints = Convert.ToInt32(nudCPDPoints.Value);
                        db.Meetings.Add(meeting);
                        db.SaveChanges();
                        MessageBox.Show("Meeting Created", "Success", MessageBoxButtons.OK);
                        frmAdmin frmAdmin = new frmAdmin();
                        this.Hide();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    Meeting meeting = new Meeting();
                    meeting.Agenda = txtagenda.Text;
                    meeting.date = DateTime.Now;
                    meeting.CPDpoints = Convert.ToInt32(nudCPDPoints.Value);
                    db.Meetings.Add(meeting);
                    db.SaveChanges();
                    MessageBox.Show("Meeting Created", "Success", MessageBoxButtons.OK);
                    frmAdmin frmAdmin = new frmAdmin();
                    this.Hide();
                    frmAdmin.ShowDialog();
                    this.Close();
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Close();
        }
    }
}
