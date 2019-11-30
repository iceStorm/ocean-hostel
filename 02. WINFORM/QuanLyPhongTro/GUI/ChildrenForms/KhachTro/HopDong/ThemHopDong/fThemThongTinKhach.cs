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

namespace GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong
{
    public partial class fThemThongTinKhach : DevExpress.XtraEditors.XtraForm
    {
        private DTO_KHACH khachTro;

        public fThemThongTinKhach(DTO_KHACH khachTro = null)
        {
            InitializeComponent();
            this.khachTro = khachTro;

            if (khachTro != null)
            {
                this.Text = "Sửa thông tin khách trọ";
                this.btn_them.Text = "Lưu";

                this.txt_ho.Text = khachTro.Ho;
                this.txt_ten.Text = khachTro.Ten;
                this.cb_gioiTinh.SelectedItem = khachTro.GioiTinh;
                this.dtp_ngaySinh.Value = khachTro.NgaySinh;
                this.txt_queQuan.Text = khachTro.QueQuan;
                this.txt_soCanCuoc.Text = khachTro.SoCanCuoc;
                this.txt_soDienThoai.Text = khachTro.SoDienThoai;
            }
        }

        private void NumberTextBoxes_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == true)
                return;

            if (Char.IsNumber(e.KeyChar) == false)  //  Chặn ký tự không phải số
                e.Handled = true;
        }

        private void LetterTextBoxes_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) == true)
                return;

            switch (e.KeyChar)
            {
                case (char)32:
                    return;
            }

            if (Char.IsLetter(e.KeyChar) == false)  //  Chặn ký tự không phải số
                e.Handled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckBeforeAdd() == true)
            {
                if (this.khachTro != null)  //  Sửa
                {
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.Ho = this.txt_ho.Text;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.Ten = this.txt_ten.Text;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.NgaySinh = this.dtp_ngaySinh.Value;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.GioiTinh = this.cb_gioiTinh.Text;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.QueQuan = this.txt_queQuan.Text;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.SoCanCuoc = this.txt_soCanCuoc.Text;
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro.SoDienThoai = this.txt_soDienThoai.Text;
                }
                else                        //  Thêm
                {
                    ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro = new DTO.DTO_KHACH
                    {
                        Ho = this.txt_ho.Text,
                        Ten = this.txt_ten.Text,
                        NgaySinh = this.dtp_ngaySinh.Value,
                        GioiTinh = this.cb_gioiTinh.Text,
                        QueQuan = this.txt_queQuan.Text,
                        SoCanCuoc = this.txt_soCanCuoc.Text,
                        SoDienThoai = this.txt_soDienThoai.Text
                    };
                }

                this.Close();
            }
        }

        private bool CheckBeforeAdd()
        {
            bool state  = true; //  829

            if (String.IsNullOrWhiteSpace(this.txt_ho.Text))
            {
                XtraMessageBox.Show("Chưa nhập họ !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.txt_ho.Focus();
                state = false;
            }
            else
                if (String.IsNullOrWhiteSpace(this.txt_ten.Text))
                {
                    XtraMessageBox.Show("Chưa nhập họ !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.txt_ten.Focus();
                    state = false;
                }
                else
                    if (this.cb_gioiTinh.SelectedIndex == -1)
                    {
                        XtraMessageBox.Show("Chưa chọn giới tính !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.cb_gioiTinh.DroppedDown = true;
                        state = false;
                    }
                    else
                        if (String.IsNullOrWhiteSpace(this.txt_queQuan.Text))
                        {
                            XtraMessageBox.Show("Chưa nhập quê quán !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.txt_queQuan.Focus();
                            state = false;
                        }
                        else
                            if (String.IsNullOrWhiteSpace(this.txt_soCanCuoc.Text))
                            {
                                XtraMessageBox.Show("Chưa nhập số căn cước !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                this.txt_soCanCuoc.Focus();
                                state = false;
                            }

            return state;
        }

    }
}