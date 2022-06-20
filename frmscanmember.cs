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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open New form To add a Member
            frmcreatemember createnewMemberForm = new frmcreatemember();
            createnewMemberForm.ShowDialog();
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
                            await Task.Delay(2000);
                            this.BackColor = Color.WhiteSmoke;
                            txtScanmembership.Text = " ";
                            return;
                        }
                       else
                        {
                            this.BackColor = Color.Red;
                            await Task.Delay(2000);
                            this.BackColor = Color.WhiteSmoke;
                            txtScanmembership.Text = " ";
                            return;
                        }

                    }                   
                }                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }


        //Create Datatable from Database Read
            public static DataTable createDataTable()
        {
            SAIMCEntities db = new SAIMCEntities();
            //Create Datatable
            DataTable Membertable = new DataTable();
            Membertable.Columns.Add("ID", typeof(int));
            Membertable.Columns.Add("NAME", typeof(string));
            Membertable.Columns.Add("Surname", typeof(string));
            Membertable.Columns.Add("MemberShip Number", typeof(string));
            Membertable.Columns.Add("ID Number", typeof(string));
            Membertable.Columns.Add("Gender", typeof(string));
            Membertable.Columns.Add("Date of Birth", typeof(string));
            Membertable.Columns.Add("Has Paid", typeof(string));

            foreach (Member member in db.Members)
            {
                Membertable.Rows.Add(member.Name, member.Surname, member.MemberShipNo, member.IdNumber, member.Gender, member.DOB, member.Haspaid);
            }
            return Membertable;


        }

        /*//Convert Datatable to CSV
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }*/
        private void CheckTick_Tick(object sender, EventArgs e)
        {

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
                  

                    //workbook.SaveAs("ImportFromDT.xlsx");
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Open New form To Create a Meeting
            frmCreateMeeting Createmeeting = new frmCreateMeeting();
            Createmeeting.ShowDialog();
        }

        private void btnviewmeetings_Click(object sender, EventArgs e)
        {
            frmViewMeeting viewMeeting = new frmViewMeeting();
            viewMeeting.ShowDialog();
        }
    }
}
