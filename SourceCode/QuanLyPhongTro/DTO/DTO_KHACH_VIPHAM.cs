using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_KHACH_VIPHAM
    {
        string _maViPham;
        string _maKhach;
        string _daXuLy;
        string _ghiChu;
        DateTime _thoiGianViPham;

        public string MaViPham
        {
            get { return _maViPham; }
            set { _maViPham = value; }
        }

        public string MaKhach
        {
            get { return _maKhach; }
            set { _maKhach = value; }
        }

        public DateTime ThoiGianViPham
        {
            get { return _thoiGianViPham; }
            set { _thoiGianViPham = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public string DaXuLy
        {
            get { return _daXuLy; }
            set { _daXuLy = value; }
        }

    }
}
