using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHACH
    {
        string _maKhach;
        string _ho;
        string _ten;
        string _gioiTinh;
        DateTime _ngaySinh;
        string _queQuan;
        string _soCanCuoc;
        string _soDienThoai;
        string _trangThai;

        public string MaKhach
        {
            get { return _maKhach; }
            set { _maKhach = value; }
        }

        public string Ho
        {
            get { return _ho; }
            set { _ho = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public string QueQuan
        {
            get { return _queQuan; }
            set { _queQuan = value; }
        }

        public string SoCanCuoc
        {
            get { return _soCanCuoc; }
            set { _soCanCuoc = value; }
        }

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }



    }
}
