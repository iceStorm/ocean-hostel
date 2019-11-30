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
            string query = @"EXEC PROC__KHACH__GetList";
            return ExecuteQuery(query);
        }

        public static object LayMaKhachTiepTheo()
        {
            string query = @"SELECT dbo.FUNC__KHACH__GetNextID()";
            return ExecuteScalar(query);
        }

        public static DataTable LayDanhSachKhachTheoMaPhong(DTO_PHONG phong)
        {
            string query = @"";

            return ExecuteQuery(query, new object[]{phong.MaPhong});
        }

        public static int ThemKhach(DTO_KHACH khachTro)
        {
            string query = @"EXEC PROC__KHACH__INSERT
                             @MAKHACH = @@MAKH ,
                             @HO = @@HO ,
                             @TEN = @@TEN ,
                             @GIOITINH = @@GT ,
                             @NGAYSINH = @@NS ,
                             @QUEQUAN = @@QQ ,
                             @SOCANCUOC = @@SCC ,
                             @SODIENTHOAI = @@SDT";

            object[] obj = new object[]
            {
                khachTro.MaKhach,
                khachTro.Ho,
                khachTro.Ten,
                khachTro.GioiTinh,
                khachTro.NgaySinh,
                khachTro.QueQuan,
                khachTro.SoCanCuoc,
                khachTro.SoDienThoai
            };

            return ExecuteNonQuery(query, obj);
        }

        public static object SoCanCuocDaTonTai(DTO_KHACH khachTro)
        {
            string query = @"EXEC PROC__KHACH__TonTaiSoCanCuoc @SOCANCUOC = @@SCC";
            return ExecuteScalar(query, new object[]{khachTro.SoCanCuoc});
        }

    }
}
