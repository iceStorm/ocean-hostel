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

namespace GUI.ChildrenForms.KhachTro.HopDong
{
    public partial class fDanhSachHopDong : DevExpress.XtraEditors.XtraForm
    {
        public fDanhSachHopDong()
        {
            InitializeComponent();
        }

        private void fHopDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_HOPDONG.LayDanhSachHopDong();
            if (dt.Rows.Count == 0)
            {
                this.btn_traCoc.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_traCoc.Enabled = true;
                this.btn_xoa.Enabled = true;
            }


            this.gridControl_hopDong.DataSource = dt;
            this.gridView_hopDong.Columns["MAPHG"].Visible = false;

            this.gridView_hopDong.Columns["MAHOPDONG"].Caption = "Mã hợp đồng";
            this.gridView_hopDong.Columns["MAHOPDONG"].VisibleIndex = 0;
            this.gridView_hopDong.Columns["TENPHG"].Caption = "Tên phòng";
            this.gridView_hopDong.Columns["THOIHAN"].Caption = "Thời hạn";
            this.gridView_hopDong.Columns["THOIGIANTAO"].Caption = "Ngày tạo";
            this.gridView_hopDong.Columns["TRANGTHAI"].Caption = "Trạng thái";
            this.gridView_hopDong.Columns["TIENCOC"].Caption = "Tiền cọc";
            this.gridView_hopDong.Columns["DATRACOC"].Caption = "Đã trả cọc";
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_traCoc_Click(object sender, EventArgs e)
        {
            DTO_HOPDONG hopDong = new DTO_HOPDONG();
            hopDong.MaHopDong = (string)(this.gridView_hopDong.GetFocusedDataRow())["MAHOPDONG"];

            try
            {
                DialogResult dr = XtraMessageBox.Show("Xác nhận hoàn trả tiền cọc cho khách trọ ?\n" + 
                    "Hành động không thể khôi phục.", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (BLL_HOPDONG.TraCocHopDong(hopDong) == true)
                    {
                        XtraMessageBox.Show("Đã cập nhật thông tin trả cọc !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView_hopDong_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DTO_HOPDONG hopDong = new DTO_HOPDONG();
            hopDong.TrangThai = (string)(this.gridView_hopDong.GetFocusedDataRow())["TRANGTHAI"];
            hopDong.DaTraCoc = (this.gridView_hopDong.GetFocusedDataRow())["DATRACOC"].ToString();


            if (hopDong.DaTraCoc == "True")
            {
                this.btn_traCoc.Enabled = false;
            }
            else
            {
                this.btn_traCoc.Enabled = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_HOPDONG hopDong = new DTO_HOPDONG();
            hopDong.MaHopDong = (string)(this.gridView_hopDong.GetFocusedDataRow())["MAHOPDONG"];

            try
            {
                string message = String.Format("Xác nhận xoá thông tin hợp đồng {0} ?\n" + 
                    "Hành động không thể khôi phục.", hopDong.MaHopDong);

                DialogResult dr = XtraMessageBox.Show(message, "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dr == DialogResult.Yes)
                {
                    if (BLL_HOPDONG.XoaHopDong(hopDong) == true)
                    {
                        XtraMessageBox.Show("Đã xoá thông tin hợp đồng !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
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