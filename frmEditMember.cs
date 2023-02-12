using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmEditMember : Form
    {
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        public static int MemberShipNumber = 0;

        public frmEditMember()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                frmManageMembers frmManageMembers = new frmManageMembers();
                this.Hide();
                frmManageMembers.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An Error occured trying to open the Manage Members Form.");
            }
        }

        private void frmEditMember_Load(object sender, EventArgs e)
        {
            try
            {
                MemberShipNumber = frmManageMembers.MemberShipNumber;
                List<Member> members = new List<Member>();
                members = db.Members.ToList();
                //members.FirstOrDefault(x => x.id == MemberId);
                foreach (Member member in members)
                {
                    if (member != null)
                    {
                        if (Convert.ToInt32(member.SAIMC_Nr) == MemberShipNumber)
                        {
                            txtName.Text = member.Nickname.TrimEnd();
                            txtSurname.Text = member.Surname.TrimEnd();
                            txtMemberShipnumber.Text = Convert.ToInt64(member.SAIMC_Nr).ToString();
                            txtcellnumber.Text = member.MobilePhone.TrimEnd();
                            if (member.Haspaid == true)
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
            catch
            {
                MessageBox.Show("An Error occured trying to Edit Members,Please Try again.");
            }
        }

        private void btnSaveMem_Click(object sender, EventArgs e)
        {
            Member mymember = new Member();
            List<Member> allMembers = new List<Member>();
            allMembers = db.Members.ToList();
            try
            {
                mymember = allMembers.Find(x => x.SAIMC_Nr == MemberShipNumber);
                //Add Member Details to system and Create a QR Code for that Member
                if (txtName.Text != "" && txtSurname.Text != "" && txtcellnumber.Text != "" && cbxpayment.Text != "" && txtMemberShipnumber.Text != "")
                {
                    if (Convert.ToInt64(txtMemberShipnumber.Text).ToString().All(char.IsDigit) == false)
                    {
                        MessageBox.Show("MemberShip Number can only contain numbers");
                        return;
                    }
                    if (txtcellnumber.Text.TrimEnd().All(char.IsDigit) == false)
                    {
                        MessageBox.Show("Cell Phone Number can only contain numbers with no spaces or Characters");
                        return;
                    }
                    if (txtcellnumber.Text.TrimEnd().Length > 11)
                    {
                        MessageBox.Show("Invalid Cell Number");
                        return;
                    }

                    //Save edited Member to Database
                    mymember.Nickname = txtName.Text;
                    mymember.Surname = txtSurname.Text;
                    mymember.SAIMC_Nr = Convert.ToInt16(txtMemberShipnumber.Text);
                    mymember.MobilePhone = txtcellnumber.Text;

                    if (cbxpayment.Text == "Paid")
                    {
                        mymember.Haspaid = true;
                    }
                    if (cbxpayment.Text == "unpaid")
                    {
                        mymember.Haspaid = false;
                    }

                    string message = "Please confirm edit of: " + txtName.Text + " " + txtSurname.Text;
                    string title = "Please Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                    }
                    else
                    {
                        db.SaveChanges();
                        MessageBox.Show("Member Successfully Edited");
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
            catch
            {
                MessageBox.Show("Edit Failed,Please try Again");
            }
        }
    }
}
