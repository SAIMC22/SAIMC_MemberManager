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

                InsertDataIntoSqlTable(dataTable);
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
            dgvMembers.DataSource = dataTable;

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
                foreach (DataRow row in dataTable.Rows)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO dbo.Members ([SAIMC Nr],[Invoice Type],[Members Rating],[Branch],[Title],[Initial],[Nickname],[Surname],[E-Mail],[MobilePhone],[ECSA],[Paid],[Balance],[Haspaid],[MemberQRCode]) VALUES (@SAIMC_Nr, @Invoice_Type, @Members_Rating,@Branch,@Title,@Initial,@Nickname,@Surname,@EMail,@MobilePhone,@ECSA,@Paid,@Balance,NULL,NULL) ON DUPLICATE KEY UPDATE", connection);

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
                    command.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Data successfully inserted into SQL table.");
            }
            catch (Exception ex)
            {
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
    }
}
