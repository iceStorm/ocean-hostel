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
                             WHERE TENDN = @@TENDN 
                                AND MATKHAU = @@MATKHAU";

            return ExecuteQuery(query, new object[]{nguoiDung.TenDangNhap, nguoiDung.MatKhau});
        }

        public static int CapNhatThongTin(DTO_NGUOIDUNG nguoiDung)
        {
            string query = @"EXEC PROC__NGUOIDUNG__UPDATE
                             @TENDN = @@TDN ,
                             @MATKHAU = @@MK ,
                             @HO = @@HO ,
                             @TEN = @@TEN";

            object[] obj = new object[]
            {
                nguoiDung.TenDangNhap,
                nguoiDung.MatKhau,
                nguoiDung.Ho,
                nguoiDung.Ten
            };

            return ExecuteNonQuery(query, obj);
        }

    }
}
