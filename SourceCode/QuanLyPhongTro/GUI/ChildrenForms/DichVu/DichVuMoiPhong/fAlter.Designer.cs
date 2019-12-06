namespace GUI.ChildrenForms.DichVu.DichVuMoiPhong
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.ToggleSwitch.ToggleState toggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState6 = new Bunifu.ToggleSwitch.ToggleState();
            this.cb_tenDichVu = new MetroFramework.Controls.MetroComboBox();
            this.btn_huy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_giaDichVu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.chb_batBuoc = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_tenDichVu
            // 
            this.cb_tenDichVu.BackColor = System.Drawing.Color.White;
            this.cb_tenDichVu.FormattingEnabled = true;
            this.cb_tenDichVu.ItemHeight = 23;
            this.cb_tenDichVu.Location = new System.Drawing.Point(218, 20);
            this.cb_tenDichVu.Name = "cb_tenDichVu";
            this.cb_tenDichVu.Size = new System.Drawing.Size(216, 29);
            this.cb_tenDichVu.Sorted = true;
            this.cb_tenDichVu.TabIndex = 20;
            this.cb_tenDichVu.UseCustomBackColor = true;
            this.cb_tenDichVu.UseSelectable = true;
            this.cb_tenDichVu.SelectedIndexChanged += new System.EventHandler(this.cb_tenDichVu_SelectedIndexChanged);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_huy.CustomizableEdges = borderEdges3;
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
            this.btn_huy.Location = new System.Drawing.Point(290, 257);
            this.btn_huy.Name = "btn_huy";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_huy.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_huy.OnPressedState = stateProperties6;
            this.btn_huy.Size = new System.Drawing.Size(144, 43);
            this.btn_huy.TabIndex = 18;
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_them.CustomizableEdges = borderEdges4;
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
            this.btn_them.Location = new System.Drawing.Point(85, 257);
            this.btn_them.Name = "btn_them";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.BorderRadius = 3;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btn_them.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 3;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btn_them.OnPressedState = stateProperties8;
            this.btn_them.Size = new System.Drawing.Size(144, 43);
            this.btn_them.TabIndex = 17;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TextMarginLeft = 0;
            this.btn_them.UseDefaultRadiusAndThickness = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chọn dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Giá dịch vụ";
            // 
            // txt_giaDichVu
            // 
            this.txt_giaDichVu.Depth = 0;
            this.txt_giaDichVu.Enabled = false;
            this.txt_giaDichVu.Hint = "";
            this.txt_giaDichVu.Location = new System.Drawing.Point(218, 87);
            this.txt_giaDichVu.MaxLength = 32767;
            this.txt_giaDichVu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_giaDichVu.Name = "txt_giaDichVu";
            this.txt_giaDichVu.PasswordChar = '\0';
            this.txt_giaDichVu.SelectedText = "";
            this.txt_giaDichVu.SelectionLength = 0;
            this.txt_giaDichVu.SelectionStart = 0;
            this.txt_giaDichVu.Size = new System.Drawing.Size(163, 23);
            this.txt_giaDichVu.TabIndex = 21;
            this.txt_giaDichVu.TabStop = false;
            this.txt_giaDichVu.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bắt buộc";
            // 
            // chb_batBuoc
            // 
            this.chb_batBuoc.Animation = 5;
            this.chb_batBuoc.BackColor = System.Drawing.Color.Transparent;
            this.chb_batBuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_batBuoc.BackgroundImage")));
            this.chb_batBuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_batBuoc.Enabled = false;
            this.chb_batBuoc.Location = new System.Drawing.Point(218, 148);
            this.chb_batBuoc.Name = "chb_batBuoc";
            this.chb_batBuoc.Size = new System.Drawing.Size(43, 20);
            this.chb_batBuoc.TabIndex = 22;
            toggleState4.BackColor = System.Drawing.Color.Empty;
            toggleState4.BackColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState4.BorderColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderRadius = 1;
            toggleState4.BorderRadiusInner = 1;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.chb_batBuoc.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.Gray;
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.Gray;
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 15;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.chb_batBuoc.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.LimeGreen;
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 15;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.chb_batBuoc.ToggleStateOn = toggleState6;
            this.chb_batBuoc.Value = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "VNĐ";
            // 
            // fAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 332);
            this.Controls.Add(this.chb_batBuoc);
            this.Controls.Add(this.txt_giaDichVu);
            this.Controls.Add(this.cb_tenDichVu);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký dịch vụ mới";
            this.Load += new System.EventHandler(this.fAlter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cb_tenDichVu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_giaDichVu;
        private System.Windows.Forms.Label label2;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch chb_batBuoc;
        private System.Windows.Forms.Label label3;
    }
}