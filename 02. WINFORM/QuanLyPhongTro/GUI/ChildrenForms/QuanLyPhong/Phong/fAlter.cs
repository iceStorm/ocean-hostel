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

namespace GUI.ChildrenForms.QuanLyPhong.Phong
{
    public partial class fAlter : DevExpress.XtraEditors.XtraForm
    {
        DTO_PHONG phong;

        public fAlter(DTO_PHONG phong = null)
        {
            InitializeComponent();
            LoadLoaiPhong();
            LoadDanhSachKhu();

            if (phong != null)
            {
                this.phong = phong;

                this.btn_them.Text = "Lưu";
                this.Text = "Sửa thông tin Phòng";
                this.cb_tenTang.Enabled = false;
                this.cb_tenKhu.Enabled = false;

                AssignData();
            }
        }

        private void AssignData()
        {
            this.txt_tenPhong.Text = this.phong.TenPhong;
            this.cb_tenKhu.SelectedItem = (object)this.phong.TenKhu;
            this.cb_tenTang.SelectedItem = (object)this.phong.TenTang;
            this.cb_tenLoaiPhong.SelectedItem = (object)this.phong.TenLoaiPhong.TrimEnd();
            this.num_soLuongToiDa.Value = this.phong.SoLuongToiDa; 


            if (phong.DangSuaChua == "True")
                this.chb_dangSuaChua.Value = true;
            else
                this.chb_dangSuaChua.Value = false;
        }


        private void fAlter_Load(object sender, EventArgs e)
        {
        }


        private void LoadLoaiPhong()
        {
            this.cb_tenLoaiPhong.Items.Clear();
            this.cb_tenLoaiPhong.Items.AddRange(BLL_LOAIPHONG.LayDanhSachTenLoaiPhong());
        }

        private void LoadDanhSachKhu()
        {
            this.cb_tenKhu.Items.Clear();
            this.cb_tenKhu.Items.AddRange(BLL_KHU.LayDanhSachTenKhu());
        }

        private void cb_tenKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_TenKhu = this.cb_tenKhu.Text;
            DTO_KHU khu = new DTO_KHU();
            khu.TenKhu = selected_TenKhu;

            this.cb_tenTang.Items.Clear();
            this.cb_tenTang.Items.AddRange(BLL_TANG.LayDanhSachTenTang_TheoTenKhu(khu));
        }

        private void cb_tenTang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_loaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_KHU khu = new DTO_KHU();
            khu.TenKhu = this.cb_tenKhu.Text;
            khu.MaKhu = BLL_KHU.LayMaKhuTheoTenKhu(khu);

            DTO_TANG tang = new DTO_TANG();
            tang.TenTang = this.cb_tenTang.Text;

            DTO_LOAIPHONG loaiPhong = new DTO_LOAIPHONG();
            loaiPhong.TenLoaiPhong = this.cb_tenLoaiPhong.Text;



            if (this.phong == null)     //  Thêm mới phòng
            {
                try
                {
                    DTO_PHONG phong = new DTO_PHONG()
                    {
                        TenPhong = this.txt_tenPhong.Text,
                        MaTang = BLL_TANG.LayMaTang_TheoTenTang_MaKhu(tang, khu),
                        SoLuongToiDa = (int)this.num_soLuongToiDa.Value,
                        DangSuaChua = (this.chb_dangSuaChua.Value == true ? "True":"False"),
                        MaLoaiPhong = BLL_LOAIPHONG.LayMaLoaiPhong_TheoTenLoaiPhong(loaiPhong)
                    };

                    if (BLL_PHONG.ThemPhong(phong) == true)
                    {
                        XtraMessageBox.Show("Thêm phòng thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyPhong.fPhong.isAdded = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate"))
                    {
                        XtraMessageBox.Show("Tên phòng đã tồn tại !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else    //  Sửa
            {
                try
                {
                    DTO_PHONG phong = new DTO_PHONG()
                    {
                        MaPhong = this.phong.MaPhong,
                        TenPhong = this.txt_tenPhong.Text,
                        MaTang = BLL_TANG.LayMaTang_TheoTenTang_MaKhu(tang, khu),
                        SoLuongToiDa = (int)this.num_soLuongToiDa.Value,
                        DangSuaChua = (this.chb_dangSuaChua.Value == true ? "True" : "False"),
                        MaLoaiPhong = BLL_LOAIPHONG.LayMaLoaiPhong_TheoTenLoaiPhong(loaiPhong)
                    };

                    if (BLL_PHONG.SuaPhong(phong) == true)
                    {
                        XtraMessageBox.Show("Sửa thông tin phòng thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChildrenForms.QuanLyPhong.fPhong.isUpdated = true;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate"))
                    {
                        XtraMessageBox.Show("Tên phòng đã tồn tại !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        XtraMessageBox.Show("Lỗi truy vấn !\n\n" + "Nội dung lỗi:\n" + ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}