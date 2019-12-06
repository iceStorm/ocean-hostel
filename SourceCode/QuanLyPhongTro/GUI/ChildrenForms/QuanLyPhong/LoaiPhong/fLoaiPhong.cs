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

namespace GUI.ChildrenForms.QuanLyPhong.LoaiPhong
{
    public partial class fLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false; //  Xác định liệu đã thêm hay chưa
        public static bool isUpdated = false;

        public fLoaiPhong()
        {
            InitializeComponent();
        }

        private void fLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.gridControl_loaiPhong.DataSource = BLL_LOAIPHONG.LayDanhSachLoaiPhong();

            this.gridView_loaiPhong.Columns["TENLOAIPHG"].Caption = "Tên loại phòng";
            this.gridView_loaiPhong.Columns["GIAPHG"].Caption = "Giá phòng (VNĐ)";
            this.gridView_loaiPhong.Columns["MALOAIPHG"].Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.LoaiPhong.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.LoaiPhong.fAlter(LayLoaiPhongHienTai());
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private DTO_LOAIPHONG LayLoaiPhongHienTai()
        {
            DataRow dr = this.gridView_loaiPhong.GetFocusedDataRow();

            DTO_LOAIPHONG loaiPhong = new DTO_LOAIPHONG
            {
                MaLoaiPhong = dr["MALOAIPHG"].ToString(),
                TenLoaiPhong = dr["TENLOAIPHG"].ToString(),
                GiaPhong = (int)dr["GIAPHG"]
            };

            return loaiPhong;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_LOAIPHONG loaiPhongHienTai = LayLoaiPhongHienTai();

            try
            {
                if (BLL_LOAIPHONG.LoaiPhongDuocThamChieu(loaiPhongHienTai) == true)
                {
                    XtraMessageBox.Show("Thông tin loại phòng đang được sử dụng, không thể xoá !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá thông tin loại phòng: {0} ?", loaiPhongHienTai.TenLoaiPhong),
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        if (BLL_LOAIPHONG.XoaLoaiPhong(loaiPhongHienTai) == true)
                        {
                            XtraMessageBox.Show("Xoá loại phòng thành công !",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !" + "\n\nNội dung lỗi: \n" + ex.Message,
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}