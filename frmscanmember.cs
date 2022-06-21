using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using AForge.Video;
using AForge.Video.DirectShow;
using ClosedXML.Excel;
using System.Data.OleDb;
using Microsoft.Azure.ActiveDirectory.GraphClient;
using System.IO;
using Syncfusion.XlsIO;

namespace SAIMC_MemberManager
{
    public partial class frmScanQR : Form
    {
        public frmScanQR()
        {
            InitializeComponent();
        }
        SAIMCEntities db = new SAIMCEntities();
        List<MemberMeeting> membermeetingList = new List<MemberMeeting>();
        int membershipnumber;
        private void Form1_Load(object sender, EventArgs e)
        {
            pbxGranted.Visible = false;
            pbxDenied.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        //Check when Textbox is Populated
        List<Member> AllMembersList = new List<Member>();
        private async void txtScanmembership_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AllMembersList = db.Members.ToList();                
                await Task.Delay(3);
                {
                    membershipnumber = Convert.ToInt32(txtScanmembership.Text);
                }
                
                if (membershipnumber != 0)
                {
                    
                    var Foundmember = new Member();
                    membermeetingList = db.MemberMeetings.ToList();
                    //Found Member with same Membership Number scanned
                    var foundMember =  AllMembersList.FirstOrDefault(x => x.MemberShipNo == membershipnumber);
                    if(foundMember != null)
                    {
                        //Add Member to new Meeting
                        int latestMeeting = db.Meetings.Max(p => p.Meetingid);
                        //Find all Member Meeting with Lastest Meeting ID
                        MemberMeeting exsistingMemberMeetingList = membermeetingList.Find(x => x.Meetingid == latestMeeting);

                        //Check if Member is in the exsisting Meeting
                        if(exsistingMemberMeetingList != null)
                        {
                            if(exsistingMemberMeetingList.id != foundMember.id)
                            {
                                MemberMeeting membermeeting = new MemberMeeting();
                                membermeeting.id = foundMember.id;
                                membermeeting.Meetingid = latestMeeting;
                                db.MemberMeetings.Add(membermeeting);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                                MemberMeeting membermeeting = new MemberMeeting();
                                membermeeting.id = foundMember.id;
                                membermeeting.Meetingid = latestMeeting;
                                db.MemberMeetings.Add(membermeeting);
                                db.SaveChanges();
                           
                        }
                        if (foundMember.Haspaid == true)
                        {
                            this.BackColor = Color.Green;
                            pbxGranted.Visible = true;
                            pbxDenied.Visible = false;
                            await Task.Delay(2000);
                            this.BackColor = Color.WhiteSmoke;
                            pbxGranted.Visible = false;
                            txtScanmembership.Text = " ";
                            return;
                        }
                       else
                        {
                            this.BackColor = Color.Red;
                            pbxGranted.Visible = false;
                            pbxDenied.Visible = true;
                            await Task.Delay(2000);
                            this.BackColor = Color.WhiteSmoke;
                            pbxDenied.Visible = false;
                            txtScanmembership.Text = " ";
                            return;
                        }

                    }                   
                }                
            }
            catch (Exception ex)
            {
                
            }

        }      

        private void expExcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    Syncfusion.XlsIO.IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2013;
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];
                    //Import DataTable to the worksheet.
                    worksheet.ImportData(db.Members, 1, 1, false);
                    string InitialFileToOpen = @"C:\";
                    var Dialog = new SaveFileDialog();
                    Dialog.InitialDirectory = InitialFileToOpen;
                    Dialog.Filter = "XLSX|*.xlsx";
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(Dialog.FileName);
                    }
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Open New form To Admin
            frmAdmin Createmeeting = new frmAdmin();
            Createmeeting.ShowDialog();
        }
    }
}
