namespace GUI
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btn_dangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lb_loginTitle = new System.Windows.Forms.Label();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.lb_tenTaiKhoan = new System.Windows.Forms.Label();
            this.txt_tenTaiKhoan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_matKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_slogan = new System.Windows.Forms.Label();
            this.lb_brand = new System.Windows.Forms.Label();
            this.pn_left = new System.Windows.Forms.Panel();
            this.pn_imageSlider = new System.Windows.Forms.Panel();
            this.pn_colorLayer = new System.Windows.Forms.Panel();
            this.pn_right = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pn_left.SuspendLayout();
            this.pn_imageSlider.SuspendLayout();
            this.pn_colorLayer.SuspendLayout();
            this.pn_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AllowToggling = false;
            this.btn_dangNhap.AnimationSpeed = 200;
            this.btn_dangNhap.AutoGenerateColors = false;
            this.btn_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangNhap.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.btn_dangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dangNhap.BackgroundImage")));
            this.btn_dangNhap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangNhap.ButtonText = "Đăng Nhập";
            this.btn_dangNhap.ButtonTextMarginLeft = 0;
            this.btn_dangNhap.ColorContrastOnClick = 45;
            this.btn_dangNhap.ColorContrastOnHover = 45;
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_dangNhap.CustomizableEdges = borderEdges1;
            this.btn_dangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dangNhap.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_dangNhap.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dangNhap.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dangNhap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dangNhap.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangNhap.IconMarginLeft = 11;
            this.btn_dangNhap.IconPadding = 10;
            this.btn_dangNhap.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangNhap.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dangNhap.IdleBorderRadius = 43;
            this.btn_dangNhap.IdleBorderThickness = 1;
            this.btn_dangNhap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.btn_dangNhap.IdleIconLeftImage = null;
            this.btn_dangNhap.IdleIconRightImage = null;
            this.btn_dangNhap.IndicateFocus = false;
            this.btn_dangNhap.Location = new System.Drawing.Point(39, 416);
            this.btn_dangNhap.Name = "btn_dangNhap";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 43;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_dangNhap.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 43;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_dangNhap.OnPressedState = stateProperties2;
            this.btn_dangNhap.Size = new System.Drawing.Size(234, 48);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangNhap.TextMarginLeft = 0;
            this.btn_dangNhap.UseDefaultRadiusAndThickness = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // lb_loginTitle
            // 
            this.lb_loginTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_loginTitle.AutoSize = true;
            this.lb_loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_loginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginTitle.Location = new System.Drawing.Point(53, 27);
            this.lb_loginTitle.Name = "lb_loginTitle";
            this.lb_loginTitle.Size = new System.Drawing.Size(209, 45);
            this.lb_loginTitle.TabIndex = 1;
            this.lb_loginTitle.Text = "ĐĂNG NHẬP";
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_matKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matKhau.Location = new System.Drawing.Point(34, 246);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(77, 21);
            this.lb_matKhau.TabIndex = 101;
            this.lb_matKhau.Text = "Mật khẩu";
            // 
            // lb_tenTaiKhoan
            // 
            this.lb_tenTaiKhoan.AutoSize = true;
            this.lb_tenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenTaiKhoan.Location = new System.Drawing.Point(34, 154);
            this.lb_tenTaiKhoan.Name = "lb_tenTaiKhoan";
            this.lb_tenTaiKhoan.Size = new System.Drawing.Size(107, 21);
            this.lb_tenTaiKhoan.TabIndex = 101;
            this.lb_tenTaiKhoan.Text = "Tên tài khoản";
            // 
            // txt_tenTaiKhoan
            // 
            this.txt_tenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txt_tenTaiKhoan.Depth = 0;
            this.txt_tenTaiKhoan.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenTaiKhoan.Hint = "";
            this.txt_tenTaiKhoan.Location = new System.Drawing.Point(39, 178);
            this.txt_tenTaiKhoan.MaxLength = 32767;
            this.txt_tenTaiKhoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tenTaiKhoan.Name = "txt_tenTaiKhoan";
            this.txt_tenTaiKhoan.PasswordChar = '\0';
            this.txt_tenTaiKhoan.SelectedText = "";
            this.txt_tenTaiKhoan.SelectionLength = 0;
            this.txt_tenTaiKhoan.SelectionStart = 0;
            this.txt_tenTaiKhoan.Size = new System.Drawing.Size(236, 23);
            this.txt_tenTaiKhoan.TabIndex = 0;
            this.txt_tenTaiKhoan.TabStop = false;
            this.txt_tenTaiKhoan.UseSystemPasswordChar = false;
            this.txt_tenTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_Keypress);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.Color.White;
            this.txt_matKhau.Depth = 0;
            this.txt_matKhau.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Hint = "";
            this.txt_matKhau.Location = new System.Drawing.Point(37, 270);
            this.txt_matKhau.MaxLength = 32767;
            this.txt_matKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.PasswordChar = '\0';
            this.txt_matKhau.SelectedText = "";
            this.txt_matKhau.SelectionLength = 0;
            this.txt_matKhau.SelectionStart = 0;
            this.txt_matKhau.Size = new System.Drawing.Size(236, 23);
            this.txt_matKhau.TabIndex = 1;
            this.txt_matKhau.TabStop = false;
            this.txt_matKhau.UseSystemPasswordChar = true;
            this.txt_matKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_Keypress);
            // 
            // lb_slogan
            // 
            this.lb_slogan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_slogan.AutoSize = true;
            this.lb_slogan.BackColor = System.Drawing.Color.Transparent;
            this.lb_slogan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slogan.ForeColor = System.Drawing.Color.White;
            this.lb_slogan.Location = new System.Drawing.Point(15, 48);
            this.lb_slogan.Name = "lb_slogan";
            this.lb_slogan.Size = new System.Drawing.Size(200, 23);
            this.lb_slogan.TabIndex = 7;
            this.lb_slogan.Text = "Phòng trọ là nhà của bạn";
            // 
            // lb_brand
            // 
            this.lb_brand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_brand.AutoSize = true;
            this.lb_brand.BackColor = System.Drawing.Color.Transparent;
            this.lb_brand.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_brand.ForeColor = System.Drawing.Color.White;
            this.lb_brand.Location = new System.Drawing.Point(12, 9);
            this.lb_brand.Name = "lb_brand";
            this.lb_brand.Size = new System.Drawing.Size(222, 39);
            this.lb_brand.TabIndex = 6;
            this.lb_brand.Text = "OCEAN HOSTEL";
            // 
            // pn_left
            // 
            this.pn_left.BackColor = System.Drawing.Color.Snow;
            this.pn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_left.Controls.Add(this.pn_imageSlider);
            this.pn_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left.Location = new System.Drawing.Point(0, 0);
            this.pn_left.Name = "pn_left";
            this.pn_left.Size = new System.Drawing.Size(614, 497);
            this.pn_left.TabIndex = 102;
            this.pn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // pn_imageSlider
            // 
            this.pn_imageSlider.BackColor = System.Drawing.Color.Transparent;
            this.pn_imageSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_imageSlider.Controls.Add(this.pn_colorLayer);
            this.pn_imageSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_imageSlider.Location = new System.Drawing.Point(0, 0);
            this.pn_imageSlider.Name = "pn_imageSlider";
            this.pn_imageSlider.Size = new System.Drawing.Size(614, 497);
            this.pn_imageSlider.TabIndex = 8;
            // 
            // pn_colorLayer
            // 
            this.pn_colorLayer.BackColor = System.Drawing.Color.Transparent;
            this.pn_colorLayer.BackgroundImage = global::GUI.Properties.Resources.ColorLayer;
            this.pn_colorLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_colorLayer.Controls.Add(this.lb_brand);
            this.pn_colorLayer.Controls.Add(this.lb_slogan);
            this.pn_colorLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_colorLayer.Location = new System.Drawing.Point(0, 0);
            this.pn_colorLayer.Name = "pn_colorLayer";
            this.pn_colorLayer.Size = new System.Drawing.Size(614, 497);
            this.pn_colorLayer.TabIndex = 9;
            this.pn_colorLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            // 
            // pn_right
            // 
            this.pn_right.BackColor = System.Drawing.Color.White;
            this.pn_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_right.BackgroundImage")));
            this.pn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_right.Controls.Add(this.btn_cancel);
            this.pn_right.Controls.Add(this.btn_dangNhap);
            this.pn_right.Controls.Add(this.lb_loginTitle);
            this.pn_right.Controls.Add(this.txt_matKhau);
            this.pn_right.Controls.Add(this.lb_matKhau);
            this.pn_right.Controls.Add(this.txt_tenTaiKhoan);
            this.pn_right.Controls.Add(this.lb_tenTaiKhoan);
            this.pn_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_right.GradientBottomLeft = System.Drawing.Color.White;
            this.pn_right.GradientBottomRight = System.Drawing.Color.White;
            this.pn_right.GradientTopLeft = System.Drawing.Color.White;
            this.pn_right.GradientTopRight = System.Drawing.Color.White;
            this.pn_right.Location = new System.Drawing.Point(613, 0);
            this.pn_right.Name = "pn_right";
            this.pn_right.Quality = 10;
            this.pn_right.Size = new System.Drawing.Size(302, 497);
            this.pn_right.TabIndex = 11;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancel.Location = new System.Drawing.Point(267, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(35, 35);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "×";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 497);
            this.Controls.Add(this.pn_left);
            this.Controls.Add(this.pn_right);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.pn_left.ResumeLayout(false);
            this.pn_imageSlider.ResumeLayout(false);
            this.pn_colorLayer.ResumeLayout(false);
            this.pn_colorLayer.PerformLayout();
            this.pn_right.ResumeLayout(false);
            this.pn_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_loginTitle;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.Label lb_tenTaiKhoan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tenTaiKhoan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_matKhau;
        private System.Windows.Forms.Label lb_slogan;
        private System.Windows.Forms.Label lb_brand;
        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Panel pn_colorLayer;
        private System.Windows.Forms.Panel pn_imageSlider;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dangNhap;
        private Bunifu.Framework.UI.BunifuGradientPanel pn_right;
        private System.Windows.Forms.Label btn_cancel;
    }
}