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

namespace GUI.ChildrenForms.DichVu.DanhMucDichVu
{
    public partial class fDanhMucDichVu : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        public static bool isUpdated = false;

        public fDanhMucDichVu()
        {
            InitializeComponent();
        }

        private void fDanhMucDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_DICHVU.LayDanhSachDichVu();
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


            this.gridControl_dichVu.DataSource = dt;

            this.gridView_dichVu.Columns["MADICHVU"].Visible = false;
            this.gridView_dichVu.Columns["TENDICHVU"].Caption = "Tên dịch vụ";
            this.gridView_dichVu.Columns["GIADICHVU"].Caption = "Giá dịch vụ";
            this.gridView_dichVu.Columns["BATBUOC"].Caption = "Bắt buộc";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.DichVu.DanhMucDichVu.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_DICHVU dichVuHienTai = LayDichVuHienTai();
            XtraForm FormAlter = new ChildrenForms.DichVu.DanhMucDichVu.fAlter(dichVuHienTai);
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_DICHVU dichVuHienTai = LayDichVuHienTai();


                if (dichVuHienTai.TenDichVu == "Tiền điện" ||
                    dichVuHienTai.TenDichVu == "Tiền nước")
                {
                    XtraMessageBox.Show("Dịch vụ này là mặc định, không thể xoá !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                else
                {
                    if (BLL_DICHVU.DichVuDaDuocThamChieu(dichVuHienTai) == true)
                    {
                        XtraMessageBox.Show("Thông tin dịch vụ đang được sử dụng, không thể xoá !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    else
                    {
                        DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá dịch vụ: {0} ?", dichVuHienTai.TenDichVu),
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (dr== DialogResult.Yes)
                            if (BLL_DICHVU.XoaDichVu(dichVuHienTai) == true)
                            {
                                XtraMessageBox.Show("Xoá thông tin dịch vụ thành công !");
                                LoadData();
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private DTO_DICHVU LayDichVuHienTai()
        {
            DataRow dr = this.gridView_dichVu.GetFocusedDataRow();

            DTO_DICHVU dichVu = new DTO_DICHVU
            {
                MaDichVu = (string)dr["MADICHVU"],
                TenDichVu = (string)dr["TENDICHVU"],
                GiaDichVu = (int)dr["GIADICHVU"],
                BatBuoc = dr["BATBUOC"].ToString()
            };

            return dichVu;
        }

    }
}