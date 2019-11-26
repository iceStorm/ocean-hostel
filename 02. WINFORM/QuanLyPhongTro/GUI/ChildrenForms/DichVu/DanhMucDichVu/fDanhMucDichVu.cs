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
            this.gridControl_dichVu.DataSource = BLL_DICHVU.LayDanhSachDichVu();

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