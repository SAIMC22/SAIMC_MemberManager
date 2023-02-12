using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmCreateMemberManual : Form
    {
        //DataBase Connection
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        public frmCreateMemberManual()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                //Back to Manage Member
                frmManageMembers frmManageMembers = new frmManageMembers();
                this.Hide();
                frmManageMembers.ShowDialog();
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
                if (txtName.Text != "" && txtSurname.Text != "" && txtcellnumber.Text != "" && cbxpayment.Text != "" && txtMemberShipnumber.Text != "")
                {
                    if (txtMemberShipnumber.Text.All(char.IsDigit) == false)
                    {
                        MessageBox.Show("MemberShip Number can only contain numbers");
                        return;
                    }
                    if (txtcellnumber.Text.All(char.IsDigit) == false)
                    {
                        MessageBox.Show("Cell Phone Number can only contain numbers");
                        return;
                    }
                    if (txtcellnumber.Text.Length > 11)
                    {
                        MessageBox.Show("Invalid Cell Number");
                        return;
                    }
                    List<Member> memberlist = new List<Member>();
                    memberlist = db.Members.ToList();
                    if (memberlist != null)
                    {
                        foreach (Member member in memberlist)
                        {
                            if (member.SAIMC_Nr == Convert.ToInt32(txtMemberShipnumber.Text))
                            {
                                MessageBox.Show("MemberShip Number Already Exsists.");
                                return;
                            }
                        }
                    }
                    //Save New Member to Database
                    mymembers.SAIMC_Nr = Convert.ToInt32(txtMemberShipnumber.Text);
                    mymembers.Invoice_Type = null;
                    mymembers.Members_Rating = null;
                    mymembers.Branch = null;
                    mymembers.Title = null;
                    mymembers.Initial = null;
                    mymembers.Nickname = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.E_Mail = null;
                    mymembers.MobilePhone = txtcellnumber.Text;
                    mymembers.ECSA = null;
                    mymembers.Paid = null;
                    mymembers.Balance = null;

                    if (cbxpayment.Text == "Paid")
                    {
                        mymembers.Haspaid = true;
                    }
                    if (cbxpayment.Text == "unpaid")
                    {
                        mymembers.Haspaid = false;
                    }
                    db.Members.Add(mymembers);
                    db.SaveChanges();
                    string message = "Please confirm creation of:" + txtName.Text + " " + txtSurname.Text; ;
                    string title = "Please Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Creation of new Member declined.");
                    }
                    else
                    {
                        string QRinputtext = txtMemberShipnumber.Text;
                        QRCodeGenerator NewQR = new QRCodeGenerator();
                        QRCodeData data = NewQR.CreateQrCode(QRinputtext, QRCodeGenerator.ECCLevel.Q);
                        QRCode code = new QRCode(data);
                        picboxQRCode.Image = code.GetGraphic(5);
                        //Setup QRcode to be Saved in the Database
                        byte[] QRCode = null;

                        using (Bitmap bitMap = code.GetGraphic(5))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                //Allows QRCode to be save in the Database
                                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                QRCode = new byte[ms.ToArray().Length];
                                QRCode = ms.ToArray();

                                //Export QR to be Saved on Local Images
                                string InitialFileToOpen = @"C:\";
                                var Dialog = new SaveFileDialog();
                                Dialog.InitialDirectory = InitialFileToOpen;
                                Dialog.Filter = "JPEG|*.jpg";
                                if (Dialog.ShowDialog() == DialogResult.OK)
                                {
                                    picboxQRCode.Image.Save(Dialog.FileName);
                                }
                            }
                        }

                        txtMemberShipnumber.Text = "";
                        txtName.Text = "";
                        txtSurname.Text = "";
                        txtcellnumber.Text = "";
                        cbxpayment.Text = "";
                        MessageBox.Show("New Member Successfully Created");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill in All required Fields");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Creation Failed,Please try Again");
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCreateMemberManual_Load(object sender, EventArgs e)
        {
        }
    }
}
