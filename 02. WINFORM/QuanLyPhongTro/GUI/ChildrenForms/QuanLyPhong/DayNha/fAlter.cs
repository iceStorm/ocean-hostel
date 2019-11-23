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
using DTO;
using BLL;

namespace GUI.ChildrenForms.QuanLyPhong.DayNha
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddNew = true;
        private DTO_KHU khu;

        public fAlter(DTO_KHU khu = null)
        {
            InitializeComponent();


            if (khu != null)    //  Truyền vào thông tin khu từ form cha ==> Là Update
            {
                isAddNew = false;

                this.khu = khu;
                this.txt_tenKhu.Text = khu.TenKhu;
                this.btn_them.Text = "Lưu";
                this.Text = "Sửa thông tin Khu";
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (isAddNew == true)       //  Là trường hợp Insert
            {
                try
                {
                    this.khu = new DTO_KHU
                    {
                        TenKhu = this.txt_tenKhu.Text
                    };

                    if (BLL_KHU.ThemKhu(this.khu) == true)
                    {
                        XtraMessageBox.Show("Thêm khu thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fDayNha.isAdded = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate"))
                    {
                        XtraMessageBox.Show("Tên khu đã tồn tại !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.txt_tenKhu.Focus();
                        this.txt_tenKhu.SelectAll();
                    }
                    else
                        XtraMessageBox.Show("Lỗi khi thêm khu !" + "\n\nNội dung lỗi: \n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else                        //  Trường hợp Update
            {
                try
                {
                    this.khu.TenKhu = this.txt_tenKhu.Text;

                    if (BLL_KHU.CapNhatKhu(khu) == true)
                    {
                        XtraMessageBox.Show("Cập nhật thông tin khu thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fDayNha.isUpdated = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate"))
                    {
                        XtraMessageBox.Show("Tên khu đã tồn tại !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        this.txt_tenKhu.Focus();
                        this.txt_tenKhu.SelectAll();
                    }
                    else
                        XtraMessageBox.Show("Lỗi khi cập nhật khu !" + "\n\nNội dung lỗi: \n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}