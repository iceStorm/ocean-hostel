using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DICHVU_PHONG
    {
        string _maDichVu;
        string _maPhong;
        string _tenDichVu;
        DateTime _ngayDangKy;

        public string TenDichVu
        {
            get { return _tenDichVu; }
            set { _tenDichVu = value; }
        }

        public DateTime NgayDangKy
        {
            get { return _ngayDangKy; }
            set { _ngayDangKy = value; }
        }

        public string MaDichVu
        {
            get { return _maDichVu; }
            set { _maDichVu = value; }
        }

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
    }
}
