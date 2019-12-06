using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_NGUOIDUNG
    {
        public static DataTable GetAccountInfo_By_Credentials(DTO_NGUOIDUNG nguoiDung)
        {
            return DAL_NGUOIDUNG.GetAccountInfo_By_Credentials(nguoiDung);
        }

        public static bool CapNhatTaiKhoan(DTO_NGUOIDUNG nguoiDung)
        {
            return DAL_NGUOIDUNG.CapNhatThongTin(nguoiDung) > 0;
        }
    }
}
