using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_THIETBI
    {
        string _maThietBi;
        string _tenThietBi;
        DateTime _ngayNhap;
        int _soLuongPhanBo;
        int _giaThietBi;
        int _soLuongTon;

        public string MaThietBi
        {
            get { return _maThietBi; }
            set { _maThietBi = value; }
        }

        public string TenThietBi
        {
            get { return _tenThietBi; }
            set { _tenThietBi = value; }
        }

        public int GiaThietBi
        {
            get { return _giaThietBi; }
            set { _giaThietBi = value; }
        }

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public int SoLuongPhanBo
        {
            get { return _soLuongPhanBo; }
            set { _soLuongPhanBo = value; }
        }
    }
}
