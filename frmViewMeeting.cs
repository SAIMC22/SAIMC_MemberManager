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
    public partial class frmViewMeeting : Form
    {
        List<Member> members = new List<Member>();
        List<MemberMeeting> Membermeetings = new List<MemberMeeting>();
        List<Member> foundMembersInMeeting = new List<Member>();
        SAIMCEntities db = new SAIMCEntities();
        
        public frmViewMeeting()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            Membermeetings = db.MemberMeetings.ToList();
            members = db.Members.ToList();
            var FoundMemberMeeting = Membermeetings.FindAll(x => x.Meetingid == numericUpDown1.Value).ToList();
            foreach(var membermeeting in FoundMemberMeeting)
            {                
                foreach(var member in members)
                {
                    if(member.id == membermeeting.id)
                    {
                        foundMembersInMeeting.Add(member);
                        
                    }
                }               

            }
            dgvMeeting.DataSource = foundMembersInMeeting;

            dgvMeeting.Update();
            dgvMeeting.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMeeting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
