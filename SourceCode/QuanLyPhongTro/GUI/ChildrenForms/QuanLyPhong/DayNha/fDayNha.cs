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
    public partial class fDayNha : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false; //  Xác định liệu đã thêm hay chưa
        public static bool isUpdated = false;

        public fDayNha()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            this.gridControl_khu.DataSource = BLL_KHU.LayDanhSachKhu();
            this.gridView_khu.Columns["MAKHU"].Caption = "Mã Khu";
            this.gridView_khu.Columns["TENKHU"].Caption = "Tên Khu";
        }

        private void fDayNha_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private DTO_KHU LayThongTinKhuDangChon()
        {
            DataRow dr = gridView_khu.GetFocusedDataRow();

            DTO_KHU khu = new DTO_KHU
            {
                TenKhu = dr["TENKHU"].ToString(),
                MaKhu = dr["MAKHU"].ToString()
            };

            return khu;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.DayNha.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_KHU khuHienTai = LayThongTinKhuDangChon();

            XtraForm FormAlter = new ChildrenForms.QuanLyPhong.DayNha.fAlter(khuHienTai);
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_KHU khuHienTai = LayThongTinKhuDangChon();

            try
            {
                if (BLL_KHU.KhuDaDuocThamChieu(khuHienTai) == true)
                {
                    XtraMessageBox.Show("Khu đang chứa các tầng, không thể xoá !", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = XtraMessageBox.Show(String.Format("Xác nhận xoá thông tin khu: {0}?", khuHienTai.TenKhu),
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        if (BLL_KHU.XoaKhu(khuHienTai) == true)
                        {
                            XtraMessageBox.Show("Xoá khu thành công !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi xoá khu !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}