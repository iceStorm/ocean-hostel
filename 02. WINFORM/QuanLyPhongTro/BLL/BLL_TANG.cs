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
    public class BLL_TANG
    {
        public static DataTable LayDanhSachTang()
        {
            return DAL_TANG.LayDanhSachTang();
        }

        public static bool ThemTang(DTO_TANG Tang)
        {
            return DAL_TANG.ThemTang(Tang) == 1;
        }

        public static string LayTenTangTiepTheo(DTO_TANG tang)
        {
            return DAL_TANG.LayTenTangTiepTheo(tang).ToString();
        }
        /*
        public static bool CapNhatTang(DTO_TANG Tang)
        {
            return DAL_TANG.CapNhatTang(Tang) == 1;
        }*/

        public static bool XoaTang(DTO_TANG Tang)
        {
            return DAL_TANG.XoaTang(Tang) == 1;
        }

        public static bool TangDaDuocThamChieu(DTO_TANG Tang) //  Kiểm tra liệu Tang có được tham chiếu ở bảng khác hay không
        {
            return DAL_TANG.TangDaDuocThamChieu(Tang).Rows.Count > 0;
        }
    }
}
