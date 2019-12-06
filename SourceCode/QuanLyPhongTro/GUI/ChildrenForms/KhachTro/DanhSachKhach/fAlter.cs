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

namespace GUI.ChildrenForms.KhachTro.DanhSachKhach
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private DTO_KHACH khachTro;

        public fAlter(DTO_KHACH khachTro)
        {
            InitializeComponent();
            this.khachTro = khachTro;


            if (khachTro != null)
            {
                if (khachTro.TrangThai == "Hết hợp đồng")
                {
                    this.cb_trangThai.Items.Add("Hết hợp đồng");
                    this.btn_them.Enabled = false;
                    this.cb_trangThai.Enabled = false;
                }


                this.Text = "Sửa thông tin khách trọ";
                this.btn_them.Text = "Lưu";

                this.txt_ho.Text = khachTro.Ho;
                this.txt_ten.Text = khachTro.Ten;
                this.cb_gioiTinh.SelectedItem = khachTro.GioiTinh;
                this.dtp_ngaySinh.Value = khachTro.NgaySinh;
                this.txt_queQuan.Text = khachTro.QueQuan;
                this.txt_soCanCuoc.Text = khachTro.SoCanCuoc;
                this.txt_soDienThoai.Text = khachTro.SoDienThoai;
                this.cb_trangThai.SelectedItem = khachTro.TrangThai;
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
                this.khachTro.Ho = this.txt_ho.Text;
                this.khachTro.Ten = this.txt_ten.Text;
                this.khachTro.NgaySinh = this.dtp_ngaySinh.Value;
                this.khachTro.GioiTinh = this.cb_gioiTinh.Text;
                this.khachTro.QueQuan = this.txt_queQuan.Text;
                this.khachTro.SoCanCuoc = this.txt_soCanCuoc.Text;
                this.khachTro.SoDienThoai = this.txt_soDienThoai.Text;
                this.khachTro.TrangThai = this.cb_trangThai.Text;

                try
                {
                    if (BLL_KHACH.CapNhatKhach(khachTro) == true)
                    {
                        XtraMessageBox.Show("Cập nhật thông tin thành công !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.KhachTro.DanhSachKhach.fKhach.isUpdated = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate"))
                    {
                        XtraMessageBox.Show("Trùng số căn cước !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.txt_soCanCuoc.Focus();
                        this.txt_soCanCuoc.SelectAll();
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool CheckBeforeAdd()
        {
            bool state = true; //  829

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

        private void fAlter_Load(object sender, EventArgs e)
        {

        }


    }
}