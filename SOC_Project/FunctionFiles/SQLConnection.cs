using System.Data;
using System.Data.SqlClient;
namespace SOC_Project.FunctionFiles
{

    public class SQLConnection
    {
      
        public static string connURL = "Data Source=.,1433;Initial Catalog=SOC_TrainfDB;Persist Security Info=True;User ID=sa;Password=Icbt@123;Max Pool Size=99999;Pooling=true;Connection Timeout=30;";
        public static bool ExecuteWriteCommand(string sqlQuery, SqlParameter[] sqlParameters)     
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connURL))
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection))
                {
                    int rowAffected = 0;

                    sqlCommand.Parameters.AddRange(sqlParameters);
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
