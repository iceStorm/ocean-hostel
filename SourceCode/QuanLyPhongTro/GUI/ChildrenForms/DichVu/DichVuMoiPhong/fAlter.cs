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

namespace GUI.ChildrenForms.DichVu.DichVuMoiPhong
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private DTO_DICHVU_PHONG dichVuPhong;

        public fAlter(DTO_DICHVU_PHONG dichVuPhong)
        {
            InitializeComponent();
            this.dichVuPhong = dichVuPhong;
        }

        private void fAlter_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }


        private void LoadDichVu()
        {
            this.cb_tenDichVu.Items.AddRange(BLL_DICHVU_PHONG.LayDanhSachTenDichVu_ChuaDangKy(this.dichVuPhong));
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_DICHVU dichVu = new DTO_DICHVU();
            dichVu.TenDichVu = this.cb_tenDichVu.Text;
            dichVu.MaDichVu = BLL_DICHVU.LayMaDichVuTheoTenDichVu(dichVu);

            this.dichVuPhong.MaDichVu = dichVu.MaDichVu;


            try
            {
                if (BLL_DICHVU_PHONG.ThemDichVuPhong(this.dichVuPhong) == true)
                {
                    XtraMessageBox.Show("Đăng ký dịch vụ cho phòng thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChildrenForms.DichVu.DichVuMoiPhong.fDichVuMoiPhong.isAdded = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_tenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_DICHVU dichVu = new DTO_DICHVU();
            dichVu.TenDichVu = this.cb_tenDichVu.Text;
            dichVu.MaDichVu = BLL_DICHVU.LayMaDichVuTheoTenDichVu(dichVu);
            dichVu = BLL_DICHVU.LayThongTinDichVuTheoMaDichVu(dichVu);

            if (dichVu != null)
            {
                this.txt_giaDichVu.Text = dichVu.GiaDichVu.ToString();

                if (dichVu.BatBuoc == "True")
                    this.chb_batBuoc.Value = true;
                else
                    this.chb_batBuoc.Value = false;
            }
        }

    }
}