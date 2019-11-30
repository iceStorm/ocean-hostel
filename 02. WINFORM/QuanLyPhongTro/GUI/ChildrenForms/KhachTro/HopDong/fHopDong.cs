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

namespace GUI.ChildrenForms.KhachTro.HopDong
{
    public partial class fHopDong : DevExpress.XtraEditors.XtraForm
    {
        public fHopDong()
        {
            InitializeComponent();
        }

        private void fHopDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.gridControl_hopDong.DataSource = BLL_HOPDONG.LayDanhSachHopDong();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}