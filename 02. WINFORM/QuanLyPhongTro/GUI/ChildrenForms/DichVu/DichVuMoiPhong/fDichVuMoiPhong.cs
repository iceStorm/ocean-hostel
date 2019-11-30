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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace GUI.ChildrenForms.DichVu.DichVuMoiPhong
{
    public partial class fDichVuMoiPhong : DevExpress.XtraEditors.XtraForm
    {
        public static bool isAdded = false;
        private string maPhong;

        public fDichVuMoiPhong()
        {
            InitializeComponent();
        }

        private void LoadTreeView()
        {
            string[] listKhu = BLL_KHU.LayDanhSachTenKhu();
            DTO_KHU khu = new DTO_KHU();
            DTO_TANG tang = new DTO_TANG();

            int countNodes = 0;
            foreach (string str in listKhu)
            {
                this.treeList_khuTang.Nodes.Add(new object[] { str });
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
                        this.treeList_khuTang.Nodes[countNodes].Nodes[countLv1Nodes].Nodes.Add(new object[] { s });

                    countLv1Nodes++;
                }


                countNodes++;
            }
        }

        private void fDichVuMoiPhong_Load(object sender, EventArgs e)
        {
            LoadTreeView();
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
                    this.btn_dangKyThem.Enabled = true;
                    this.btn_huyDichVu.Enabled = true;
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

                    DataTable dt = BLL_DICHVU_PHONG.LayDanhSachDichVuTheoMaPhong(phong);
                    if (dt.Rows.Count == 0)
                    {
                        this.btn_huyDichVu.Enabled = false;
                    }
                    else
                    {
                        this.btn_huyDichVu.Enabled = true;
                    }

                    this.gridControl_dichVuPhong.DataSource = dt;
                        
                    this.gridView_dichVuPhong.Columns["MAPHG"].Visible = false;
                    this.gridView_dichVuPhong.Columns["MADICHVU"].Visible = false;

                    this.gridView_dichVuPhong.Columns["TENDICHVU"].Caption = "Tên dịch vụ";
                    this.gridView_dichVuPhong.Columns["TENDICHVU"].VisibleIndex = 0;

                    this.gridView_dichVuPhong.Columns["GIADICHVU"].Caption = "Giá dịch vụ";
                    this.gridView_dichVuPhong.Columns["GIADICHVU"].VisibleIndex = 1;

                    this.gridView_dichVuPhong.Columns["NGAYDANGKY"].Caption = "Ngày đăng ký";
                    this.gridView_dichVuPhong.Columns["NGAYDANGKY"].VisibleIndex = 2;

                    this.gridView_dichVuPhong.Columns["BATBUOC"].Caption = "Bắt buộc";
                }
                else
                {
                    this.btn_dangKyThem.Enabled = false;
                    this.btn_lamMoi.Enabled = false;
                    this.btn_huyDichVu.Enabled = false;

                    this.lb_tenPhong.Text = "?";
                    this.lb_khuTang.Text = "KHU – TẦNG";

                    this.gridControl_dichVuPhong.DataSource = null;
                }
            }
        }


        private void treeList_khuTang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadPhong();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btn_dangKyThem_Click(object sender, EventArgs e)
        {
            DTO_DICHVU_PHONG dichVuPhongHienTai = LayDichVuPhongHienTai();
            XtraForm FormAlter = new ChildrenForms.DichVu.DichVuMoiPhong.fAlter(dichVuPhongHienTai);
            FormAlter.ShowDialog();

            
            if (isAdded == true)
            {
                LoadPhong();
                isAdded = false;
            }
        }


        private DTO_DICHVU_PHONG LayDichVuPhongHienTai()
        {
            DataRow dr = this.gridView_dichVuPhong.GetFocusedDataRow();

            if (dr == null) //  GridView không có dòng
                return new DTO_DICHVU_PHONG
                {
                    MaPhong = this.maPhong,
                    MaDichVu = null
                };


            DTO_DICHVU_PHONG dichVuPhong = new DTO_DICHVU_PHONG //  GridView có ít nhất 1 dòng
            {
                MaDichVu = (string)dr["MADICHVU"],
                MaPhong = (string)dr["MAPHG"],
                NgayDangKy = (DateTime)dr["NGAYDANGKY"],
                TenDichVu = (string)dr["TENDICHVU"]
            };

            return dichVuPhong;
        }

        private void btn_huyDichVu_Click(object sender, EventArgs e)
        {
            DTO_DICHVU_PHONG dichVuPhongHienTai = LayDichVuPhongHienTai();


            if (dichVuPhongHienTai.MaDichVu == null)
            {
                XtraMessageBox.Show("Không có dữ liệu !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dichVuPhongHienTai.TenDichVu == "Tiền điện" ||
                    dichVuPhongHienTai.TenDichVu == "Tiền nước")
                {
                    XtraMessageBox.Show("Dịch vụ mặc định, không thể huỷ !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                string question = String.Format("Xác nhận huỷ đăng ký dịch vụ: {0} ?", dichVuPhongHienTai.TenDichVu);

                DialogResult dr = XtraMessageBox.Show(question, "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (BLL_DICHVU_PHONG.XoaDichVuPhong(dichVuPhongHienTai) == true)
                        {
                            XtraMessageBox.Show("Huỷ đăng ký dịch vụ thành công !",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


    }
}