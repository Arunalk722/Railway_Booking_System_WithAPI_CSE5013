using System.Data;
using System.Data.SqlClient;
namespace SOC_Project.FunctionFiles
{

    public class SQLConnection
    {
        private static IConfiguration _configuration;
        public static void SetConfiguration(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        public static string connURL = "Data Source=192.168.50.23,8984;Initial Catalog=SOC_TrainfDB;Persist Security Info=True;User ID=sa;Password=T32NBQDBA23;Max Pool Size=99999;Pooling=true;Connection Timeout=30;";
        public static bool PrmWrite(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connURL.ToString()))
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    int rowAffected = 0;

                    sqlCommand.Parameters.AddRange(parameters);
                    connection.Open();
                    rowAffected = sqlCommand.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                LogToText.ExceptionLog(ex);
                return false;
            }
         
        }
        public static SqlDataReader PrmRead(string query, SqlParameter[] parameters)
        {
            try
            {
                string connection = connURL.ToString();
                SqlConnection sqlConnection = new SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex) { 
                LogToText.ExceptionLog(ex);
                return null;
            }
        }
    }
}
