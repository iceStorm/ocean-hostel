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

namespace GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong
{
    public partial class fChonKhachCu : DevExpress.XtraEditors.XtraForm
    {
        List<DTO_KHACH> listKhach;

        public fChonKhachCu(List<DTO_KHACH> listKhach)
        {
            InitializeComponent();
            this.listKhach = listKhach;
        }

        private void cb_soCanCuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_soCanCuoc.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)this.cb_soCanCuoc.SelectedItem;
                string ho = (string)drv.Row.ItemArray[2];
                string ten = (string)drv.Row.ItemArray[3];

                this.lb_tenKhach.Text = ho + ' ' + ten;
            }
            else
            {
                this.lb_tenKhach.Text = "?";
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (this.cb_soCanCuoc.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Vui lòng chọn đúng số căn cước !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.cb_soCanCuoc.Focus();
            }
            else
            {
                DataRowView drv = (DataRowView)this.cb_soCanCuoc.SelectedItem;
                if ((string)drv.Row.ItemArray[9] != "Hết hợp đồng")
                {
                    string message = String.Format("Khách đang ở phòng {0} !", (string)drv.Row.ItemArray[10]);
                    XtraMessageBox.Show(message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }


                DTO_KHACH khachCu = new DTO_KHACH
                {
                    MaKhach = (string)drv.Row.ItemArray[1],
                    Ho = (string)drv.Row.ItemArray[2],
                    Ten = (string)drv.Row.ItemArray[3],
                    GioiTinh = (string)drv.Row.ItemArray[4],
                    NgaySinh = (DateTime)drv.Row.ItemArray[5],
                    QueQuan = (string)drv.Row.ItemArray[6],
                    SoCanCuoc = (string)drv.Row.ItemArray[7],
                    SoDienThoai = (string)drv.Row.ItemArray[8],
                    TrangThai = (string)drv.Row.ItemArray[9]
                };

                
                foreach (DTO_KHACH kh in this.listKhach)
                    if (kh.MaKhach == khachCu.MaKhach)
                    {
                        XtraMessageBox.Show("Khách đã có trong hàng đợi !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }


                ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.isAdded = true;
                ChildrenForms.KhachTro.HopDong.ThemHopDong.fThemHopDong.khachTro = khachCu;
                this.Close();
            }
        }

        private void fChonKhachCu_Load(object sender, EventArgs e)
        {
            this.cb_soCanCuoc.DataSource = BLL_KHACH.LayDanhSachKhach();
            this.cb_soCanCuoc.DisplayMember = "SOCANCUOC";
            this.cb_soCanCuoc.SelectedIndex = -1;
        }

        private void cb_soCanCuoc_TextChanged(object sender, EventArgs e)
        {
            if (this.cb_soCanCuoc.SelectedIndex == -1)
                this.lb_tenKhach.Text = "?";
            else
            {
                DataRowView drv = (DataRowView)this.cb_soCanCuoc.SelectedItem;
                string ho = (string)drv.Row.ItemArray[2];
                string ten = (string)drv.Row.ItemArray[3];

                this.lb_tenKhach.Text = ho + ' ' + ten;
            }
        }

    }
}