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
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        public fAlter()
        {
            InitializeComponent();
        }

        private void fAlter_Load(object sender, EventArgs e)
        {
            AssignComboBoxData();
        }

        private void AssignComboBoxData()
        {
            this.cb_tenPhong.DataSource = BLL_PHONG.LayDanhSachPhong();
            this.cb_tenPhong.DisplayMember = "TENPHG";
            this.cb_tenPhong.ValueMember = "MAPHG";
            this.cb_tenPhong.SelectedIndex = -1;

            this.cb_viPham.DataSource = BLL_VIPHAM.LayDanhSachNoiQuy();
            this.cb_viPham.DisplayMember = "NOIDUNG";
            this.cb_viPham.ValueMember = "MAVIPHAM";
            this.cb_viPham.SelectedIndex = -1;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRowView drv_khach = (DataRowView)this.cb_tenKhach.SelectedItem;
            DataRowView drv_viPham = (DataRowView)this.cb_viPham.SelectedItem;

            DTO_KHACH_VIPHAM khachViPham = new DTO_KHACH_VIPHAM
            {
                MaKhach = drv_khach.Row.ItemArray[1].ToString(),
                MaViPham = drv_viPham.Row.ItemArray[0].ToString(),
                GhiChu = this.txt_ghiChu.Text
            };

            try
            {
                if (BLL_KHACH_VIPHAM.ThemKhachViPham(khachViPham) == true)
                {
                    XtraMessageBox.Show("Thêm khách vi phạm thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChildrenForms.QuanLyViPham.KhachViPham.fKhachViPham.isAdded = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_tenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tenPhong.SelectedIndex >= 0)
            {
                DataRowView dv = (DataRowView)this.cb_tenPhong.SelectedItem;
                DTO_PHONG phong = new DTO_PHONG();
                //phong.MaPhong = this.cb_tenPhong.SelectedValue.ToString();
                phong.MaPhong = (string)dv.Row.ItemArray[4].ToString();

                this.cb_tenKhach.DataSource = BLL_KHACH.LayDanhSachKhachTheoMaPhong(phong);
                this.cb_tenKhach.DisplayMember = "HOTEN";
                this.cb_tenKhach.ValueMember = "MAKHACH";
                this.cb_tenKhach.SelectedIndex = -1;
            }
        }

    }
}