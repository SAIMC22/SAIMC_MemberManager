using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmScanQR : Form
    {
        public frmScanQR()
        {
            InitializeComponent();
        }

        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();
        private List<MemberMeeting> membermeetingList = new List<MemberMeeting>();
        private List<Meeting> meetingList = new List<Meeting>();
        private int membershipnumber;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pbxGranted.Visible = false;
                pbxDenied.Visible = false;
                meetingList = db.Meetings.ToList();
                if (meetingList.Count > 0)
                {
                    int latestMeeting = db.Meetings.Max(p => p.Meetingid);
                    lblMeetingAgenda.Text = "Meeting Agenda:" + " " + db.Meetings.FirstOrDefault(x => x.Meetingid == latestMeeting).Agenda.ToString();
                }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        //Check when Textbox is Populated
        private List<Member> AllMembersList = new List<Member>();

        private Member FoundMember = new Member();

        private async void txtScanmembership_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(3);
                {
                    meetingList = db.Meetings.ToList();
                    if (meetingList.Count == 0)
                    {
                        string message = "Would you like to create a Meeting?";
                        string title = "No Created Meeting";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            //Open New form To Create a Meeting
                            frmCreateMeeting Createmeeting = new frmCreateMeeting();
                            this.Hide();
                            Createmeeting.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Members can't be scan if not meeting is created");
                            try
                            {
                                //Open New form To Admin
                                frmAdmin Createmeeting = new frmAdmin();
                                this.Hide();
                                Createmeeting.ShowDialog();
                                this.Close();
                            }
                            catch
                            {
                            }
                        }
                    }
                    membershipnumber = Convert.ToInt32(txtScanmembership.Text);
                }

                if (membershipnumber != 0)
                {
                    AllMembersList = db.Members.ToList();

                    membermeetingList = db.MemberMeetings.ToList();
                    //Finds Member with same Membership Number scanned
                    FoundMember = AllMembersList.Find(x => Convert.ToInt32(x.SAIMC_Nr) == membershipnumber);
                    if (FoundMember == null)
                    {
                        this.BackColor = Color.Red;
                        pbxGranted.Visible = false;
                        pbxDenied.Visible = true;
                        MessageBox.Show("Member not found,Please contact Admin");
                        this.BackColor = Color.WhiteSmoke;
                        pbxDenied.Visible = false;
                        txtScanmembership.Text = " ";
                        return;
                    }
                    if (FoundMember != null)
                    {
                        //Add Member to new Meeting
                        //Get Latest Meeting

                        int latestMeeting = db.Meetings.Max(p => p.Meetingid);

                        //Find all Member Meeting with Lastest Meeting ID
                        List<MemberMeeting> LatestMemberMeetingList = new List<MemberMeeting>();
                        if (membermeetingList.Count != 0)
                        {
                            foreach (MemberMeeting meeting in membermeetingList)
                            {
                                if (latestMeeting == meeting.Meetingid)
                                {
                                    LatestMemberMeetingList.Add(meeting);
                                }
                            }
                        }
                        else
                        {
                            MemberMeeting membermeeting = new MemberMeeting();
                            //Get Member Meeting ID compared to SAIMC_Nr

                            membermeeting.MemberId = FoundMember.MemberId;
                            membermeeting.Meetingid = latestMeeting;
                            db.MemberMeetings.Add(membermeeting);
                            db.SaveChanges();
                        }
                        //LatestMemberMeetingList = membermeetingList.FindAll(x=>x.Meetingid == latestMeeting);
                        var memberExsists = LatestMemberMeetingList.Find(x => x.MemberId == FoundMember.MemberId);
                        if (LatestMemberMeetingList != null)
                        {
                            if (memberExsists == null)
                            {
                                MemberMeeting membermeeting = new MemberMeeting();
                                membermeeting.MemberId = FoundMember.MemberId;
                                membermeeting.Meetingid = latestMeeting;
                                db.MemberMeetings.Add(membermeeting);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            MemberMeeting membermeeting = new MemberMeeting();
                            membermeeting.MemberId = FoundMember.MemberId;
                            membermeeting.Meetingid = latestMeeting;
                            membermeeting.Member = null;
                            membermeeting.Meeting = null;
                            db.MemberMeetings.Add(membermeeting);
                            db.SaveChanges();
                        }

                        if (FoundMember.Haspaid == true)
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
                //MessageBox.Show(ex.ToString());
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
            try
            {
                //Open New form To Admin
                frmAdmin Createmeeting = new frmAdmin();
                this.Hide();
                Createmeeting.ShowDialog();
                this.Close();
            }
            catch
            {
            }
        }
    }
}
