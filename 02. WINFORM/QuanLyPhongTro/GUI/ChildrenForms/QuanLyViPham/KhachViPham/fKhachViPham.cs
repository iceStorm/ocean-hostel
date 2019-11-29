using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using DTO;

namespace GUI.ChildrenForms.QuanLyViPham.KhachViPham
{
    public partial class fKhachViPham : DevExpress.XtraEditors.XtraForm
    {
        public fKhachViPham()
        {
            InitializeComponent();
        }

        private void fKhachViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_KHACH_VIPHAM.LayDanhSachKhachViPham();

            if (dt.Rows.Count == 0)
            {
                this.btn_sua.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
            }
        }

    }
}