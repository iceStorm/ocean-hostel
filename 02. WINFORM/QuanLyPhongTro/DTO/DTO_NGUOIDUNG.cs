﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NGUOIDUNG
    {
        string _tenDangNhap;
        string _matKhau;
        string _ho;
        string _ten;
        DateTime _dangNhapLanCuoi;
        string _trangThai;

        public DateTime DangNhapLanCuoi
        {
            get { return _dangNhapLanCuoi; }
            set { _dangNhapLanCuoi = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        public string Ho
        {
            get { return _ho; }
            set { _ho = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
    }
}