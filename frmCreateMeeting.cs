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
    public partial class frmCreateMeeting : Form
    {
        public frmCreateMeeting()
        {
            InitializeComponent();
        }
        SAIMCEntities db = new SAIMCEntities();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateMeeting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meeting meeting = new Meeting();
            meeting.Agenda = txtagenda.Text;
            meeting.date = DateTime.Now;
            meeting.CPDpoints = Convert.ToInt32(txtCPDPoints.Text);
            db.Meetings.Add(meeting);
            db.SaveChanges();
            MessageBox.Show("Meeting Created", "Success", MessageBoxButtons.OK); 
            this.Close();
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
