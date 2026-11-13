using Microsoft.Data.SqlClient;
using TrainingItDiv2023.Interface;

namespace TrainingItDiv2023.Class
{
    public sealed class ListerDataUsers
    {
        public static void GetList(SqlDataReader readerDataSql, out List<IUser> list)
        {
            list = [];

            while (readerDataSql.Read())
            {
                var name = readerDataSql.GetString(i: 0);
                var age = readerDataSql.GetInt32(i: 1);

                list.Add(item: new User(name, age));
            }
        }
    }
}