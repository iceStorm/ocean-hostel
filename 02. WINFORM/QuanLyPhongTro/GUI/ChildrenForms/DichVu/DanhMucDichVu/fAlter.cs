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
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdd = true;
        DTO_DICHVU dichVu;

        public fAlter(DTO_DICHVU dichVu = null)
        {
            InitializeComponent();


            if (dichVu != null)
            {
                isAdd = false;
                this.dichVu = dichVu;
                this.Text = "Sửa thông tin dịch vụ";
                this.btn_them.Text = "Lưu";

                this.txt_tenDichVu.Text = dichVu.TenDichVu;
                this.num_giaDichVu.Value = dichVu.GiaDichVu;

                if (dichVu.BatBuoc == "True")
                    this.chb_batBuoc.Value = true;
                else
                    this.chb_batBuoc.Value = false;


                if (this.dichVu.TenDichVu == "Tiền điện" || this.dichVu.TenDichVu == "Tiền nước")
                {
                    this.txt_tenDichVu.Enabled = false;
                    this.chb_batBuoc.Value = true;
                    this.chb_batBuoc.Enabled = false;
                }
            }
        }

        private void fAlter_Load(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd == true)
                {
                    this.dichVu = new DTO_DICHVU
                    {
                        TenDichVu = this.txt_tenDichVu.Text,
                        GiaDichVu = (int)this.num_giaDichVu.Value,
                        BatBuoc = (chb_batBuoc.Value == true? "True":"False")
                    };

                    if (BLL_DICHVU.ThemDichVu(this.dichVu) == true)
                    {
                        XtraMessageBox.Show("Thêm dịch vụ thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.DichVu.DanhMucDichVu.fDanhMucDichVu.isAdded = true;
                        this.Close();
                    }
                }
                else
                {
                    this.dichVu.TenDichVu = this.txt_tenDichVu.Text;
                    this.dichVu.GiaDichVu = (int)this.num_giaDichVu.Value;
                    this.dichVu.BatBuoc = (this.chb_batBuoc.Value == true ? "True" : "False");

                    if (BLL_DICHVU.SuaDichVu(this.dichVu) == true)
                    {
                        XtraMessageBox.Show("Thay đổi thông tin dịch vụ thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.DichVu.DanhMucDichVu.fDanhMucDichVu.isUpdated = true;
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("duplicate") == true)
                {
                    XtraMessageBox.Show("Tên dịch vụ đã tồn tại !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


    }
}