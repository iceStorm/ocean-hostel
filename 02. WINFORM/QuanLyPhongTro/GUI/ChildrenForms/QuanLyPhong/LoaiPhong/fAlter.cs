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

namespace GUI.ChildrenForms.QuanLyPhong.LoaiPhong
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        private DTO_LOAIPHONG loaiPhong;
        private bool isAdd = true;

        public fAlter(DTO_LOAIPHONG loaiPhong = null)
        {
            InitializeComponent();

            if (loaiPhong != null)
            {
                isAdd = false;
                this.loaiPhong = loaiPhong;
                this.btn_them.Text = "Lưu";
                this.Text = "Sửa thông tin Loại phòng";

                this.txt_tenLoaiPhong.Text = loaiPhong.TenLoaiPhong;
                this.txt_giaPhong.Text = loaiPhong.GiaPhong.ToString();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckBeforeSave()
        {
            bool state = true;

            if (String.IsNullOrWhiteSpace(this.txt_tenLoaiPhong.Text))
            {
                XtraMessageBox.Show("Chưa nhập tên loại phòng !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.txt_tenLoaiPhong.Focus();
                state = false;
            }
            else
                if (String.IsNullOrWhiteSpace(this.txt_giaPhong.Text))
                {
                    XtraMessageBox.Show("Chưa nhập giá phòng !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.txt_giaPhong.Focus();
                    state = false;
                }

            return state;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave() == false)     //  Kiểm tra rỗng
                return;


            try
            {
                if (isAdd == true)     //  Thêm
                {
                    this.loaiPhong = new DTO_LOAIPHONG
                    {
                        TenLoaiPhong = this.txt_tenLoaiPhong.Text,
                        GiaPhong = int.Parse(this.txt_giaPhong.Text)
                    };

                    if (BLL_LOAIPHONG.ThemLoaiPhong(loaiPhong) == true)
                    {
                        XtraMessageBox.Show("Thêm loại phòng thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyPhong.LoaiPhong.fLoaiPhong.isAdded = true;
                        this.Close();
                    }
                }
                else
                {
                    this.loaiPhong.TenLoaiPhong = this.txt_tenLoaiPhong.Text;
                    this.loaiPhong.GiaPhong = int.Parse(this.txt_giaPhong.Text);


                    if (BLL_LOAIPHONG.SuaLoaiPhong(loaiPhong) == true)
                    {
                        XtraMessageBox.Show("Sửa thông tin loại phòng thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyPhong.LoaiPhong.fLoaiPhong.isUpdated = true;
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("duplicate"))   //  Trùng tên loại phòng
                {
                    XtraMessageBox.Show("Tên loại phòng đã tồn tại !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.txt_tenLoaiPhong.Focus();
                    this.txt_tenLoaiPhong.SelectAll();
                }
                else
                    XtraMessageBox.Show("Lỗi truy vấn !" + "\n\nNội dung lỗi: \n" + ex.Message,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}