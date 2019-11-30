﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_KHACH
    {
        public static DataTable LayDanhSachKhach()
        {
            return DAL_KHACH.LayDanhSachKhach();
        }

        public static string LayMaKhachTiepTheo()
        {
            return (string)DAL_KHACH.LayMaKhachTiepTheo();
        }

        public static bool ThemKhach(DTO_KHACH khachTro)
        {
            return DAL_KHACH.ThemKhach(khachTro) == 1;
        }

        public static bool SoCanCuocDaTonTai(DTO_KHACH khachTro)
        {
            return (int)DAL_KHACH.SoCanCuocDaTonTai(khachTro) == 1;
        }

    }
}
