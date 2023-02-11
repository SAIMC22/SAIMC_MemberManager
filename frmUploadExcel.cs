using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAIMC_MemberManager
{
    public partial class frmUploadExcel : Form
    {
        public frmUploadExcel()
        {
            InitializeComponent();
        }

        private void btnUploadExcel_Click(object sender, System.EventArgs e)
        {

            // Connection strings for Excel and SQL
            string excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ExcelFile.xls;Extended Properties=""Excel 8.0;HDR=YES;""";
            string sqlConnectionString = @"Data Source=.;initial catalog=SAIMCDBV2;integrated security=True";

            // Load data from Excel into a DataTable
            DataTable excelData = LoadDataFromExcel(excelConnectionString);

            // Insert or update data in SQL table
            InsertOrUpdateDataInSQL(excelData, sqlConnectionString);
        }

        private static DataTable LoadDataFromExcel(string connectionString)
        {
            // Create an OleDbConnection object
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Get the data from the first worksheet
                string sheet1 = connection.GetSchema("Tables").Rows[0]["TABLE_NAME"].ToString();
                string query = "SELECT * FROM [" + sheet1 + "]";

                // Create an OleDbDataAdapter object
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    // Create a DataTable to store the data
                    DataTable data = new DataTable();

                    // Fill the DataTable with the data from the worksheet
                    adapter.Fill(data);

                    // Return the data
                    return data;
                }
            }
        }

        private static void InsertOrUpdateDataInSQL(DataTable data, string connectionString)
        {
            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand object for the INSERT statement
                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO[dbo].[Members] ([Invoice Type],[Members Rating],[Branch],[Title],[Initial],[Nickname],[Surname],[E - Mail],[MobilePhone],[ECSA],[Paid],[Balance],[Haspaid],[MemberQRCode]) VALUES (@SAIMC_Nr, @Invoice_Type, @Members_Rating,@Branch,@Title,@Initial,@Nickname,@Surname,@E-Mail,@MobilePhone,@ECSA,@Paid,@Balance)", connection))
                {
                    // Add parameters for the INSERT statement
                    insertCommand.Parameters.Add("@SAIMC_Nr", SqlDbType.Int, 0, "Column1");
                    insertCommand.Parameters.Add("@Invoice_Type", SqlDbType.NVarChar, 0, "Column2");
                    insertCommand.Parameters.Add("@Members_Rating", SqlDbType.NVarChar, 0, "Column3");
                    insertCommand.Parameters.Add("@Branch", SqlDbType.NVarChar, 0, "Column4");
                    insertCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 0, "Column5");
                    insertCommand.Parameters.Add("@Initial", SqlDbType.NVarChar, 0, "Column6");
                    insertCommand.Parameters.Add("@Nickname", SqlDbType.NVarChar, 0, "Column7");
                    insertCommand.Parameters.Add("@Surname", SqlDbType.NVarChar, 0, "Column8");
                    insertCommand.Parameters.Add("@E-Mail", SqlDbType.NVarChar, 0, "Column9");
                    insertCommand.Parameters.Add("@MobilePhone", SqlDbType.NVarChar, 0, "Column10");
                    insertCommand.Parameters.Add("@ECSA", SqlDbType.NVarChar, 0, "Column11");
                    insertCommand.Parameters.Add("@Paid", SqlDbType.NVarChar, 0, "Column12");
                    insertCommand.Parameters.Add("@Balance", SqlDbType.NVarChar, 0, "Column13");
                    /*
                                        // Create a SqlCommand object for the UPDATE statement
                                        using (SqlCommand updateCommand = new SqlCommand("UPDATE [Table] SET [Column2] = @Column2, [Column3] = @Column3 WHERE [Column1] = @Column1", connection))
                                        {
                                            // Add parameters for the UPDATE statement
                                            updateCommand.Parameters.Add("@Column1", Sql)*/
                }
            }
        }
    }
}
