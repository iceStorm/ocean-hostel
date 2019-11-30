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

namespace GUI.ChildrenForms.QuanLyThietBi.DanhMucThietBi
{
    public partial class fDanhMucThietBi : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        public static bool isUpdated = false;

        public fDanhMucThietBi()
        {
            InitializeComponent();
        }

        private void fDanhMucThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_THIETBI.LayDanhSachThietBi();
            if (dt.Rows.Count == 0)
            {
                this.btn_sua.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
            }

            this.gridControl_thietBi.DataSource = dt;
            this.gridView_thietBi.Columns["MATBI"].Visible = false;

            this.gridView_thietBi.Columns["TENTBI"].Caption = "Tên thiết bị";
            this.gridView_thietBi.Columns["GIATBI"].Caption = "Giá thiết bị";
            this.gridView_thietBi.Columns["NGAYNHAP"].Caption = "Ngày nhập";
            this.gridView_thietBi.Columns["SOLG_TON"].Caption = "Số lượng tồn";
            this.gridView_thietBi.Columns["SOLG_PHANBO"].Caption = "Số lượng phân bổ";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyThietBi.DanhMucThietBi.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_THIETBI thietBiHienTai = LayThietBiHienTai();
            XtraForm FormAlter = new ChildrenForms.QuanLyThietBi.DanhMucThietBi.fAlter(thietBiHienTai);
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }


        private DTO_THIETBI LayThietBiHienTai()
        {
            DataRow dr = this.gridView_thietBi.GetFocusedDataRow();

            DTO_THIETBI thietBi = new DTO_THIETBI
            {
                MaThietBi  = (string)dr["MATBI"],
                TenThietBi = (string)dr["TENTBI"],
                GiaThietBi = (int)dr["GIATBI"],
                NgayNhap = (DateTime)dr["NGAYNHAP"],
                SoLuongTon = (int)dr["SOLG_TON"],
                SoLuongPhanBo = (int)dr["SOLG_PHANBO"]
            };

            return thietBi;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_THIETBI thietBiHienTai = LayThietBiHienTai();

            try
            {
                if (BLL_THIETBI.ThietBiDaDuocThamChieu(thietBiHienTai) == true)
                {
                    XtraMessageBox.Show("Thông tin thiết bị đang được sử dụng, không thể xoá !", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá thông tin thiết bị: {0} ?", thietBiHienTai.TenThietBi),
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        if (BLL_THIETBI.XoaThietBi(thietBiHienTai) == true)
                        {
                            XtraMessageBox.Show("Xoá thông tin thiết bị thành công !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}