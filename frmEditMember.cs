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
            Member mymembers = new Member();
            try
            {
                //Add Member Details to system and Create a QR Code for that Member
                if (txtName.Text != "" && txtSurname.Text != "" && nudCellNumber.Value != 0 && nudIdNumber.Value != 0 && cbxgender.Text != "" && cbxpayment.Text != "" && nudMembershipNumber.Value != 0)
                {
                    if (nudIdNumber.Value.ToString().Length != 13)
                    {
                        MessageBox.Show("Invalid Id Number");
                        return;
                    }
                    if (nudCellNumber.Value.ToString().Length != 10)
                    {
                        MessageBox.Show("Invalid Cell Number");
                        return;
                    }
                    //Save New Member to Database
                    mymembers.MemberShipNo = Convert.ToInt32(nudMembershipNumber.Value);
                    mymembers.Name = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.ContactNumber = nudCellNumber.Value.ToString();
                    mymembers.IdNumber = nudIdNumber.Value.ToString();
                    mymembers.DOB = dob.Value.Date;
                    mymembers.Gender = cbxgender.Text;

                    if (cbxpayment.Text == "Paid")
                    {
                        mymembers.Haspaid = true;

                    }
                    if (cbxpayment.Text == "unpaid")
                    {
                        mymembers.Haspaid = false;

                    }
                    db.Members.Add(mymembers);

                    string message = "Please confirm creation of:" + txtName.Text + " " + txtSurname.Text; ;
                    string title = "Please Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {

                    }
                    else
                    {
                        db.SaveChanges();
                        MessageBox.Show("New Member Successfully Created");
                        frmManageMembers frmManageMembers = new frmManageMembers();
                        frmManageMembers.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill in All required Fields");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Creation Failed,Please try Again");
            }

}
        }
    }

