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
        string _dangSuaChua;
        string _tenKhu;
        string _tenTang;
        string _tenLoaiPhong;

        public string TenLoaiPhong
        {
            get { return _tenLoaiPhong; }
            set { _tenLoaiPhong = value; }
        }

        public string TenKhu
        {
            get { return _tenKhu; }
            set { _tenKhu = value; }
        }

        public string TenTang
        {
            get { return _tenTang; }
            set { _tenTang = value; }
        }

        public string DangSuaChua
        {
            get { return _dangSuaChua; }
            set { _dangSuaChua = value; }
        }

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
