﻿using System;
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
                    if (Convert.ToInt64(txtMemberShipnumber.Text).ToString().All(char.IsDigit) == false)
                    {
                        MessageBox.Show("MemberShip Number can only contain numbers");
                        return;
                    }
                    if (txtIdNumber.Text.TrimEnd().All(char.IsDigit) == false)
                    {
                        MessageBox.Show("Id Number can only contain numbers");
                        return;
                    }
                    if (txtIdNumber.Text.TrimEnd().Length != 13)
                    {
                        MessageBox.Show("Invalid Id Number");
                        return;
                    }
                    if (txtcellnumber.Text.TrimEnd().All(char.IsDigit) == false)
                    {
                        MessageBox.Show("Cell Phone Number can only contain numbers");
                        return;
                    }
                    if (txtcellnumber.Text.TrimEnd().Length != 10)
                    {
                        MessageBox.Show("Invalid Cell Number");
                        return;
                    }

                    //Save edited Member to Database
                    mymembers.Nickname = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.SAIMC_Nr = Convert.ToInt16(txtMemberShipnumber.Text);
                    mymembers.MobilePhone = txtcellnumber.Text;

                    if (cbxpayment.Text == "Paid")
                    {
                        mymembers.Haspaid = true;
                    }
                    if (cbxpayment.Text == "unpaid")
                    {
                        mymembers.Haspaid = false;
                    }
                    //db.Members.Add(mymembers);

                    string message = "Please confirm edit of:" + txtName.Text + " " + txtSurname.Text;
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
