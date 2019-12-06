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
            DataTable dt = BLL_TANG.LayDanhSachTang();
            if (dt.Rows.Count == 0)
            {
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_xoa.Enabled = true;
            }

            this.gridControl_tang.DataSource = dt;
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
                DTO_TANG tangCaoNhat = BLL_TANG.LayTangCaoNhat_TheoMaKhu(tangHienTai);
                if (tangCaoNhat != null)
                {
                    string message = String.Format("Bạn đang chọn khu {0}, tầng cao nhất là {1}.\n" +
                        "Chỉ có thể xoá thông tin từ tầng cao nhất trở xuống.\n" +
                        "Xác nhận xoá ?", tangCaoNhat.TenKhu, tangCaoNhat.TenTang);

                    DialogResult dr = XtraMessageBox.Show(message, "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                        if (BLL_TANG.TangDaDuocThamChieu(tangCaoNhat) == true)
                        {
                            XtraMessageBox.Show("Thông tin tầng đang được sử dụng, không thể xoá !\n" +
                            "Vui lòng xoá thông tin các PHÒNG của tầng này trước.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            message = String.Format("Xác nhận xoá thông tin: {0} ?", tangCaoNhat.TenTang);
                            dr = XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo);

                            if (dr == DialogResult.Yes)
                            {
                                if (BLL_TANG.XoaTang(tangCaoNhat) == true)
                                {
                                    XtraMessageBox.Show("Xoá thông tin tầng thành công !",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoadData();
                                }
                            }
                        }
                }
                else
                {
                   //   Không xảy ra - Chỉ khi có tầng trong khu thì mới có thể chọn
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK,  MessageBoxIcon.Warning);
            }
        }



        private DTO_TANG LayThongTinTangHienTai()
        {
            DataRow dr = this.gridView_tang.GetFocusedDataRow();

            DTO_TANG tang = new DTO_TANG
            {
                MaKhu = dr["MAKHU"].ToString(),
                MaTang = dr["MATANG"].ToString(),
                TenTang = dr["TENTANG"].ToString(),
                TenKhu = dr["TENKHU"].ToString()
            };

            return tang;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}