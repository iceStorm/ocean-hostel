namespace GUI.ChildrenForms.HeThong
{
    partial class fDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoiMatKhau));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matKhauCu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matKhauMoi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_huy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_luu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lb_hienMatKhauCu = new System.Windows.Forms.Label();
            this.lb_hienMatKhauMoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txt_matKhauCu
            // 
            this.txt_matKhauCu.Depth = 0;
            this.txt_matKhauCu.Hint = "";
            this.txt_matKhauCu.Location = new System.Drawing.Point(173, 41);
            this.txt_matKhauCu.MaxLength = 32767;
            this.txt_matKhauCu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_matKhauCu.Name = "txt_matKhauCu";
            this.txt_matKhauCu.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.txt_matKhauCu.PasswordChar = '\0';
            this.txt_matKhauCu.SelectedText = "";
            this.txt_matKhauCu.SelectionLength = 0;
            this.txt_matKhauCu.SelectionStart = 0;
            this.txt_matKhauCu.Size = new System.Drawing.Size(199, 23);
            this.txt_matKhauCu.TabIndex = 0;
            this.txt_matKhauCu.TabStop = false;
            this.txt_matKhauCu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_matKhauMoi
            // 
            this.txt_matKhauMoi.Depth = 0;
            this.txt_matKhauMoi.Hint = "";
            this.txt_matKhauMoi.Location = new System.Drawing.Point(173, 96);
            this.txt_matKhauMoi.MaxLength = 32767;
            this.txt_matKhauMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_matKhauMoi.Name = "txt_matKhauMoi";
            this.txt_matKhauMoi.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.txt_matKhauMoi.PasswordChar = '\0';
            this.txt_matKhauMoi.SelectedText = "";
            this.txt_matKhauMoi.SelectionLength = 0;
            this.txt_matKhauMoi.SelectionStart = 0;
            this.txt_matKhauMoi.Size = new System.Drawing.Size(199, 23);
            this.txt_matKhauMoi.TabIndex = 1;
            this.txt_matKhauMoi.TabStop = false;
            this.txt_matKhauMoi.UseSystemPasswordChar = true;
            this.txt_matKhauMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_matKhauMoi_MouseDown);
            this.txt_matKhauMoi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_matKhauMoi_MouseUp);
            // 
            // btn_huy
            // 
            this.btn_huy.AllowToggling = false;
            this.btn_huy.AnimationSpeed = 200;
            this.btn_huy.AutoGenerateColors = false;
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BackColor1 = System.Drawing.Color.Crimson;
            this.btn_huy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_huy.BackgroundImage")));
            this.btn_huy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huy.ButtonText = "Huỷ";
            this.btn_huy.ButtonTextMarginLeft = 0;
            this.btn_huy.ColorContrastOnClick = 45;
            this.btn_huy.ColorContrastOnHover = 45;
            this.btn_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_huy.CustomizableEdges = borderEdges5;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_huy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IconMarginLeft = 11;
            this.btn_huy.IconPadding = 10;
            this.btn_huy.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_huy.IdleBorderRadius = 3;
            this.btn_huy.IdleBorderThickness = 1;
            this.btn_huy.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_huy.IdleIconLeftImage = null;
            this.btn_huy.IdleIconRightImage = null;
            this.btn_huy.IndicateFocus = false;
            this.btn_huy.Location = new System.Drawing.Point(247, 219);
            this.btn_huy.Name = "btn_huy";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.BorderRadius = 3;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btn_huy.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.BorderRadius = 3;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.btn_huy.OnPressedState = stateProperties10;
            this.btn_huy.Size = new System.Drawing.Size(125, 45);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.TextMarginLeft = 0;
            this.btn_huy.UseDefaultRadiusAndThickness = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AllowToggling = false;
            this.btn_luu.AnimationSpeed = 200;
            this.btn_luu.AutoGenerateColors = false;
            this.btn_luu.BackColor = System.Drawing.Color.Transparent;
            this.btn_luu.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btn_luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_luu.BackgroundImage")));
            this.btn_luu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_luu.ButtonText = "Lưu";
            this.btn_luu.ButtonTextMarginLeft = 0;
            this.btn_luu.ColorContrastOnClick = 45;
            this.btn_luu.ColorContrastOnHover = 45;
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_luu.CustomizableEdges = borderEdges6;
            this.btn_luu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_luu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_luu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_luu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_luu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.IconMarginLeft = 11;
            this.btn_luu.IconPadding = 10;
            this.btn_luu.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btn_luu.IdleBorderRadius = 3;
            this.btn_luu.IdleBorderThickness = 1;
            this.btn_luu.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_luu.IdleIconLeftImage = null;
            this.btn_luu.IdleIconRightImage = null;
            this.btn_luu.IndicateFocus = false;
            this.btn_luu.Location = new System.Drawing.Point(67, 219);
            this.btn_luu.Name = "btn_luu";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.BorderRadius = 3;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.btn_luu.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.BorderRadius = 3;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.btn_luu.OnPressedState = stateProperties12;
            this.btn_luu.Size = new System.Drawing.Size(125, 45);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_luu.TextMarginLeft = 0;
            this.btn_luu.UseDefaultRadiusAndThickness = true;
            // 
            // lb_hienMatKhauCu
            // 
            this.lb_hienMatKhauCu.AutoSize = true;
            this.lb_hienMatKhauCu.Location = new System.Drawing.Point(378, 46);
            this.lb_hienMatKhauCu.Name = "lb_hienMatKhauCu";
            this.lb_hienMatKhauCu.Size = new System.Drawing.Size(13, 13);
            this.lb_hienMatKhauCu.TabIndex = 4;
            this.lb_hienMatKhauCu.Text = "x";
            this.lb_hienMatKhauCu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_hienMatKhauCu_MouseDown);
            this.lb_hienMatKhauCu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_hienMatKhauCu_MouseUp);
            // 
            // lb_hienMatKhauMoi
            // 
            this.lb_hienMatKhauMoi.AutoSize = true;
            this.lb_hienMatKhauMoi.Location = new System.Drawing.Point(378, 101);
            this.lb_hienMatKhauMoi.Name = "lb_hienMatKhauMoi";
            this.lb_hienMatKhauMoi.Size = new System.Drawing.Size(13, 13);
            this.lb_hienMatKhauMoi.TabIndex = 4;
            this.lb_hienMatKhauMoi.Text = "x";
            this.lb_hienMatKhauMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_matKhauMoi_MouseDown);
            this.lb_hienMatKhauMoi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_matKhauMoi_MouseUp);
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 297);
            this.Controls.Add(this.lb_hienMatKhauMoi);
            this.Controls.Add(this.lb_hienMatKhauCu);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_matKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matKhauCu);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_matKhauCu;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_matKhauMoi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_luu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huy;
        private System.Windows.Forms.Label lb_hienMatKhauCu;
        private System.Windows.Forms.Label lb_hienMatKhauMoi;
    }
}