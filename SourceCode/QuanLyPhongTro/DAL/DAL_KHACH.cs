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

        public static DataTable LayDanhSachKhachTheoMaPhong(DTO_PHONG phong)
        {
            string query = @"EXEC PROC__KHACH__GetListByRoomID @MAPHG = @@MAPHONG";

            return ExecuteQuery(query, new object[]{phong.MaPhong});
        }

        public static object LayMaKhachTiepTheo()
        {
            string query = @"SELECT dbo.FUNC__KHACH__GetNextID()";
            return ExecuteScalar(query);
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


        public static int XoaKhach(DTO_KHACH khach)
        {
            string query = @"EXEC PROC__KHACH__DELETE @MAKHACH = @@MAKH";
            return ExecuteNonQuery(query, new object[]{khach.MaKhach});
        }

        public static int CapNhatKhach(DTO_KHACH khachTro)
        {
            string query = @"EXEC PROC__KHACH__UPDATE
                             @MAKHACH = @@MAKH ,
                             @HO = @@HO ,
                             @TEN = @@TEN ,
                             @GIOITINH = @@GT ,
                             @NGAYSINH = @@NS ,
                             @QUEQUAN = @@QQ ,
                             @SOCANCUOC = @@SCC ,
                             @SODIENTHOAI = @@SDT ,
                             @TRANGTHAI = @@TT";

            object[] obj = new object[]
            {
                khachTro.MaKhach,
                khachTro.Ho,
                khachTro.Ten,
                khachTro.GioiTinh,
                khachTro.NgaySinh,
                khachTro.QueQuan,
                khachTro.SoCanCuoc,
                khachTro.SoDienThoai,
                khachTro.TrangThai
            };

            return ExecuteNonQuery(query, obj);
        }

    }
}
