using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TANG
    {
        string _maTang;
        string _tenTang;
        string _maKhu;
        string _tenKhu;

        public string TenKhu
        {
            get { return _tenKhu; }
            set { _tenKhu = value; }
        }

        public string MaKhu
        {
            get { return _maKhu; }
            set { _maKhu = value; }
        }

        public string MaTang
        {
            get { return _maTang; }
            set { _maTang = value; }
        }

        public string TenTang
        {
            get { return _tenTang; }
            set { _tenTang = value; }
        }

    }
}
