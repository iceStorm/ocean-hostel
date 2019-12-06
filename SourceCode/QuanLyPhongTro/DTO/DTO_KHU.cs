using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHU
    {
        string _maKhu;
        string _tenKhu;

        public string MaKhu
        {
            get { return _maKhu; }
            set { _maKhu = value; }
        }
        
        public string TenKhu
        {
            get { return _tenKhu; }
            set { _tenKhu = value; }
        }
    }
}
