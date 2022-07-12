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
            this.Hide();
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
                    txtMemberShipnumber.Text = member.MemberShipNo.ToString();
                    txtIdNumber.Text = member.IdNumber.ToString();
                    txtcellnumber.Text = member.ContactNumber.ToString();
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
                if (txtName.Text != "" && txtSurname.Text != "" && txtcellnumber.Text != "" && txtIdNumber.Text != "" && cbxgender.Text != "" && cbxpayment.Text != "" && txtMemberShipnumber.Text != "")
                {
                    if (txtIdNumber.Text.Length != 13)
                    {
                        MessageBox.Show("Invalid Id Number");
                        return;
                    }
                    if (txtcellnumber.Text.Length != 10)
                    {
                        MessageBox.Show("Invalid Cell Number");
                        return;
                    }

                    //Save New Member to Database
                    mymembers.Name = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.MemberShipNo = Convert.ToInt32(txtMemberShipnumber.Text);
                    mymembers.IdNumber = txtIdNumber.Text;
                    mymembers.ContactNumber = txtcellnumber.Text;
                    mymembers.DOB = dob.Value;
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

                    string message = "Please confirm creation of:" + txtName.Text + " " + txtSurname.Text;
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
                        this.Hide();
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

