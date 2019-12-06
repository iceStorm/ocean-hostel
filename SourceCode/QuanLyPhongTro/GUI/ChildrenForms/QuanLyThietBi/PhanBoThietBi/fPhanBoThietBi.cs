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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.Framework.UI;

namespace GUI.ChildrenForms.QuanLyThietBi.PhanBoThietBi
{
    public partial class fPhanBoThietBi : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        public static bool isUpdated = false;
        private string maPhong = "";


        public fPhanBoThietBi()
        {
            InitializeComponent();
        }

        private void fPhanBoThietBi_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            string[] listKhu = BLL_KHU.LayDanhSachTenKhu();
            DTO_KHU khu = new DTO_KHU();
            DTO_TANG tang = new DTO_TANG();

            int countNodes = 0;
            foreach (string str in listKhu)
            {
                this.treeList_khuTang.Nodes.Add(new object[]{ str });
                khu.TenKhu = str;
                khu.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);
                string[] listTang = BLL_TANG.LayDanhSachTenTang_TheoTenKhu(khu);   //  Lấy các tầng thuộc khu


                int countLv1Nodes = 0;
                foreach (string ss in listTang)
                {
                    this.treeList_khuTang.Nodes[countNodes].Nodes.Add(new object[] { ss });

                    tang.TenTang = ss;
                    tang.MaTang = BLL_TANG.LayMaTang_TheoTenTang_MaKhu(tang, khu);
                    string[] listPhong = BLL_PHONG.LayDanhSachTenPhongTheoMaTang(tang);


                    foreach (string s in listPhong)
                        this.treeList_khuTang.Nodes[countNodes].Nodes[countLv1Nodes].Nodes.Add(new object[]{s});

                    countLv1Nodes++;
                }


                countNodes++;
            }
        }


        private void LoadPhong()
        {
            TreeList tl = this.treeList_khuTang;
            TreeListNode node = tl.FocusedNode;
            TreeListNode parentNode = node.ParentNode;

            if (parentNode != null) //  Tầng
            {
                TreeListNode grandNode = parentNode.ParentNode;     //  Khu

                if (grandNode != null)
                {
                    this.btn_them.Enabled = true;
                    this.btn_xoa.Enabled = true;
                    this.btn_lamMoi.Enabled = true;

                    string tenPhong = node.GetDisplayText(0);
                    string tenTang = parentNode.GetDisplayText(0);
                    string tenKhu = grandNode.GetDisplayText(0);


                    this.lb_tenPhong.Text = tenPhong;
                    this.lb_khuTang.Text = String.Format("{0} — {1}", tenKhu.ToUpper(), tenTang.ToUpper());


                    DTO_PHONG phong = new DTO_PHONG();
                    phong.TenPhong = tenPhong;
                    phong.MaPhong = BLL_PHONG.LayMaPhongTheoTenPhong(phong);
                    this.maPhong = phong.MaPhong;


                    DataTable dt = BLL_THIETBI_PHONG.LayDanhSachThietBiPhongTheoMaPhong(phong);
                    if (dt.Rows.Count == 0)
                    {
                        this.btn_xoa.Enabled = false;
                    }
                    else
                    {
                        this.btn_xoa.Enabled = true;
                    }

                    this.gridControl_thietBiPhong.DataSource = dt;
                    this.gridView_thietBiPhong.Columns["MAPHG"].Visible = false;
                    this.gridView_thietBiPhong.Columns["MATBI"].Visible = false;

                    this.gridView_thietBiPhong.Columns["TENTBI"].VisibleIndex = 0;
                    this.gridView_thietBiPhong.Columns["TENTBI"].Caption = "Tên thiết bị";
                    this.gridView_thietBiPhong.Columns["THOIGIANCAP"].Caption = "Thời gian cấp";
                }
                else
                {
                    this.btn_them.Enabled = false;
                    this.btn_xoa.Enabled = false;
                    this.btn_lamMoi.Enabled = false;

                    this.gridControl_thietBiPhong.DataSource = null;
                    this.lb_tenPhong.Text = "?";
                    this.lb_khuTang.Text = "KHU – TẦNG";
                }
            }
        }

        private void treeList_khuTang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadPhong();
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_THIETBI_PHONG thietBiPhong = new DTO_THIETBI_PHONG();
            thietBiPhong.MaPhong = this.maPhong;

            XtraForm FormAlter = new ChildrenForms.QuanLyThietBi.PhanBoThietBi.fAlter(thietBiPhong);
            FormAlter.ShowDialog();

            if (isAdded == true)
            {
                LoadPhong();
                isAdded = false;
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadPhong();
        }


        private DTO_THIETBI_PHONG LayThietBiPhongHienTai()
        {
            DataRow dr = this.gridView_thietBiPhong.GetFocusedDataRow();

            DTO_THIETBI_PHONG thietBiPhong = new DTO_THIETBI_PHONG
            {
                MaThietBi = (string)dr["MATBI"],
                TenThietBi = (string)dr["TENTBI"],
                MaPhong = (string)dr["MAPHG"],
                NgayCap = (DateTime)dr["THOIGIANCAP"]
            };

            return thietBiPhong;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_THIETBI_PHONG thietBiPhong = LayThietBiPhongHienTai();
            
            try
            {
                if (BLL_THIETBI_PHONG.XoaThietBiPhong(thietBiPhong) == true)
                {
                    XtraMessageBox.Show("Gỡ thông tin thiết bị thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPhong();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}