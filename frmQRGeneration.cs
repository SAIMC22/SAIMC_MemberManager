using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmQRGeneration : Form
    {
        //Database Connection
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        public frmQRGeneration()
        {
            InitializeComponent();
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
        }

        private void frmQRGeneration_Load(object sender, EventArgs e)
        {
            //Generate QR Codes
            List<Member> MemberList = new List<Member>();
            MemberList = db.Members.ToList();
            if(MemberList.Count == 0)
            {
                MessageBox.Show("There are no members in the system.Please add or upload members.");
                //Open New form To QAdmin Form)
                frmAdmin frmAdmin = new frmAdmin();
                this.Hide();
                frmAdmin.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Generate QR Codes
                List<Member> MemberList = new List<Member>();
                MemberList = db.Members.ToList();
                foreach (Member members in MemberList)
                {
                    //Setup Folder and Files
                    // Specify a name for your top-level folder.
                    string folderName = @"C:\Downloads";

                    // To create a string that specifies the path to a subfolder under your
                    // top-level folder, add a name for the subfolder to folderName.
                    string pathString = System.IO.Path.Combine(folderName, "QRCodes");
                    if (!System.IO.File.Exists(pathString))
                    {
                        // Create the subfolder
                        System.IO.Directory.CreateDirectory(pathString);
                        //TODO ------> Short Char Count & MemberShip Number
                        string firststring = members.Surname.Trim() + " " + members.Nickname.Trim() + " " + members.SAIMC_Nr + " " + "QRCode";
                        // string message = firststring.Replace(" ", firststring);
                        string fileName = System.IO.Path.GetFileName(firststring);
                        pathString = System.IO.Path.Combine(pathString, fileName);
                    }

                    string QRinputtext = members.SAIMC_Nr.ToString();
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
                            string filename = members.Surname.Trim() + " " + members.Nickname.Trim() + " " + members.SAIMC_Nr + " " + "QRCode.jpg";
                            //Export QR to be Saved on Local Images
                            picboxQRCode.Image.Save(@"C:\Downloads\QRCodes\" + filename);
                        }
                    }
                }
                MessageBox.Show("QR Codes Successfully Generated and are stored in Downloads Folder on your Local Machine.");
            }
            catch
            {
                MessageBox.Show("An Error occured trying to generate QR Codes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdmin myadmin = new frmAdmin();
            this.Hide();
            myadmin.ShowDialog();
        }
    }
}
