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
    public partial class fTang : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false; //  Xác định liệu đã thêm hay chưa
        public static bool isUpdated = false;

        public fTang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.gridControl_tang.DataSource = BLL_TANG.LayDanhSachTang();
            this.gridView_tang.Columns["TENKHU"].Caption = "Tên Khu";
            this.gridView_tang.Columns["TENTANG"].Caption = "Tên Tầng";

            this.gridView_tang.Columns["MATANG"].Caption = "Mã Tầng";
            this.gridView_tang.Columns["MATANG"].Visible = false;
            this.gridView_tang.Columns["MAKHU"].Caption = "Mã Khu";
            this.gridView_tang.Columns["MAKHU"].Visible = false;
        }

        private void fTang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.Tang.fAlter();
            FormAlter.ShowDialog();


            if (isAdded == true)
            {
                isAdded = false;
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_TANG tangHienTai = LayThongTinTangHienTai();

            try
            {
                if (BLL_TANG.TangDaDuocThamChieu(tangHienTai) == true)
                {
                    XtraMessageBox.Show("Thông tin tầng đang được sử dụng, không thể xoá !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá thông tin: {0} ?", tangHienTai.TenTang),
                    "Thông báo", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        if (BLL_TANG.XoaTang(tangHienTai) == true)
                        {
                            XtraMessageBox.Show("Xoá thông tin tầng thành công !",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }



        private DTO_TANG LayThongTinTangHienTai()
        {
            DataRow dr = this.gridView_tang.GetFocusedDataRow();

            DTO_TANG tang = new DTO_TANG
            {
                MaKhu = dr["MAKHU"].ToString(),
                MaTang = dr["MATANG"].ToString(),
                TenTang = dr["TENTANG"].ToString()
            };

            return tang;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}