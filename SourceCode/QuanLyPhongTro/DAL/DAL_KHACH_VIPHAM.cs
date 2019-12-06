using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_KHACH_VIPHAM:DataProvider
    {
        public static DataTable LayDanhSachKhachViPham()
        {
            string query = @"EXEC PROC__KHACH_VIPHAM__GetList";
            return ExecuteQuery(query);
        }

        public static int ThemViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            string query = @"EXEC PROC__KHACH_VIPHAM__INSERT
                             @MAVIPHAM = @@MAVP ,
                             @MAKHACH = @@MAKH ,
                             @GHICHU = @@GHICHU";

            object[] obj = new object[]
            {
                khachViPham.MaViPham,
                khachViPham.MaKhach,
                khachViPham.GhiChu
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int XoaKhachViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            string query = @"EXEC PROC__KHACH_VIPHAM__DELETE
                             @MAVIPHAM = @@MAVP ,
                             @MAKHACH = @@MAKH ,
                             @THOIGIAN = @@THOIGIAN";

            object[] obj = new object[]
            {
                khachViPham.MaViPham,
                khachViPham.MaKhach,
                khachViPham.ThoiGianViPham
            };

            return ExecuteNonQuery(query, obj); 
        }

        public static int XuLyViPham(DTO_KHACH_VIPHAM khachViPham)
        {
            string query = @"EXEC PROC__KHACH_VIPHAM__UPDATE
                             @MAVIPHAM = @@MAVP ,
                             @MAKHACH = @@MAKH ,
                             @THOIGIAN = @@THOIGIAN@";

            object[] obj = new object[]
            {
                khachViPham.MaViPham,
                khachViPham.MaKhach,
                khachViPham.ThoiGianViPham
            };

            return ExecuteNonQuery(query, obj); 
        }

    }
}
