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
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private DTO_VIPHAM viPham;
        private bool isAdd = true;

        public fAlter(DTO_VIPHAM viPham = null)
        {
            InitializeComponent();
            this.viPham = viPham;

            if (viPham != null) //  Sửa
            {
                isAdd = false;
                this.Text = "Sửa thông tin vi phạm";
                this.btn_them.Text = "Lưu";
                this.txt_noiDung.Text = viPham.NoiDung;
                this.txt_hinhPhat.Text = viPham.HinhPhat;
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
                if (isAdd == false)    //  Sửa
                {
                    this.viPham.NoiDung = this.txt_noiDung.Text;
                    this.viPham.HinhPhat = this.txt_hinhPhat.Text;

                    if (BLL_VIPHAM.SuaViPham(this.viPham) == true)
                    {
                        XtraMessageBox.Show("Sửa thông tin vi phạm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyViPham.ViPham.fViPham.isUpdated = true;
                        this.Close();
                    }
                }
                else
                {
                    this.viPham = new DTO_VIPHAM();
                    this.viPham.NoiDung = this.txt_noiDung.Text;
                    this.viPham.HinhPhat = this.txt_hinhPhat.Text;

                    if (BLL_VIPHAM.ThemViPham(this.viPham) == true)
                    {
                        XtraMessageBox.Show("Thêm vi phạm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyViPham.ViPham.fViPham.isAdded = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate"))
                {
                    XtraMessageBox.Show("Trùng tên vi phạm !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.txt_noiDung.Focus();
                    this.txt_noiDung.SelectAll();
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