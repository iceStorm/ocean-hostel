using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_KHACH:DataProvider
    {
        public static DataTable LayDanhSachKhach()
        {
            string query = @"SELECT * FROM KHACH";
            return ExecuteQuery(query);
        }
    }
}
