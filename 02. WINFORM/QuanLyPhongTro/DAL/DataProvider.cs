using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static string myConnStr = @"Data Source=azure-sqlexpress.database.windows.net;
                                            Initial Catalog=ocean-motel;
                                            User ID=azure-admin";

        private static SqlConnection connection = new SqlConnection(myConnStr);

        public static string TestConnection()
        {
            return connection.State.ToString();
        }
    }
}
