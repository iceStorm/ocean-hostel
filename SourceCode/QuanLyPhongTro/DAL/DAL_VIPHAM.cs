using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_VIPHAM:DataProvider
    {
        public static DataTable LayDanhSachNoiQuy()
        {
            string query = @"SELECT * FROM VIPHAM";
            return ExecuteQuery(query);
        }

        public static int ThemViPham(DTO_VIPHAM viPham)
        {
            string query = @"EXEC PROC__VIPHAM__INSERT
                             @NOIDUNG = @@NOIDUNG ,
                             @HINHPHAT = @@HINHPHAT";

            object[] obj = new object[]
            {
                viPham.NoiDung,
                viPham.HinhPhat
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int XoaViPham(DTO_VIPHAM viPham)
        {
            string query = @"EXEC PROC__VIPHAM__DELETE @MAVIPHAM = @@MAVIPHAM";
            return ExecuteNonQuery(query, new object[]{viPham.MaViPham});
        }

        public static int SuaViPham(DTO_VIPHAM viPham)
        {
            string query = @"EXEC PROC__VIPHAM__UPDATE
                             @MAVIPHAM = @@MAVIPHAM ,
                             @NOIDUNG = @@NOIDUNG ,
                             @HINHPHAT = @@HINHPHAT";

            object[] obj = new object[]
            {
                viPham.MaViPham,
                viPham.NoiDung,
                viPham.HinhPhat
            };

            return ExecuteNonQuery(query, obj);
        }

    }
}
