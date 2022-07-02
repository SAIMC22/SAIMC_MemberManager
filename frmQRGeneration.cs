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
    public partial class frmQRGeneration : Form
    {
        //Database Connection
        SAIMCEntities db = new SAIMCEntities();
        public frmQRGeneration()
        {
            InitializeComponent();
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {

        }

        private void frmQRGeneration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generate QR Codes
            List<QRGeneration> qrtableList = new List<QRGeneration>();
            qrtableList = db.QRGenerations.ToList();
            foreach(QRGeneration qrcodes in qrtableList)
            {

                //Setup Folder and Files
                // Specify a name for your top-level folder.
                string folderName = @"c:\Downloads";

                // To create a string that specifies the path to a subfolder under your
                // top-level folder, add a name for the subfolder to folderName.
                string pathString = System.IO.Path.Combine(folderName, "QRCodes");
                if (!System.IO.File.Exists(pathString))
                {
                    // Create the subfolder
                    System.IO.Directory.CreateDirectory(pathString);
                    //TODO ------> Short Char Count & MemberShip Number
                    string firststring = qrcodes.Surname + " " + qrcodes.Name + " " + qrcodes.MemberShipNumber + " " + "QRCode";
                    string message = firststring.Replace(" ", firststring);
                    string fileName = System.IO.Path.GetFileName(message);
                    pathString = System.IO.Path.Combine(pathString, fileName);
                }
                

                string QRinputtext = qrcodes.MemberShipNumber.ToString();
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
                        string filename = qrcodes.Name + qrcodes.Surname + "QRCode.jpg";

                        //Export QR to be Saved on Local Images
                        picboxQRCode.Image.Save(@"C:\Downloads\QRCodes\"+filename);

                    }
                }
                MessageBox.Show("QR Codes Successfully Generated");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdmin myadmin = new frmAdmin();
            myadmin.ShowDialog();
            this.Close();
        }
    }
}
