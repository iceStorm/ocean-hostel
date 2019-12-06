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

namespace GUI.ChildrenForms.QuanLyViPham.ViPham
{
    public partial class fViPham : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        public static bool isUpdated = false;

        public fViPham()
        {
            InitializeComponent();
        }

        private void fNoiQuy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = BLL_VIPHAM.LayDanhSachNoiQuy();

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

            this.gridControl_noiQuy.DataSource = dt;

            this.gridView_noiQuy.Columns["MAVIPHAM"].Visible = false;
            this.gridView_noiQuy.Columns["NOIDUNG"].Caption = "Tên vi phạm";
            this.gridView_noiQuy.Columns["HINHPHAT"].Caption = "Hình phạt";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyViPham.ViPham.fAlter();
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadData();
                isAdded = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            XtraForm FormAlter = new ChildrenForms.QuanLyViPham.ViPham.fAlter(LayViPhamHienTai());
            FormAlter.ShowDialog();

            if (isUpdated == true)
            {
                LoadData();
                isUpdated = false;
            }
        }

        private DTO_VIPHAM LayViPhamHienTai()
        {
            DataRow dr = this.gridView_noiQuy.GetFocusedDataRow();

            DTO_VIPHAM viPham = new DTO_VIPHAM
            {
                MaViPham = (string)dr["MAVIPHAM"],
                NoiDung = (string)dr["NOIDUNG"],
                HinhPhat = (string)dr["HINHPHAT"]
            };

            return viPham;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_VIPHAM viPhamHienTai = LayViPhamHienTai();

                string message = String.Format("Xác nhận xoá vi phạm: \n{0} ?", viPhamHienTai.NoiDung);
                DialogResult dr = XtraMessageBox.Show(message, "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    if (BLL_VIPHAM.XoaViPham(viPhamHienTai) == true)
                    {
                        XtraMessageBox.Show("Xoá vi phạm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
            }
            catch (Exception ex)
            {

            }
        }

    }
}