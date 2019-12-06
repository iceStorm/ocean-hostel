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

namespace GUI.ChildrenForms.QuanLyThietBi.DanhMucThietBi
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private DTO_THIETBI thietBi;

        public fAlter(DTO_THIETBI thietBi = null)
        {
            InitializeComponent();


            if (thietBi != null)    //  Sửa
            {
                this.Text = "Cập nhật thông tin thiết bị";
                this.btn_them.Text = "Lưu";

                this.thietBi = thietBi;
                this.txt_tenThietBi.Text = thietBi.TenThietBi;
                this.num_giaThietBi.Value = thietBi.GiaThietBi;
                this.num_soLuong.Value = thietBi.SoLuongTon;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.thietBi == null)   //  Thêm
                {
                    DTO_THIETBI thietBi = new DTO_THIETBI
                    {
                        TenThietBi = this.txt_tenThietBi.Text,
                        GiaThietBi = (int)this.num_giaThietBi.Value,
                        SoLuongTon = (int)this.num_soLuong.Value
                    };

                    if (BLL_THIETBI.ThemThietBi(thietBi) == true)
                    {
                        XtraMessageBox.Show("Thêm thiết bị thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyThietBi.DanhMucThietBi.fDanhMucThietBi.isAdded = true;
                        this.Close();
                    }
                }
                else    //  Sửa
                {
                    this.thietBi.TenThietBi = this.txt_tenThietBi.Text;
                    this.thietBi.GiaThietBi = (int)this.num_giaThietBi.Value;
                    this.thietBi.SoLuongTon = (int)this.num_soLuong.Value;

                    if (BLL_THIETBI.SuaThietBi(this.thietBi) == true)
                    {
                        XtraMessageBox.Show("Sửa thông tin thiết bị thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyThietBi.DanhMucThietBi.fDanhMucThietBi.isUpdated = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate"))
                {
                    XtraMessageBox.Show("Tên thiết bị đã tồn tại !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}