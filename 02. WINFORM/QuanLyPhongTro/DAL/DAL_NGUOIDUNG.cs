using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NGUOIDUNG:DataProvider
    {
        public static DataTable GetAccountInfo_By_Credentials(DTO_NGUOIDUNG nguoiDung)
        {
            string query = @"SELECT *
                             FROM NGUOIDUNG
                             WHERE TENDN = @TENDN AND MATKHAU = @MATKHAU";

            return ExecuteQuery(query, new object[]{nguoiDung.TenDangNhap, nguoiDung.MatKhau});
        }


    }
}
