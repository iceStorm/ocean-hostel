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
using AnimatorNS;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.IO;
using BLL;
using DTO;

namespace GUI
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        #region FIELDS

        int countImages = 0;
        private List<string> listBackgroundImages;
        private Timer timer_imageSlider;
        private Timer timer_openForm;
        private Animator animator;

        #endregion


        public fLogin()
        {
            InitializeComponent();
            LoadListBgrImages();
            this.FormBorderStyle = FormBorderStyle.None;    //  Make the form be BorderLess

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btn_cancel, "Đóng");


            #region Panel image slider (pn_imageSlider)

            if (this.listBackgroundImages.Count > 0)    //  Nếu trong thư mục có ảnh
            {
                int min = 0;
                int max = this.listBackgroundImages.Count - 1;
                Random rd = new Random();
                int index = rd.Next(min, max);  //  Lấy ngẫu nhiên một số trong đoạn [min, max]

                Image img = Image.FromFile(listBackgroundImages[index]);
                this.pn_imageSlider.BackgroundImage = img;


                this.timer_imageSlider = new Timer();
                this.timer_imageSlider.Interval = 7500;
                this.timer_imageSlider.Tick += timer_imageSlider_Tick;
                this.timer_imageSlider.Start();
            }
            else
            {
                MessageBox.Show("Load ảnh nền lỗi !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            #endregion


            #region Animator

            this.animator = new Animator();
            animator.AnimationType = AnimationType.Mosaic;

            #endregion


            #region Timer open form

            HideControls();
            this.Opacity = 0;
            this.timer_openForm = new Timer();
            this.timer_openForm.Interval = 1;
            this.timer_openForm.Tick += timer_open_Tick;
            this.timer_openForm.Start();

            #endregion
        }


        #region TIMER TICK EVENTS
        private void timer_imageSlider_Tick(object sender, EventArgs e)
        {
            //animator.Hide(this.pn_imageSlider, false, Animation.Transparent);

            //await Task.Delay(350);
            string currPath = this.listBackgroundImages[countImages++];
            this.pn_imageSlider.BackgroundImage = Image.FromFile(currPath);
            //animator.Show(this.pn_imageSlider, false, Animation.Transparent);


            if (countImages >= this.listBackgroundImages.Count)
                countImages = 0;
        }
        private void timer_open_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;

            if (this.Opacity >= 1)
            {
                this.Opacity = 1;
                this.timer_openForm.Stop();
                this.timer_openForm.Tick -= timer_open_Tick;

                ShowControls();
            }
        }

        #endregion


        #region LOAD LIST BACKGROUND IMAGES

        private void LoadListBgrImages()
        {
            this.listBackgroundImages = new List<string>();
            string[] imagePaths = Directory.GetFiles("LOGIN_BACKGROUNDS");

            foreach (string path in imagePaths)
                if (Path.GetExtension(path).ToUpper() == ".JPG")
                    this.listBackgroundImages.Add(path);
        }

        #endregion


        #region MAKE THE FORM DRAGGABLE WHEN IT'S BORDERLESS

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


        #region CLICK EVENTS

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (CheckBeforeLogin() == false)
                return;


            DTO_NGUOIDUNG nguoiDung = new DTO_NGUOIDUNG
            {
                TenDangNhap = txt_tenTaiKhoan.Text,
                MatKhau = txt_matKhau.Text
            };


            try
            {
                DataTable dt = BLL_NGUOIDUNG.GetAccountInfo_By_Credentials(nguoiDung);

                if (dt.Rows.Count > 0)
                {
                    nguoiDung.Ho = dt.Rows[0]["HO"].ToString();
                    nguoiDung.Ten = dt.Rows[0]["TEN"].ToString();

                    fMain FormMain = new fMain(nguoiDung);
                    this.Hide();
                    FormMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Thông tin đăng nhập không chính xác, vui lòng kiểm tra lại !",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.txt_matKhau.Focus();
                    this.txt_matKhau.SelectAll();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region SHOW - HIDE CONTROLS
        private async void ShowControls()
        {
            animator.Show(lb_loginTitle, true);

            await Task.Delay(250);
            animator.Show(lb_tenTaiKhoan, true, Animation.VertSlide);
            animator.Show(lb_matKhau, true, Animation.VertSlide);

            await Task.Delay(250);
            animator.Show(txt_tenTaiKhoan, true, Animation.HorizSlide);
            animator.Show(txt_matKhau, true, Animation.HorizSlide);

            await Task.Delay(150);
            animator.Show(btn_dangNhap, true, Animation.Scale);
            animator.Show(btn_cancel, true, Animation.Scale);

            await Task.Delay(200);
            animator.Show(lb_brand, false, Animation.HorizSlide);
            animator.Show(lb_slogan, false, Animation.VertSlide);
            this.txt_tenTaiKhoan.Focus();
        }

        private void HideControls()
        {
            this.lb_loginTitle.Visible = false;

            this.lb_tenTaiKhoan.Visible = false;
            this.lb_matKhau.Visible = false;
            this.txt_tenTaiKhoan.Visible = false;
            this.txt_matKhau.Visible = false;

            this.btn_cancel.Visible = false;
            this.btn_dangNhap.Visible = false;

            this.lb_brand.Visible = false;
            this.lb_slogan.Visible = false;
        }

        #endregion



        private bool CheckBeforeLogin()
        {
            bool state = true;


            if (String.IsNullOrWhiteSpace(this.txt_tenTaiKhoan.Text))
            {
                state = false;

                XtraMessageBox.Show("Chưa nhập tên tài khoản !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.txt_tenTaiKhoan.Focus();
            }
            else
            {
                if (String.IsNullOrWhiteSpace(this.txt_matKhau.Text))
                {
                    state = false;

                    XtraMessageBox.Show("Chưa nhập mật khẩu !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.txt_matKhau.Focus();
                }
            }


            return state;
        }

        private void textBoxes_Keypress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Space:
                    {
                        e.Handled = true;   //  Chặn nhập vào phím Space
                        break;
                    }

                case (char)Keys.Enter:
                    {
                        this.btn_dangNhap.PerformClick();   //  Nhấn nút Đăng Nhập
                        break;
                    }
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

    }
}