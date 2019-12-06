using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOAIPHONG
    {
        string _maLoaiPhong;
        string _tenLoaiPhong;
        int _giaPhong;

        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }

        public string TenLoaiPhong
        {
            get { return _tenLoaiPhong; }
            set { _tenLoaiPhong = value; }
        }

        public int GiaPhong
        {
            get { return _giaPhong; }
            set { _giaPhong = value; }
        }
    }
}
