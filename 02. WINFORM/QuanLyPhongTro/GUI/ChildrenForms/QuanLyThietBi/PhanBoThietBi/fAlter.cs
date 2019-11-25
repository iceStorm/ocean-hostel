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

namespace GUI.ChildrenForms.QuanLyThietBi.PhanBoThietBi
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        DTO_THIETBI_PHONG thietBiPhong;
        bool isAdd = false;

        public fAlter(DTO_THIETBI_PHONG thietBiPhong, bool isAdd)
        {
            InitializeComponent();
            this.thietBiPhong = thietBiPhong;
            this.isAdd = isAdd;


            if (isAdd == false)   //  Sửa
            {
                this.Text = "Sửa thông tin thiết bị trong phòng";
                this.btn_them.Text = "Lưu";
                this.label1.Text = "Tình trạng";

                this.txt_tenThietbi.Text = thietBiPhong.TenThietBi;
                this.txt_ngayCap.Text = thietBiPhong.NgayCap.Date.ToShortDateString() + " — " + thietBiPhong.NgayCap.ToShortTimeString();
                LoadTrangThai();
            }
            else
            {
                this.label4.Visible = false;
                this.label2.Visible = false;
                this.txt_tenThietbi.Visible = false;
                this.txt_ngayCap.Visible = false;

                this.label1.Location = new Point(60, 26);
                this.cb_tenThietBi.Location = new Point(197, 25);
                this.btn_them.Location = new Point(64, 118);
                this.btn_huy.Location = new Point(269, 114);

                this.Height = 221;
                LoadTenThietBi();
            }
        }

        private void LoadTenThietBi()
        {
            this.cb_tenThietBi.Items.AddRange(BLL_THIETBI.LayDanhSachTenThietBi());
        }

        private void LoadTrangThai()
        {
            this.cb_tenThietBi.Items.AddRange(new object[]{"Bình thường", "Hư hỏng"});
            this.cb_tenThietBi.SelectedItem = this.thietBiPhong.TrangThai;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd == true)  //  Thêm
                {
                    DTO_THIETBI thietBi = new DTO_THIETBI();
                    thietBi.TenThietBi = this.cb_tenThietBi.Text;
                    thietBi.MaThietBi = BLL_THIETBI.LayMaThietBiTheoTenThietBi(thietBi);


                    this.thietBiPhong.MaThietBi = thietBi.MaThietBi;


                    if (BLL_THIETBI_PHONG.ThemThietBiPhong(this.thietBiPhong) == true)
                    {
                        XtraMessageBox.Show("Thêm thiết bị vào phòng thành công !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyThietBi.PhanBoThietBi.fPhanBoThietBi.isAdded = true;
                        this.Close();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}