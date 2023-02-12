using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmUploadExcel : Form
    {
        //Connection String to SQL Database
        private string sqlConnectionString = "Data Source=.;initial catalog=SAIMCDBV2;integrated security=True";

        //Database connection
        private SAIMCDBV2Entities db = new SAIMCDBV2Entities();

        public frmUploadExcel()
        {
            InitializeComponent();
        }

        private void btnUploadExcel_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                DataTable dataTable = ReadExcelFile(filePath);
                if (dataTable != null)
                {
                    InsertDataIntoSqlTable(dataTable);
                }
            }
        }

        private DataTable ReadExcelFile(string filePath)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;";

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            DataTable dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string sheetName = dt.Rows[0]["TABLE_NAME"].ToString();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + sheetName + "]", connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //Display in DatagridView
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No Members in the uploaded Excel File");
                return dataTable = null;
            }
            else
            {
                dgvMembers.DataSource = dataTable;
            }

            connection.Close();

            return dataTable;
        }

        //Insert into Members table from Excel file
        private void InsertDataIntoSqlTable(DataTable dataTable)
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            List<Member> members = new List<Member>();
            members = db.Members.ToList();
            try
            {
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO dbo.Members ([SAIMC_Nr],[Invoice_Type],[Members_Rating],[Branch],[Title],[Initial],[Nickname],[Surname],[E_Mail],[MobilePhone],[ECSA],[Paid],[Balance],[Haspaid]) VALUES (@SAIMC_Nr, @Invoice_Type, @Members_Rating,@Branch,@Title,@Initial,@Nickname,@Surname,@EMail,@MobilePhone,@ECSA,@Paid,@Balance,@HasPaid)", connection);

                        //Search Db to ignore exsisting Members
                        Member FoundMember = members.Find(x => x.SAIMC_Nr == Convert.ToInt16(row["SAIMC Nr"]));
                        if (FoundMember == null)
                        {
                            command.Parameters.AddWithValue("@SAIMC_Nr", row["SAIMC Nr"].ToString());
                            command.Parameters.AddWithValue("@Invoice_Type", row["Invoice Type"].ToString());
                            command.Parameters.AddWithValue("@Members_Rating", row["Members Rating"].ToString());
                            command.Parameters.AddWithValue("@Branch", row["Branch"].ToString());
                            command.Parameters.AddWithValue("@Title", row["Title"].ToString());
                            command.Parameters.AddWithValue("@Initial", row["Initial"].ToString());
                            command.Parameters.AddWithValue("@Nickname", row["Nickname"].ToString());
                            command.Parameters.AddWithValue("@Surname", row["Surname"].ToString());
                            command.Parameters.AddWithValue("@EMail", row["E-Mail"].ToString());
                            command.Parameters.AddWithValue("@MobilePhone", row["MobilePhone"].ToString());
                            command.Parameters.AddWithValue("@ECSA", row["ECSA"].ToString());
                            command.Parameters.AddWithValue("@Paid", row["Paid"].ToString());
                            command.Parameters.AddWithValue("@Balance", row["Balance"].ToString());
                            if (Convert.ToChar(row["HasPaid"]) == 'Y' || Convert.ToChar(row["HasPaid"]) == 'y')
                            {
                                command.Parameters.AddWithValue("@HasPaid", 1);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@HasPaid", 0);
                            }
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            //Run Update Query
                            string updateSql = "UPDATE [dbo].[Members] SET [SAIMC_Nr] = @SAIMC_Nr,[Invoice_Type] = @Invoice_Type,[Members_Rating] = @Members_Rating,[Branch] = @Branch,[Title] = @Title,[Initial] = @Initial," +
                                "[Nickname] = @Nickname,[Surname] = @Surname," +
                                "[E_Mail] = @EMail ,[MobilePhone] = @MobilePhone,[ECSA] = @ECSA," +
                                "[Paid] = @Paid,[Balance] = @Balance,[Haspaid] = @HasPaid" + " " +
                                "WHERE[SAIMC Nr] = @SAIMC_Nr";

                            using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@SAIMC_Nr", row["SAIMC Nr"].ToString());
                                updateCommand.Parameters.AddWithValue("@Invoice_Type", row["Invoice Type"].ToString());
                                updateCommand.Parameters.AddWithValue("@Members_Rating", row["Members Rating"].ToString());
                                updateCommand.Parameters.AddWithValue("@Branch", row["Branch"].ToString());
                                updateCommand.Parameters.AddWithValue("@Title", row["Title"].ToString());
                                updateCommand.Parameters.AddWithValue("@Initial", row["Initial"].ToString());
                                updateCommand.Parameters.AddWithValue("@Nickname", row["Nickname"].ToString());
                                updateCommand.Parameters.AddWithValue("@Surname", row["Surname"].ToString());
                                updateCommand.Parameters.AddWithValue("@EMail", row["E-Mail"].ToString());
                                updateCommand.Parameters.AddWithValue("@MobilePhone", row["MobilePhone"].ToString());
                                updateCommand.Parameters.AddWithValue("@ECSA", row["ECSA"].ToString());
                                updateCommand.Parameters.AddWithValue("@Paid", row["Paid"].ToString());
                                updateCommand.Parameters.AddWithValue("@Balance", row["Balance"].ToString());
                                if (Convert.ToChar(row["HasPaid"]) == 'Y' || Convert.ToChar(row["HasPaid"]) == 'y')
                                {
                                    updateCommand.Parameters.AddWithValue("@HasPaid", 1);
                                }
                                else
                                {
                                    updateCommand.Parameters.AddWithValue("@HasPaid", 0);
                                }
                                updateCommand.ExecuteNonQuery();
                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                Console.WriteLine("Rows affected: " + rowsAffected);
                            }
                        }
                    }
                }
                connection.Close();
                string message = "Members List has successfully been updated";
                string title = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    frmAdmin ViewAdminForm = new frmAdmin();
                    this.Hide();
                    ViewAdminForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("This Excel File does not match the data Setup of the SQL Members Table");
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                frmAdmin ViewAdminForm = new frmAdmin();
                this.Hide();
                ViewAdminForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open admin Form, Please contact Admin");
            }
        }

        private void frmUploadExcel_Load(object sender, EventArgs e)
        {
        }
    }
}
