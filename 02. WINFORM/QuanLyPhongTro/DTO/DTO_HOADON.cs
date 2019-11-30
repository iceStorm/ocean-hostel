using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOADON
    {
        string _maHoaDon;
        string _maPhong;
        string _tenPhong;
        int _thang;
        int _nam;
        int _tienPhong;
        string _daThanhToan;
        int _tienDien;
        int _tienNuoc;
        int _tienDichVu;
        int _tongTien;

        public int TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        public int TienDichVu
        {
            get { return _tienDichVu; }
            set { _tienDichVu = value; }
        }

        public int TienNuoc
        {
            get { return _tienNuoc; }
            set { _tienNuoc = value; }
        }

        public int TienDien
        {
            get { return _tienDien; }
            set { _tienDien = value; }
        }

        public string TenPhong
        {
            get { return _tenPhong; }
            set { _tenPhong = value; }
        }

        public string MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        public int TienPhong
        {
            get { return _tienPhong; }
            set { _tienPhong = value; }
        }

        public string DaThanhToan
        {
            get { return _daThanhToan; }
            set { _daThanhToan = value; }
        }
    }
}
