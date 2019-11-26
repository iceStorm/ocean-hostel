using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DICHVU
    {
        string _maDichVu;
        string _tenDichVu;
        int _giaDichVu;
        string _batBuoc;

        public string BatBuoc
        {
            get { return _batBuoc; }
            set { _batBuoc = value; }
        }

        public string MaDichVu
        {
            get { return _maDichVu; }
            set { _maDichVu = value; }
        }

        public string TenDichVu
        {
            get { return _tenDichVu; }
            set { _tenDichVu = value; }
        }

        public int GiaDichVu
        {
            get { return _giaDichVu; }
            set { _giaDichVu = value; }
        }
    }
}
