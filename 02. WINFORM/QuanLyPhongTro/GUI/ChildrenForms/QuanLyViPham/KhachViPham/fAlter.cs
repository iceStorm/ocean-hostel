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

namespace GUI.ChildrenForms.QuanLyViPham.KhachViPham
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        public fAlter()
        {
            InitializeComponent();
        }

        private void fAlter_Load(object sender, EventArgs e)
        {
            AssignComboBoxData();
        }

        private void AssignComboBoxData()
        {
            this.cb_tenPhong.DataSource = BLL_PHONG.LayDanhSachPhong();
            this.cb_tenPhong.DisplayMember = "TENPHG";
            this.cb_tenPhong.ValueMember = "MAPHG";
            this.cb_tenPhong.SelectedIndex = -1;

            this.cb_viPham.DataSource = BLL_VIPHAM.LayDanhSachNoiQuy();
            this.cb_viPham.DisplayMember = "NOIDUNG";
            this.cb_viPham.ValueMember = "MAVIPHAM";
            this.cb_viPham.SelectedIndex = -1;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_tenPhong_KeyDown(object sender, KeyEventArgs e)
        {
            this.cb_tenPhong.DroppedDown = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cb_tenPhong.SelectedIndex.ToString());
        }

        private void cb_tenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}