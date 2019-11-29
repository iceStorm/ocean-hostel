using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOADON_DICHVU
    {
        string _maHoaDon;
        string _maDichVu;
        string _tenDichVu;
        int _giaDichVu;

        public string MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }

        public string MaDichVu
        {
            get { return _maDichVu; }
            set { _maDichVu = value; }
        }

        public string TenDichVu
        {
            get { return _tenDichVu; }
            set { _tenDichVu = value; }
        }

        public int GiaDichVu
        {
            get { return _giaDichVu; }
            set { _giaDichVu = value; }
        }


    }
}
