namespace GUI.ChildrenForms.QuanLyPhong.Phong
{
    partial class fAlter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlter));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenPhong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_huy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tenTang = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tenLoaiPhong = new MetroFramework.Controls.MetroComboBox();
            this.chb_dangSuaChua = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_soLuongToiDa = new DevExpress.XtraEditors.SpinEdit();
            this.cb_tenKhu = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuongToiDa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên phòng";
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Depth = 0;
            this.txt_tenPhong.Hint = "";
            this.txt_tenPhong.Location = new System.Drawing.Point(225, 43);
            this.txt_tenPhong.MaxLength = 32767;
            this.txt_tenPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.PasswordChar = '\0';
            this.txt_tenPhong.SelectedText = "";
            this.txt_tenPhong.SelectionLength = 0;
            this.txt_tenPhong.SelectionStart = 0;
            this.txt_tenPhong.Size = new System.Drawing.Size(216, 23);
            this.txt_tenPhong.TabIndex = 11;
            this.txt_tenPhong.TabStop = false;
            this.txt_tenPhong.UseSystemPasswordChar = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_huy.CustomizableEdges = borderEdges1;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_huy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IconMarginLeft = 11;
            this.btn_huy.IconPadding = 10;
            this.btn_huy.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy.IdleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huy.IdleBorderRadius = 3;
            this.btn_huy.IdleBorderThickness = 1;
            this.btn_huy.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_huy.IdleIconLeftImage = null;
            this.btn_huy.IdleIconRightImage = null;
            this.btn_huy.IndicateFocus = false;
            this.btn_huy.Location = new System.Drawing.Point(297, 370);
            this.btn_huy.Name = "btn_huy";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_huy.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_huy.OnPressedState = stateProperties2;
            this.btn_huy.Size = new System.Drawing.Size(144, 43);
            this.btn_huy.TabIndex = 14;
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.TextMarginLeft = 0;
            this.btn_huy.UseDefaultRadiusAndThickness = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.AllowToggling = false;
            this.btn_them.AnimationSpeed = 200;
            this.btn_them.AutoGenerateColors = false;
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_them.ButtonText = "Thêm";
            this.btn_them.ButtonTextMarginLeft = 0;
            this.btn_them.ColorContrastOnClick = 45;
            this.btn_them.ColorContrastOnHover = 45;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_them.CustomizableEdges = borderEdges2;
            this.btn_them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IconMarginLeft = 11;
            this.btn_them.IconPadding = 10;
            this.btn_them.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IdleBorderColor = System.Drawing.Color.Lime;
            this.btn_them.IdleBorderRadius = 3;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_them.IdleIconLeftImage = null;
            this.btn_them.IdleIconRightImage = null;
            this.btn_them.IndicateFocus = false;
            this.btn_them.Location = new System.Drawing.Point(92, 370);
            this.btn_them.Name = "btn_them";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_them.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_them.OnPressedState = stateProperties4;
            this.btn_them.Size = new System.Drawing.Size(144, 43);
            this.btn_them.TabIndex = 13;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TextMarginLeft = 0;
            this.btn_them.UseDefaultRadiusAndThickness = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chọn khu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn tầng";
            // 
            // cb_tenTang
            // 
            this.cb_tenTang.BackColor = System.Drawing.Color.White;
            this.cb_tenTang.FormattingEnabled = true;
            this.cb_tenTang.ItemHeight = 23;
            this.cb_tenTang.Location = new System.Drawing.Point(225, 140);
            this.cb_tenTang.Name = "cb_tenTang";
            this.cb_tenTang.Size = new System.Drawing.Size(216, 29);
            this.cb_tenTang.Sorted = true;
            this.cb_tenTang.TabIndex = 16;
            this.cb_tenTang.UseCustomBackColor = true;
            this.cb_tenTang.UseSelectable = true;
            this.cb_tenTang.SelectedIndexChanged += new System.EventHandler(this.cb_tenTang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại phòng";
            // 
            // cb_tenLoaiPhong
            // 
            this.cb_tenLoaiPhong.BackColor = System.Drawing.Color.White;
            this.cb_tenLoaiPhong.FormattingEnabled = true;
            this.cb_tenLoaiPhong.ItemHeight = 23;
            this.cb_tenLoaiPhong.Location = new System.Drawing.Point(225, 188);
            this.cb_tenLoaiPhong.Name = "cb_tenLoaiPhong";
            this.cb_tenLoaiPhong.Size = new System.Drawing.Size(216, 29);
            this.cb_tenLoaiPhong.Sorted = true;
            this.cb_tenLoaiPhong.TabIndex = 16;
            this.cb_tenLoaiPhong.UseCustomBackColor = true;
            this.cb_tenLoaiPhong.UseSelectable = true;
            this.cb_tenLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cb_loaiPhong_SelectedIndexChanged);
            // 
            // chb_dangSuaChua
            // 
            this.chb_dangSuaChua.Animation = 5;
            this.chb_dangSuaChua.BackColor = System.Drawing.Color.Transparent;
            this.chb_dangSuaChua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_dangSuaChua.BackgroundImage")));
            this.chb_dangSuaChua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_dangSuaChua.Location = new System.Drawing.Point(225, 288);
            this.chb_dangSuaChua.Name = "chb_dangSuaChua";
            this.chb_dangSuaChua.Size = new System.Drawing.Size(43, 20);
            this.chb_dangSuaChua.TabIndex = 17;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.chb_dangSuaChua.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Gray;
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.Gray;
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 15;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.chb_dangSuaChua.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.LimeGreen;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 15;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.chb_dangSuaChua.ToggleStateOn = toggleState3;
            this.chb_dangSuaChua.Value = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đang sửa chữa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượng tối đa";
            // 
            // num_soLuongToiDa
            // 
            this.num_soLuongToiDa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_soLuongToiDa.Location = new System.Drawing.Point(225, 237);
            this.num_soLuongToiDa.Name = "num_soLuongToiDa";
            this.num_soLuongToiDa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.num_soLuongToiDa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_soLuongToiDa.Properties.Appearance.Options.UseBackColor = true;
            this.num_soLuongToiDa.Properties.Appearance.Options.UseFont = true;
            this.num_soLuongToiDa.Properties.Appearance.Options.UseTextOptions = true;
            this.num_soLuongToiDa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.num_soLuongToiDa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.num_soLuongToiDa.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_soLuongToiDa.Size = new System.Drawing.Size(216, 26);
            this.num_soLuongToiDa.TabIndex = 18;
            // 
            // cb_tenKhu
            // 
            this.cb_tenKhu.BackColor = System.Drawing.Color.White;
            this.cb_tenKhu.FormattingEnabled = true;
            this.cb_tenKhu.ItemHeight = 23;
            this.cb_tenKhu.Location = new System.Drawing.Point(225, 92);
            this.cb_tenKhu.Name = "cb_tenKhu";
            this.cb_tenKhu.Size = new System.Drawing.Size(216, 29);
            this.cb_tenKhu.Sorted = true;
            this.cb_tenKhu.TabIndex = 16;
            this.cb_tenKhu.UseCustomBackColor = true;
            this.cb_tenKhu.UseSelectable = true;
            this.cb_tenKhu.SelectedIndexChanged += new System.EventHandler(this.cb_tenKhu_SelectedIndexChanged);
            // 
            // fAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 438);
            this.Controls.Add(this.num_soLuongToiDa);
            this.Controls.Add(this.chb_dangSuaChua);
            this.Controls.Add(this.cb_tenLoaiPhong);
            this.Controls.Add(this.cb_tenKhu);
            this.Controls.Add(this.cb_tenTang);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenPhong);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thông tin phòng";
            this.Load += new System.EventHandler(this.fAlter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_soLuongToiDa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_them;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cb_tenTang;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cb_tenLoaiPhong;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch chb_dangSuaChua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit num_soLuongToiDa;
        private MetroFramework.Controls.MetroComboBox cb_tenKhu;
    }
}