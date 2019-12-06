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
    public class BLL_HOADON_DIENNUOC
    {
        public static DTO_HOADON_DIENNUOC LayThongTinThangHienTai(DTO_HOADON hoaDon)
        {
            DataTable dt = DAL_HOADON_DIENNUOC.LayThongTinDienNuocThangHienTai(hoaDon);
            DTO_HOADON_DIENNUOC hdn = new DTO_HOADON_DIENNUOC();


            if (dt.Rows.Count > 0)
            {
                hdn.MaHoaDon = (string)dt.Rows[0]["MAHOADON"];
                hdn.SoDien = (int)dt.Rows[0]["SODIEN"];
                hdn.SoNuoc = (int)dt.Rows[0]["SONUOC"];
                hdn.GiaDien = (int)dt.Rows[0]["GIADIEN"];
                hdn.GiaNuoc = (int)dt.Rows[0]["GIANUOC"];
            }
            else
            {
                hdn.SoDien = 0;
                hdn.SoNuoc = 0;
            }

            return hdn;
        }

        public static DTO_HOADON_DIENNUOC LayThongTinThangTruoc(DTO_HOADON hoaDon)
        {
            DataTable dt = DAL_HOADON_DIENNUOC.LayThongTinDienNuocThangTruoc(hoaDon);
            DTO_HOADON_DIENNUOC hdn = new DTO_HOADON_DIENNUOC();


            if (dt.Rows.Count > 0)
            {
                hdn.MaHoaDon = (string)dt.Rows[0]["MAHOADON"];
                hdn.SoDien = (int)dt.Rows[0]["SODIEN"];
                hdn.SoNuoc = (int)dt.Rows[0]["SONUOC"];
                hdn.GiaDien = (int)dt.Rows[0]["GIADIEN"];
                hdn.GiaNuoc = (int)dt.Rows[0]["GIANUOC"];
            }
            else
            {
                hdn.SoDien = 0;
                hdn.SoNuoc = 0;
            }

            return hdn;
        }

    }
}
