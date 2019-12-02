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
using DTO;
using BLL;

namespace GUI.ChildrenForms.HeThong
{
    public partial class fDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private DTO_NGUOIDUNG nguoiDung;
        private ErrorProvider ep;

        public fDoiMatKhau(DTO_NGUOIDUNG nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;

            this.ep = new ErrorProvider();
        }

        private void lb_hienMatKhauCu_MouseDown(object sender, MouseEventArgs e)
        {
            this.txt_matKhauCu.UseSystemPasswordChar = false;
            this.txt_matKhauCu.Focus();
        }

        private void lb_hienMatKhauCu_MouseUp(object sender, MouseEventArgs e)
        {
            this.txt_matKhauCu.UseSystemPasswordChar = true;
        }

        private void txt_matKhauMoi_MouseDown(object sender, MouseEventArgs e)
        {
            this.txt_matKhauMoi.UseSystemPasswordChar = false;
            this.txt_matKhauMoi.Focus();
        }

        private void txt_matKhauMoi_MouseUp(object sender, MouseEventArgs e)
        {
            this.txt_matKhauMoi.UseSystemPasswordChar = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.txt_matKhauCu.LostFocus += txt_matKhauCu_LostFocus;
        }

        private void txt_matKhauCu_LostFocus(object sender, EventArgs e)
        {
            if (this.txt_matKhauCu.Text != this.nguoiDung.MatKhau)
            {
                this.ep.Clear();
                this.ep.SetError(this.lb_hienMatKhauCu, "Mật khẩu cũ không khớp !");
            }
        }

    }
}