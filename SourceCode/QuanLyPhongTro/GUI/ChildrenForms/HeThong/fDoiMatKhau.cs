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
                this.ep.SetError(this.txt_matKhauCu, "Mật khẩu cũ không khớp !");
            }
            else
            {
                this.ep.Clear();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            bool state = true;

            if (String.IsNullOrWhiteSpace(this.txt_matKhauCu.Text))
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ !",
                    "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.txt_matKhauCu.Focus();
                state = false;
            }
            else
                if (String.IsNullOrWhiteSpace(this.txt_matKhauMoi.Text))
                {
                    XtraMessageBox.Show("Chưa nhập mật khẩu mới !",
                    "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.txt_matKhauMoi.Focus();
                    state = false;
                }
                else
                    if (this.txt_matKhauCu.Text != this.nguoiDung.MatKhau)
                    {
                        XtraMessageBox.Show("Mật khẩu cũ không khớp !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.txt_matKhauCu.Focus();
                        this.txt_matKhauCu.SelectAll();
                        state = false;
                    }


            if (state == true)
            {
                nguoiDung.MatKhau = this.txt_matKhauMoi.Text;


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
}