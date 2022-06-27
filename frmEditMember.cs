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
    public partial class frmEditMember : Form
    {
        SAIMCEntities db = new SAIMCEntities();
        public static string MemberId = "";
        public frmEditMember()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmManageMembers frmManageMembers = new frmManageMembers();
            frmManageMembers.ShowDialog();
            this.Close();
        }

        private void frmEditMember_Load(object sender, EventArgs e)
        {
            MemberId = frmManageMembers.MemberId;
            List<Member> members = new List<Member>();
            members = db.Members.ToList();
            //members.FirstOrDefault(x => x.id == MemberId);
            foreach(Member member in members)
            {
                if(member != null)
                { 
                if(member.id.ToString() == MemberId)
                {
                    txtName.Text = member.Name;
                    txtSurname.Text = member.Surname;
                    nudMembershipNumber.Value = Convert.ToInt32(member.MemberShipNo);
                    nudIdNumber.Value = Convert.ToInt64(member.IdNumber);
                    nudCellNumber.Value = Convert.ToInt32(member.ContactNumber);
                    dob.Value = member.DOB.Value;
                    cbxgender.Text = member.Gender;
                    if(member.Haspaid == true)
                    {
                        cbxpayment.Text = "Paid";
                    }
                    else
                    {
                        cbxpayment.Text = "Unpaid";
                    }
                }
                }
            }
            
        }

        private void btnSaveMem_Click(object sender, EventArgs e)
        {

        }
    }
}
