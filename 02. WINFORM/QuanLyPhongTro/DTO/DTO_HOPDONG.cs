using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOPDONG
    {
        string _maHopDong;
        string _maPhong;
        int _thoiHan;
        DateTime _thoiGianTao;
        string _trangThai;
        int _tienCoc;
        string _daTraCoc;

        public string MaHopDong
        {
            get { return _maHopDong; }
            set { _maHopDong = value; }
        }

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        public int ThoiHan
        {
            get { return _thoiHan; }
            set { _thoiHan = value; }
        }

        public DateTime ThoiGianTao
        {
            get { return _thoiGianTao; }
            set { _thoiGianTao = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public int TienCoc
        {
            get { return _tienCoc; }
            set { _tienCoc = value; }
        }

        public string DaTraCoc
        {
            get { return _daTraCoc; }
            set { _daTraCoc = value; }
        }
    }
}
