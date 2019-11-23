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
            this.gridControl_tang.DataSource = BLL_KHU.LayDanhSachKhu();
            this.gridView_tang.Columns["MAKHU"].Caption = "Mã Khu";
            this.gridView_tang.Columns["TENKHU"].Caption = "Tên Khu";
        }

        private void fTang_Load(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}