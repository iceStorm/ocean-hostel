namespace GUI.ChildrenForms.KhachTro.HopDong.ThemHopDong
{
    partial class fThemHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHopDong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_thongTinKhach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.num_thoiHan = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_phong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_tienCoc = new DevExpress.XtraEditors.SpinEdit();
            this.btn_huy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_chinhSua = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_themKhachMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_tao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MAKHACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANCUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_thoiHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tienCoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_thongTinKhach);
            this.groupControl1.Location = new System.Drawing.Point(31, 117);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(775, 205);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin khách trọ";
            // 
            // dgv_thongTinKhach
            // 
            this.dgv_thongTinKhach.AllowUserToAddRows = false;
            this.dgv_thongTinKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongTinKhach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_thongTinKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_thongTinKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongTinKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHACH,
            this.HO,
            this.TEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.QUEQUAN,
            this.CANCUOC,
            this.DIENTHOAI});
            this.dgv_thongTinKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_thongTinKhach.Location = new System.Drawing.Point(2, 23);
            this.dgv_thongTinKhach.Name = "dgv_thongTinKhach";
            this.dgv_thongTinKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongTinKhach.Size = new System.Drawing.Size(771, 180);
            this.dgv_thongTinKhach.TabIndex = 0;
            this.dgv_thongTinKhach.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_thongTinKhach_RowsRemoved);
            this.dgv_thongTinKhach.SelectionChanged += new System.EventHandler(this.dgv_thongTinKhach_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thời hạn";
            // 
            // num_thoiHan
            // 
            this.num_thoiHan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_thoiHan.Location = new System.Drawing.Point(105, 27);
            this.num_thoiHan.Name = "num_thoiHan";
            this.num_thoiHan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.num_thoiHan.Properties.Appearance.Options.UseFont = true;
            this.num_thoiHan.Properties.Appearance.Options.UseTextOptions = true;
            this.num_thoiHan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.num_thoiHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.num_thoiHan.Properties.IsFloatValue = false;
            this.num_thoiHan.Properties.Mask.EditMask = "N00";
            this.num_thoiHan.Size = new System.Drawing.Size(100, 26);
            this.num_thoiHan.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label2.Location = new System.Drawing.Point(211, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phòng";
            // 
            // cb_phong
            // 
            this.cb_phong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_phong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_phong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.Location = new System.Drawing.Point(428, 27);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.Size = new System.Drawing.Size(100, 28);
            this.cb_phong.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label4.Location = new System.Drawing.Point(633, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiền cọc";
            // 
            // num_tienCoc
            // 
            this.num_tienCoc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_tienCoc.Location = new System.Drawing.Point(704, 27);
            this.num_tienCoc.Name = "num_tienCoc";
            this.num_tienCoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.num_tienCoc.Properties.Appearance.Options.UseFont = true;
            this.num_tienCoc.Properties.Appearance.Options.UseTextOptions = true;
            this.num_tienCoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.num_tienCoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.num_tienCoc.Properties.IsFloatValue = false;
            this.num_tienCoc.Properties.Mask.EditMask = "N00";
            this.num_tienCoc.Size = new System.Drawing.Size(100, 26);
            this.num_tienCoc.TabIndex = 11;
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
            this.btn_huy.IdleBorderColor = System.Drawing.Color.IndianRed;
            this.btn_huy.IdleBorderRadius = 6;
            this.btn_huy.IdleBorderThickness = 1;
            this.btn_huy.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_huy.IdleIconLeftImage = null;
            this.btn_huy.IdleIconRightImage = null;
            this.btn_huy.IndicateFocus = false;
            this.btn_huy.Location = new System.Drawing.Point(30, 361);
            this.btn_huy.Name = "btn_huy";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 6;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_huy.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 6;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_huy.OnPressedState = stateProperties2;
            this.btn_huy.Size = new System.Drawing.Size(69, 45);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huy.TextMarginLeft = 0;
            this.btn_huy.UseDefaultRadiusAndThickness = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_chinhSua
            // 
            this.btn_chinhSua.AllowToggling = false;
            this.btn_chinhSua.AnimationSpeed = 200;
            this.btn_chinhSua.AutoGenerateColors = false;
            this.btn_chinhSua.BackColor = System.Drawing.Color.Transparent;
            this.btn_chinhSua.BackColor1 = System.Drawing.Color.Orange;
            this.btn_chinhSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chinhSua.BackgroundImage")));
            this.btn_chinhSua.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_chinhSua.ButtonText = "Chỉnh sửa";
            this.btn_chinhSua.ButtonTextMarginLeft = 0;
            this.btn_chinhSua.ColorContrastOnClick = 45;
            this.btn_chinhSua.ColorContrastOnHover = 45;
            this.btn_chinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_chinhSua.CustomizableEdges = borderEdges2;
            this.btn_chinhSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_chinhSua.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_chinhSua.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_chinhSua.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_chinhSua.Enabled = false;
            this.btn_chinhSua.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_chinhSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_chinhSua.ForeColor = System.Drawing.Color.White;
            this.btn_chinhSua.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chinhSua.IconMarginLeft = 11;
            this.btn_chinhSua.IconPadding = 10;
            this.btn_chinhSua.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chinhSua.IdleBorderColor = System.Drawing.Color.Gold;
            this.btn_chinhSua.IdleBorderRadius = 6;
            this.btn_chinhSua.IdleBorderThickness = 1;
            this.btn_chinhSua.IdleFillColor = System.Drawing.Color.Orange;
            this.btn_chinhSua.IdleIconLeftImage = null;
            this.btn_chinhSua.IdleIconRightImage = null;
            this.btn_chinhSua.IndicateFocus = false;
            this.btn_chinhSua.Location = new System.Drawing.Point(194, 361);
            this.btn_chinhSua.Name = "btn_chinhSua";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 6;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_chinhSua.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 6;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_chinhSua.OnPressedState = stateProperties4;
            this.btn_chinhSua.Size = new System.Drawing.Size(140, 45);
            this.btn_chinhSua.TabIndex = 9;
            this.btn_chinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chinhSua.TextMarginLeft = 0;
            this.btn_chinhSua.UseDefaultRadiusAndThickness = true;
            this.btn_chinhSua.Click += new System.EventHandler(this.btn_chinhSua_Click);
            // 
            // btn_themKhachMoi
            // 
            this.btn_themKhachMoi.AllowToggling = false;
            this.btn_themKhachMoi.AnimationSpeed = 200;
            this.btn_themKhachMoi.AutoGenerateColors = false;
            this.btn_themKhachMoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_themKhachMoi.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btn_themKhachMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_themKhachMoi.BackgroundImage")));
            this.btn_themKhachMoi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_themKhachMoi.ButtonText = "Thêm khách";
            this.btn_themKhachMoi.ButtonTextMarginLeft = 0;
            this.btn_themKhachMoi.ColorContrastOnClick = 45;
            this.btn_themKhachMoi.ColorContrastOnHover = 45;
            this.btn_themKhachMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_themKhachMoi.CustomizableEdges = borderEdges3;
            this.btn_themKhachMoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themKhachMoi.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_themKhachMoi.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_themKhachMoi.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_themKhachMoi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_themKhachMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_themKhachMoi.ForeColor = System.Drawing.Color.White;
            this.btn_themKhachMoi.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themKhachMoi.IconMarginLeft = 11;
            this.btn_themKhachMoi.IconPadding = 10;
            this.btn_themKhachMoi.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themKhachMoi.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btn_themKhachMoi.IdleBorderRadius = 6;
            this.btn_themKhachMoi.IdleBorderThickness = 1;
            this.btn_themKhachMoi.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_themKhachMoi.IdleIconLeftImage = null;
            this.btn_themKhachMoi.IdleIconRightImage = null;
            this.btn_themKhachMoi.IndicateFocus = false;
            this.btn_themKhachMoi.Location = new System.Drawing.Point(429, 361);
            this.btn_themKhachMoi.Name = "btn_themKhachMoi";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 6;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_themKhachMoi.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 6;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_themKhachMoi.OnPressedState = stateProperties6;
            this.btn_themKhachMoi.Size = new System.Drawing.Size(140, 45);
            this.btn_themKhachMoi.TabIndex = 9;
            this.btn_themKhachMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_themKhachMoi.TextMarginLeft = 0;
            this.btn_themKhachMoi.UseDefaultRadiusAndThickness = true;
            this.btn_themKhachMoi.Click += new System.EventHandler(this.btn_themKhachMoi_Click);
            // 
            // btn_tao
            // 
            this.btn_tao.AllowToggling = false;
            this.btn_tao.AnimationSpeed = 200;
            this.btn_tao.AutoGenerateColors = false;
            this.btn_tao.BackColor = System.Drawing.Color.Transparent;
            this.btn_tao.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_tao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tao.BackgroundImage")));
            this.btn_tao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_tao.ButtonText = "Lưu hợp đồng";
            this.btn_tao.ButtonTextMarginLeft = 0;
            this.btn_tao.ColorContrastOnClick = 45;
            this.btn_tao.ColorContrastOnHover = 45;
            this.btn_tao.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_tao.CustomizableEdges = borderEdges4;
            this.btn_tao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_tao.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_tao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_tao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_tao.Enabled = false;
            this.btn_tao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_tao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_tao.ForeColor = System.Drawing.Color.White;
            this.btn_tao.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tao.IconMarginLeft = 11;
            this.btn_tao.IconPadding = 10;
            this.btn_tao.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tao.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_tao.IdleBorderRadius = 6;
            this.btn_tao.IdleBorderThickness = 1;
            this.btn_tao.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_tao.IdleIconLeftImage = null;
            this.btn_tao.IdleIconRightImage = null;
            this.btn_tao.IndicateFocus = false;
            this.btn_tao.Location = new System.Drawing.Point(666, 361);
            this.btn_tao.Name = "btn_tao";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.BorderRadius = 6;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btn_tao.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 6;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btn_tao.OnPressedState = stateProperties8;
            this.btn_tao.Size = new System.Drawing.Size(140, 45);
            this.btn_tao.TabIndex = 9;
            this.btn_tao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tao.TextMarginLeft = 0;
            this.btn_tao.UseDefaultRadiusAndThickness = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // MAKHACH
            // 
            this.MAKHACH.HeaderText = "MAKHACH";
            this.MAKHACH.Name = "MAKHACH";
            this.MAKHACH.Visible = false;
            // 
            // HO
            // 
            this.HO.HeaderText = "Họ";
            this.HO.Name = "HO";
            this.HO.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.HeaderText = "Tên";
            this.TEN.Name = "TEN";
            // 
            // GIOITINH
            // 
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.HeaderText = "Quê quán";
            this.QUEQUAN.Name = "QUEQUAN";
            this.QUEQUAN.ReadOnly = true;
            // 
            // CANCUOC
            // 
            this.CANCUOC.HeaderText = "Số căn cước";
            this.CANCUOC.Name = "CANCUOC";
            this.CANCUOC.ReadOnly = true;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.HeaderText = "Số điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.ReadOnly = true;
            // 
            // fThemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 431);
            this.Controls.Add(this.cb_phong);
            this.Controls.Add(this.num_tienCoc);
            this.Controls.Add(this.num_thoiHan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_chinhSua);
            this.Controls.Add(this.btn_themKhachMoi);
            this.Controls.Add(this.btn_tao);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fThemHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hợp đồng thuê phòng";
            this.Load += new System.EventHandler(this.fThemHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_thoiHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tienCoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_tao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit num_thoiHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_phong;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit num_tienCoc;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_themKhachMoi;
        private System.Windows.Forms.DataGridView dgv_thongTinKhach;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_chinhSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANCUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
    }
}