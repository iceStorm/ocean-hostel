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

namespace GUI.ChildrenForms.HeThong
{
    public partial class fXemThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private DTO_NGUOIDUNG nguoiDung;

        public fXemThongTinTaiKhoan(DTO_NGUOIDUNG nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;

            this.txt_tenDangNhap.Text = this.nguoiDung.TenDangNhap;
            this.txt_ho.Text = this.nguoiDung.Ho;
            this.txt_ten.Text = this.nguoiDung.Ten;
        }

        private void btn_oke_Click(object sender, EventArgs e)
        {
            this.nguoiDung.Ho = this.txt_ho.Text;
            this.nguoiDung.Ten = this.txt_ten.Text;
            this.nguoiDung.TenDangNhap = this.txt_tenDangNhap.Text;

            try
            {
                BLL_NGUOIDUNG.CapNhatTaiKhoan(nguoiDung);

                XtraMessageBox.Show("Vui lòng khởi động lại để cập nhật thay đổi !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}