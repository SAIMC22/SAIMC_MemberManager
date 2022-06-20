using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace SAIMC_MemberManager
{
    public partial class PreviewNewMember : Form
    {
        public PreviewNewMember()
        {
            InitializeComponent();
        }
        //Global Variables
        SAIMCEntities db = new SAIMCEntities();
        Member mymembers = new Member();
        BindingList<Member> Mymemberlist = new BindingList<Member>();
        
        
        int count;

        //Get New Member that was Added       
        
        private void PreviewNewMember_Load(object sender, EventArgs e)
        {    
            foreach(Member member in db.Members)
            {
                count++;
            }
            Member memberdetails = db.Members.Find(count);
            txtName.Text = memberdetails.Name;
            txtSurname.Text = memberdetails.Surname;
            txtcellno.Text = memberdetails.ContactNumber.ToString();
            txtidno.Text = memberdetails.IdNumber.ToString();
            //txtdob.Text = memberdetails.DOB.ToString();
            txtgender.Text = memberdetails.Gender;

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
