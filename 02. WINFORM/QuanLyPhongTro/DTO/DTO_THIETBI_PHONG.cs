using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_THIETBI_PHONG
    {
        string _maThietBi;
        string _maPhong;
        string _tenThietBi;
        DateTime _ngayCap;
        string _trangThai;

        public string TenThietBi
        {
            get { return _tenThietBi; }
            set { _tenThietBi = value; }
        }

        public DateTime NgayCap
        {
            get { return _ngayCap; }
            set { _ngayCap = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public string MaThietBi
        {
            get { return _maThietBi; }
            set { _maThietBi = value; }
        }

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
    }
}
