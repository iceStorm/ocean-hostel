﻿using System;
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
