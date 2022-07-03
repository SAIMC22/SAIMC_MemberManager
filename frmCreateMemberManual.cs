using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmCreateMemberManual : Form
    {
        //DataBase Connection
        SAIMCEntities db = new SAIMCEntities();
        public frmCreateMemberManual()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Back to Manage Member
            frmManageMembers frmManageMembers = new frmManageMembers();
            frmManageMembers.ShowDialog();
            this.Close();
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
                    mymembers.MemberShipNo = Convert.ToInt32(txtMemberShipnumber.Text);
                    mymembers.Name = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.ContactNumber = txtcellnumber.Text;                    
                    mymembers.IdNumber = txtcellnumber.Text;
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
                                mymembers.MemberQRCode = QRCode;

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
                        db.SaveChanges();
                        txtMemberShipnumber.Text = "";
                        txtName.Text = "";
                        txtSurname.Text = "";
                        txtcellnumber.Text = "";
                        txtIdNumber.Text = "";
                        cbxgender.Text = "";
                        cbxpayment.Text = "";
                        MessageBox.Show("New Member Successfully Created");                       
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
