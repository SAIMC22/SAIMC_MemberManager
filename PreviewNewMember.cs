using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class PreviewNewMember : Form
    {
        public PreviewNewMember()
        {
            InitializeComponent();
        }

        //Global Variables
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        private Member mymembers = new Member();
        private BindingList<Member> Mymemberlist = new BindingList<Member>();

        private int count;

        //Get New Member that was Added

        private void PreviewNewMember_Load(object sender, EventArgs e)
        {
            foreach (Member member in db.Members)
            {
                count++;
            }
            Member memberdetails = db.Members.Find(count);
            txtName.Text = memberdetails.Nickname;
            txtSurname.Text = memberdetails.Surname;
            txtcellno.Text = memberdetails.MobilePhone.ToString();

            //Convert Image from varbinary back to Image to be Displayed
            //byte[] imagebytes = memberdetails.ProfileImage.ToArray();
            /*MemoryStream imagestream = new MemoryStream(imagebytes);
            Image imgFromStream = Image.FromStream(imagestream);
            picboxprofilepic.Image = imgFromStream;*/

            //Saving New Members QR Code to the Data Base
            //mymembers.MemberQRCode = (byte[])(new ImageConverter()).ConvertTo(code.GetGraphic(5), typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}
