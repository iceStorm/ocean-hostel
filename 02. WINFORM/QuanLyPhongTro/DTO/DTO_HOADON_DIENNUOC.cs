using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOADON_DIENNUOC
    {
        string _maHoaDon;
        int _soDien;
        int _soNuoc;
        int _giaDien;
        int _giaNuoc;

        public string MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }

        public int SoDien
        {
            get { return _soDien; }
            set { _soDien = value; }
        }

        public int SoNuoc
        {
            get { return _soNuoc; }
            set { _soNuoc = value; }
        }

        public int GiaDien
        {
            get { return _giaDien; }
            set { _giaDien = value; }
        }

        public int GiaNuoc
        {
            get { return _giaNuoc; }
            set { _giaNuoc = value; }
        }


    }
}
