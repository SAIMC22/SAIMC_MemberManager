using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmcreatemember : Form
    {
        public frmcreatemember()
        {
            InitializeComponent();
        }

        //Global Veriables
        private VideoCaptureDevice ImagecaptureDevice;

        private FilterInfoCollection filterInfoCollection;

        //DataBase Connection
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        private void frmcreatemember_Load(object sender, EventArgs e)
        {
            //Start Timer Check
            Timercheck.Start();
            //Get what camera devices are avaliable
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbxselectcamera.Items.Add(filterInfo.Name);
            cbxselectcamera.SelectedIndex = 0;
        }

        private void btnSaveMem_Click(object sender, EventArgs e)
        {
            Member mymembers = new Member();
            try
            {
                //Add Member Details to system and Create a QR Code for that Member
                if (txtName.Text != "" && txtSurname.Text != "" && txtcontactnumber.Text != " " && txtIdnumber.Text != "" && cbxgender.Text != "" && cbxpayment.Text != "" && txtmembershipno.Text != "")
                {
                    string QRinputtext = txtmembershipno.Text;
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
                            Dialog.Filter = "PNG|8.png|JPEG|*.jpg";
                            if (Dialog.ShowDialog() == DialogResult.OK)
                            {
                                picboxQRCode.Image.Save(Dialog.FileName);
                            }
                        }
                    }
                    //Save New Member to Database
                    mymembers.SAIMC_Nr = Convert.ToInt16(txtmembershipno.Text);
                    mymembers.Nickname = txtName.Text;
                    mymembers.Surname = txtSurname.Text;
                    mymembers.MobilePhone = txtcontactnumber.Text;

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
                    MessageBox.Show("New Member Successfully Created");
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

        //Start Camera For adding New Image
        private void btnCaptureProfilepic_Click(object sender, EventArgs e)
        {
            ImagecaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbxselectcamera.SelectedIndex].MonikerString);
            ImagecaptureDevice.NewFrame += VideoCapture_NewFrame;
            ImagecaptureDevice.Start();
        }

        private void VideoCapture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picboximagecapture.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btntakepic_Click(object sender, EventArgs e)
        {
            picboximagecapture.Hide();
            picboxprofilepic.Image = picboximagecapture.Image;
            picboxprofilepic.Visible = true;
        }

        //Convert Image to Binary
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                picboxprofilepic.Image.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnretakepic_Click(object sender, EventArgs e)
        {
            picboximagecapture.Show();
            picboxprofilepic.Hide();
        }

        private void Timercheck_Tick(object sender, EventArgs e)
        {
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmScanQR viewscannerform = new frmScanQR();
            this.Hide();
            viewscannerform.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keagz\source\repos\SAIMC_MemberManager\SAIMC_DataBase.accdb");

        private void btnSaveinAccess_Click(object sender, EventArgs e)
        {
            try
            {
                string QRinputtext = txtmembershipno.Text;
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
                        //mymembers.MemberQRCode = QRCode;

                        //Export QR to be Saved on Local Images
                        string InitialFileToOpen = @"C:\";
                        var Dialog = new SaveFileDialog();
                        Dialog.InitialDirectory = InitialFileToOpen;
                        Dialog.Filter = "PNG|8.png|JPEG|*.jpg";
                        if (Dialog.ShowDialog() == DialogResult.OK)
                        {
                            picboxQRCode.Image.Save(Dialog.FileName);
                        }
                    }
                }
                //Save New Member to Database
                /* mymembers.MemberShipNo = txtmembershipno.Text;
                 mymembers.Name = txtName.Text;
                 mymembers.Surname = txtSurname.Text;
                 mymembers.ContactNumber = txtcontactnumber.Text;
                 mymembers.IdNumber = txtIdnumber.Text;
                 mymembers.DOB = dtpDOB.Value.Date;
                 mymembers.Gender = cbxGender.Text;

                 if (cbxPaymentMethod.Text == "Cash")
                 {
                     mymembers.Haspaid = true;
                 }
                 if (cbxPaymentMethod.Text == "Card unpaid")
                 {
                     mymembers.Haspaid = false;
                 }*/

                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "INSERT into Members (Name,Surname) Values ('" + txtName.Text + "','" + txtSurname.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Submitted", "Congrats");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
