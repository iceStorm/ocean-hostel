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
using MetroFramework.Controls;
using BLL;
using DTO;

namespace GUI.ChildrenForms.QuanLyPhong.Tang
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        public fAlter()
        {
            InitializeComponent();
        }

        private void fAlter_Load(object sender, EventArgs e)
        {
            LoadTenKhu();
            this.btn_them.Enabled = false;
        }


        private async void LoadTenKhu()
        {
            this.cb_tenKhu.Items.AddRange(BLL_KHU.LayDanhSachTenKhu());

            await Task.Delay(750);
            this.cb_tenKhu.DroppedDown = true;
        }

        private void cb_tenKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroComboBox cb = sender as MetroComboBox;
            DTO_KHU khu = new DTO_KHU();
            khu.TenKhu = cb.Text;
            DTO_TANG tang = new DTO_TANG();
            tang.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);

            this.txt_tenTang.Text = BLL_TANG.LayTenTangTiepTheo(tang);
            this.btn_them.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KHU khu = new DTO_KHU();
                khu.TenKhu = this.cb_tenKhu.Text;
                DTO_TANG tang = new DTO_TANG();
                tang.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);


                if (BLL_TANG.ThemTang(tang) == true)
                {
                    XtraMessageBox.Show("Thêm tầng thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChildrenForms.QuanLyPhong.fTang.isAdded = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm tầng !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}