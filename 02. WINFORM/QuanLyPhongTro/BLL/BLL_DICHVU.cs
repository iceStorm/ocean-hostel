using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_DICHVU
    {
        public static DataTable LayDanhSachDichVu()
        {
            return DAL_DICHVU.LayDanhSachDichVu();
        }

        public static string[] LayDanhSachTenDichVu()
        {
            DataTable dt = LayDanhSachDichVu();
            List<string> result = new List<string>();

            foreach (DataRow dr in dt.Rows)
                result.Add((string)dr["TENDICHVU"]);

            return result.ToArray();
        }


        public static DataTable LayThongTinDienNuoc()
        {
            return DAL_DICHVU.LayThongTinDienNuoc();
        }

        public static DTO_DICHVU LayThongTinDichVuTheoMaDichVu(DTO_DICHVU dichVu)
        {
            DataTable dt = DAL_DICHVU.LayThongTinDichVuTheoMaDichVu(dichVu);

            if (dt.Rows.Count == 0)
                return null;

            DTO_DICHVU thongTinDichVu = new DTO_DICHVU
            {
                TenDichVu = (string)dt.Rows[0]["TENDICHVU"],
                MaDichVu = (string)dt.Rows[0]["MADICHVU"],
                BatBuoc = dt.Rows[0]["BATBUOC"].ToString(),
                GiaDichVu = (int)dt.Rows[0]["GIADICHVU"]
            };

            return thongTinDichVu;
        }

        public static string LayMaDichVuTheoTenDichVu(DTO_DICHVU dichVu)
        {
            DataTable dt = LayDanhSachDichVu();
            string maDichVu = "";

            foreach (DataRow dr in dt.Rows)
                if (dichVu.TenDichVu == (string)dr["TENDICHVU"])
                {
                    maDichVu = (string)dr["MADICHVU"];
                    break;
                }

            return maDichVu;
        }

        public static bool ThemDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.ThemDichVu(dichVu) == 1;
        }

        public static bool SuaDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.SuaDichVu(dichVu) == 1;
        }

        public static bool XoaDichVu(DTO_DICHVU dichVu)
        {
            return DAL_DICHVU.XoaDichVu(dichVu) == 1;
        }

        public static bool DichVuDaDuocThamChieu(DTO_DICHVU dichVu)
        {
            return (int)DAL_DICHVU.DichVuDaDuocThamChieu(dichVu) > 0;
        }

    }
}
