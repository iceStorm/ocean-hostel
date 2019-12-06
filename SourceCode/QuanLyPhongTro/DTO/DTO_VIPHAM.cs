using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_VIPHAM
    {
        string _maViPham;
        string _noiDung;
        string _hinhPhat;

        public string MaViPham
        {
            get { return _maViPham; }
            set { _maViPham = value; }
        }

        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }

        public string HinhPhat
        {
            get { return _hinhPhat; }
            set { _hinhPhat = value; }
        }
    }
}
