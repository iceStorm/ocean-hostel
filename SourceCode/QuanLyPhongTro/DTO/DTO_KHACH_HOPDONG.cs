using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHACH_HOPDONG
    {
        string _maKhach;
        string _maHopDong;

        public string MaKhach
        {
            get { return _maKhach; }
            set { _maKhach = value; }
        }

        public string MaHopDong
        {
            get { return _maHopDong; }
            set { _maHopDong = value; }
        }
    }
}
