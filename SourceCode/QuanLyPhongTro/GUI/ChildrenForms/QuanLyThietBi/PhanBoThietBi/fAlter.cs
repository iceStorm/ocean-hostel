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

        public fAlter(DTO_THIETBI_PHONG thietBiPhong)
        {
            InitializeComponent();
            this.thietBiPhong = thietBiPhong;
            LoadTenThietBi();
        }

        private void LoadTenThietBi()
        {
            this.cb_tenThietBi.Items.AddRange(BLL_THIETBI.LayDanhSachTenThietBiConTon());
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}