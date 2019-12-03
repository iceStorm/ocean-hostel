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
        private static string myConnStr = @"Data Source=.\sqlexpress;
                                            Initial Catalog=OCEAN_HOSTEL;
                                            Integrated Security=True";

        private static SqlConnection connection = new SqlConnection(myConnStr);


        private static SqlParameter[] GetParamsList(string query, object[] parameters)
        {
            List<SqlParameter> result = new List<SqlParameter>();
            List<string> segments = query.Split(' ').ToList<string>();

            int countParams = 0;
            foreach (string segment in segments)
                if (segment.Contains("@@")) //  Đây là một parameter trong chuỗi query
                {
                    SqlParameter sp = new SqlParameter
                    {
                        ParameterName = segment,
                        Value = parameters[countParams++]
                    };

                    result.Add(sp);
                }

            return result.ToArray();
        }


        protected static DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            SqlCommand command = new SqlCommand(query, connection);

            if (parameters != null)
                command.Parameters.AddRange(GetParamsList(query, parameters));

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }


        protected static int ExecuteNonQuery(string query, object[] parameters = null)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand command = new SqlCommand(query, connection);


            if (parameters != null)
                command.Parameters.AddRange(GetParamsList(query, parameters));

			int result = command.ExecuteNonQuery();
			

			if (connection.State == ConnectionState.Open)
				connection.Close();
			
            return result;
        }

        protected static object ExecuteScalar(string query, object[] parameters = null)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand command = new SqlCommand(query, connection);


            if (parameters != null)
                command.Parameters.AddRange(GetParamsList(query, parameters));

            object result = command.ExecuteScalar();


            if (connection.State == ConnectionState.Open)
                connection.Close();

            return result;
        }
    }
}
