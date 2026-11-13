using Microsoft.Data.SqlClient;
using System.Data;
using TrainingItDiv2023.Interface;

namespace TrainingItDiv2023.Class
{
    public sealed class GetterDataUsers
    {
        public static List<IUser> GetData()
        {
            var cmdText = "SELECT * FROM Users";
            var connectionString = "Server = .; Database = TrainingItDiv2023; Trusted_Connection = True; TrustServerCertificate = True;";
            
            var connection = new SqlConnection(connectionString);
            var commandSql = new SqlCommand(cmdText, connection) { CommandType = CommandType.Text };

            connection.Open();

            var readerDataSql = commandSql.ExecuteReader();

            ListerDataUsers.GetList(readerDataSql, out var list);

            readerDataSql.Close();
            commandSql.Dispose();
            connection.Dispose();

            return list;
        }
    }
}