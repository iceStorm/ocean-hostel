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

namespace GUI.ChildrenForms.QuanLyPhong
{
    public partial class fPhong : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        public static bool isUpdated = false;

        public fPhong()
        {
            InitializeComponent();
        }

        private void fPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.gridControl_phong.DataSource = BLL_PHONG.LayDanhSachPhong();

            this.gridView_phong.Columns["TENKHU"].Caption = "Tên khu";
            this.gridView_phong.Columns["TENTANG"].Caption = "Tên tầng";
            this.gridView_phong.Columns["TENPHG"].Caption = "Tên phòng";
            this.gridView_phong.Columns["TENPHG"].VisibleIndex = 0;
            this.gridView_phong.Columns["SOLG_TOIDA"].Caption = "Số lượng tối đa";
            this.gridView_phong.Columns["SOLG_DANGO"].Caption = "Số lượng đang ở";
            this.gridView_phong.Columns["DANGSUACHUA"].Caption = "Đang sửa chữa";
            this.gridView_phong.Columns["TENLOAIPHG"].Caption = "Loại phòng";

            this.gridView_phong.Columns["MAKHU"].Visible = false;
            this.gridView_phong.Columns["MATANG"].Visible = false;
            this.gridView_phong.Columns["MAPHG"].Visible = false;
            this.gridView_phong.Columns["MALOAIPHG"].Visible = false;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.Phong.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_PHONG phongHienTai = LayPhongHienTai();
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.Phong.fAlter(phongHienTai);
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }


        private DTO_PHONG LayPhongHienTai()
        {
            DataRow dr = this.gridView_phong.GetFocusedDataRow();

            DTO_PHONG phong = new DTO_PHONG
            {
                MaPhong = dr["MAPHG"].ToString(),
                TenPhong = dr["TENPHG"].ToString(),
                SoLuongToiDa = (int)dr["SOLG_TOIDA"],
                SoLuongDangO = (int)dr["SOLG_DANGO"],
                MaLoaiPhong = dr["MALOAIPHG"].ToString(),
                MaTang = dr["MATANG"].ToString(),
                DangSuaChua = dr["DANGSUACHUA"].ToString(),
                TenKhu = dr["TENKHU"].ToString(),
                TenTang = dr["TENTANG"].ToString(),
                TenLoaiPhong = dr["TENLOAIPHG"].ToString()
            };

            return phong;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_PHONG phong = LayPhongHienTai();

                if (BLL_PHONG.PhongDaDuocThamChieu(phong) == true)
                    XtraMessageBox.Show("Thông tin phòng đang được sử dụng, không thể xoá !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá thông tin: {0} ?", phong.TenPhong),
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        if (BLL_PHONG.XoaPhong(phong) == true)
                        {
                            XtraMessageBox.Show("Xoá phòng thành công !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

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