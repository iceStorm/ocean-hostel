using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_DICHVU:DataProvider
    {
        public static DataTable LayThongTinDichVuTheoMaDichVu(DTO_DICHVU dichVu)
        {
            string query = @"SELECT * FROM DICHVU WHERE MADICHVU = @@MADVU";
            return ExecuteQuery(query, new object[] { dichVu.MaDichVu });
        }

        public static DataTable LayDanhSachDichVu()
        {
            string query = @"SELECT * FROM DICHVU";
            return ExecuteQuery(query);
        }

        public static DataTable LayThongTinDienNuoc()
        {
            string query = @"EXEC PROC__DICHVU__LayThongTinDienNuoc";
            return ExecuteQuery(query);
        }

        public static int ThemDichVu(DTO_DICHVU dichVu)
        {
            string query = @"EXEC PROC__DICHVU__INSERT
                             @TENDICHVU = @@TENDICHVU ,
                             @GIADICHVU = @@GIADICHVU ,
                             @BATBUOC = @@BATBUOC";

            object[] obj = new object[]
            {
                dichVu.TenDichVu, 
                dichVu.GiaDichVu,
                dichVu.BatBuoc
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int SuaDichVu(DTO_DICHVU dichVu)
        {
            string query = @"EXEC PROC__DICHVU__UPDATE
                             @MADICHVU = @@MADICHVU ,
                             @TENDICHVU = @@TENDICHVU ,
                             @GIADICHVU = @@GIADICHVU ,
                             @BATBUOC = @@BATBUOC";

            object[] obj = new object[]
            {
                dichVu.MaDichVu,
                dichVu.TenDichVu, 
                dichVu.GiaDichVu,
                dichVu.BatBuoc
            };

            return ExecuteNonQuery(query, obj);
        }

        public static int XoaDichVu(DTO_DICHVU dichVu)
        {
            string query = @"EXEC PROC__DICHVU__DELETE
                             @MADICHVU = @@MADICHVU";

            return ExecuteNonQuery(query, new object[] { dichVu.MaDichVu });
        }

        
        public static object DichVuDaDuocThamChieu(DTO_DICHVU dichVu)
        {
            string query = @"EXEC PROC__DICHVU__IsReferenced @MADICHVU = @@MADVU";
            return ExecuteScalar(query, new object[] { dichVu.MaDichVu });
        }

    }
}
