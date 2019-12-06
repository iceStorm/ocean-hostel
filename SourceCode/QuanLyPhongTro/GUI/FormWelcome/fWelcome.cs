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
using DTO;

namespace GUI
{
    public partial class fWelcome : DevExpress.XtraEditors.XtraForm
    {
        DTO_NGUOIDUNG nguoiDung;
        AnimatorNS.Animator animator;

        public fWelcome(DTO_NGUOIDUNG nguoiDung)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("LOGIN_BACKGROUNDS/2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.nguoiDung = nguoiDung;
            this.animator = new Animator();
            this.lb_welcome.Hide();
        }

        private async void fWelcome_Load(object sender, EventArgs e)
        {
            this.lb_welcome.Text = String.Format("Xin chào, {0} !", 
                this.nguoiDung.Ho + ' ' + this.nguoiDung.Ten);

            await Task.Delay(2750);
            this.animator.Show(this.lb_welcome, false, Animation.Mosaic);
        }
    }
}