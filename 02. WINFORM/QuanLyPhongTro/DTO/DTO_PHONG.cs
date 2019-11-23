using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PHONG
    {
        string _maLoaiPhong;
        string _maTang;
        string _maPhong;
        string _tenPhong;
        int _soLuongToiDa;
        int _soLuongDangO;

        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }

        public string MaTang
        {
            get { return _maTang; }
            set { _maTang = value; }
        }

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public string TenPhong
        {
            get { return _tenPhong; }
            set { _tenPhong = value; }
        }

        public int SoLuongToiDa
        {
            get { return _soLuongToiDa; }
            set { _soLuongToiDa = value; }
        }

        public int SoLuongDangO
        {
            get { return _soLuongDangO; }
            set { _soLuongDangO = value; }
        }


    }
}
