namespace GUI.ChildrenForms.DichVu.DichVuMoiPhong
{
    partial class fDichVuMoiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDichVuMoiPhong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.treeList_khuTang = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn_khuTang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_dichVuPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView_dichVuPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.lb_khuTang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lamMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_huyDichVu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_dangKyThem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_khuTang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dichVuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dichVuPhong)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList_khuTang
            // 
            this.treeList_khuTang.Appearance.BandPanel.BackColor = System.Drawing.Color.Transparent;
            this.treeList_khuTang.Appearance.BandPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.treeList_khuTang.Appearance.BandPanel.Options.UseBackColor = true;
            this.treeList_khuTang.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn_khuTang});
            this.treeList_khuTang.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList_khuTang.Location = new System.Drawing.Point(0, 0);
            this.treeList_khuTang.Name = "treeList_khuTang";
            this.treeList_khuTang.OptionsBehavior.Editable = false;
            this.treeList_khuTang.OptionsCustomization.AllowQuickHideColumns = false;
            this.treeList_khuTang.Size = new System.Drawing.Size(193, 507);
            this.treeList_khuTang.TabIndex = 9;
            this.treeList_khuTang.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_khuTang_FocusedNodeChanged);
            // 
            // treeListColumn_khuTang
            // 
            this.treeListColumn_khuTang.Caption = "Chọn khu";
            this.treeListColumn_khuTang.FieldName = "treeListColumn1";
            this.treeListColumn_khuTang.Name = "treeListColumn_khuTang";
            this.treeListColumn_khuTang.Visible = true;
            this.treeListColumn_khuTang.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_dichVuPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 364);
            this.panel1.TabIndex = 10;
            // 
            // gridControl_dichVuPhong
            // 
            this.gridControl_dichVuPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_dichVuPhong.Location = new System.Drawing.Point(0, 0);
            this.gridControl_dichVuPhong.MainView = this.gridView_dichVuPhong;
            this.gridControl_dichVuPhong.Name = "gridControl_dichVuPhong";
            this.gridControl_dichVuPhong.Size = new System.Drawing.Size(728, 364);
            this.gridControl_dichVuPhong.TabIndex = 1;
            this.gridControl_dichVuPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_dichVuPhong});
            // 
            // gridView_dichVuPhong
            // 
            this.gridView_dichVuPhong.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_dichVuPhong.Appearance.EvenRow.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.gridView_dichVuPhong.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_dichVuPhong.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gridView_dichVuPhong.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView_dichVuPhong.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_dichVuPhong.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView_dichVuPhong.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView_dichVuPhong.Appearance.FocusedRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView_dichVuPhong.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView_dichVuPhong.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_dichVuPhong.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_dichVuPhong.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_dichVuPhong.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView_dichVuPhong.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_dichVuPhong.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView_dichVuPhong.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView_dichVuPhong.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_dichVuPhong.GridControl = this.gridControl_dichVuPhong;
            this.gridView_dichVuPhong.Name = "gridView_dichVuPhong";
            this.gridView_dichVuPhong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_dichVuPhong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_dichVuPhong.OptionsBehavior.Editable = false;
            this.gridView_dichVuPhong.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView_dichVuPhong.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_dichVuPhong.OptionsSelection.MultiSelect = true;
            this.gridView_dichVuPhong.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_dichVuPhong.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lb_tenPhong);
            this.bunifuGradientPanel2.Controls.Add(this.lb_khuTang);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.btn_lamMoi);
            this.bunifuGradientPanel2.Controls.Add(this.btn_huyDichVu);
            this.bunifuGradientPanel2.Controls.Add(this.btn_dangKyThem);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(193, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(728, 143);
            this.bunifuGradientPanel2.TabIndex = 11;
            // 
            // lb_tenPhong
            // 
            this.lb_tenPhong.AutoSize = true;
            this.lb_tenPhong.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.lb_tenPhong.Location = new System.Drawing.Point(189, 22);
            this.lb_tenPhong.Name = "lb_tenPhong";
            this.lb_tenPhong.Size = new System.Drawing.Size(20, 25);
            this.lb_tenPhong.TabIndex = 5;
            this.lb_tenPhong.Text = "?";
            this.lb_tenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_khuTang
            // 
            this.lb_khuTang.AutoSize = true;
            this.lb_khuTang.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.lb_khuTang.Location = new System.Drawing.Point(405, 22);
            this.lb_khuTang.Name = "lb_khuTang";
            this.lb_khuTang.Size = new System.Drawing.Size(121, 25);
            this.lb_khuTang.TabIndex = 4;
            this.lb_khuTang.Text = "KHU – TẦNG";
            this.lb_khuTang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.AllowToggling = false;
            this.btn_lamMoi.AnimationSpeed = 200;
            this.btn_lamMoi.AutoGenerateColors = false;
            this.btn_lamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_lamMoi.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_lamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lamMoi.BackgroundImage")));
            this.btn_lamMoi.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_lamMoi.ButtonText = "Làm mới";
            this.btn_lamMoi.ButtonTextMarginLeft = 0;
            this.btn_lamMoi.ColorContrastOnClick = 45;
            this.btn_lamMoi.ColorContrastOnHover = 45;
            this.btn_lamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_lamMoi.CustomizableEdges = borderEdges1;
            this.btn_lamMoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_lamMoi.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_lamMoi.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_lamMoi.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_lamMoi.Enabled = false;
            this.btn_lamMoi.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_lamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_lamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_lamMoi.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lamMoi.IconMarginLeft = 11;
            this.btn_lamMoi.IconPadding = 10;
            this.btn_lamMoi.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lamMoi.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_lamMoi.IdleBorderRadius = 3;
            this.btn_lamMoi.IdleBorderThickness = 1;
            this.btn_lamMoi.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_lamMoi.IdleIconLeftImage = null;
            this.btn_lamMoi.IdleIconRightImage = null;
            this.btn_lamMoi.IndicateFocus = false;
            this.btn_lamMoi.Location = new System.Drawing.Point(519, 83);
            this.btn_lamMoi.Name = "btn_lamMoi";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btn_lamMoi.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btn_lamMoi.OnPressedState = stateProperties2;
            this.btn_lamMoi.Size = new System.Drawing.Size(102, 38);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lamMoi.TextMarginLeft = 0;
            this.btn_lamMoi.UseDefaultRadiusAndThickness = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_huyDichVu
            // 
            this.btn_huyDichVu.AllowToggling = false;
            this.btn_huyDichVu.AnimationSpeed = 200;
            this.btn_huyDichVu.AutoGenerateColors = false;
            this.btn_huyDichVu.BackColor = System.Drawing.Color.Transparent;
            this.btn_huyDichVu.BackColor1 = System.Drawing.Color.Crimson;
            this.btn_huyDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_huyDichVu.BackgroundImage")));
            this.btn_huyDichVu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_huyDichVu.ButtonText = "Huỷ dịch vụ";
            this.btn_huyDichVu.ButtonTextMarginLeft = 0;
            this.btn_huyDichVu.ColorContrastOnClick = 45;
            this.btn_huyDichVu.ColorContrastOnHover = 45;
            this.btn_huyDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_huyDichVu.CustomizableEdges = borderEdges2;
            this.btn_huyDichVu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huyDichVu.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_huyDichVu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_huyDichVu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_huyDichVu.Enabled = false;
            this.btn_huyDichVu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_huyDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_huyDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_huyDichVu.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huyDichVu.IconMarginLeft = 11;
            this.btn_huyDichVu.IconPadding = 10;
            this.btn_huyDichVu.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huyDichVu.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_huyDichVu.IdleBorderRadius = 3;
            this.btn_huyDichVu.IdleBorderThickness = 1;
            this.btn_huyDichVu.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_huyDichVu.IdleIconLeftImage = null;
            this.btn_huyDichVu.IdleIconRightImage = null;
            this.btn_huyDichVu.IndicateFocus = false;
            this.btn_huyDichVu.Location = new System.Drawing.Point(313, 83);
            this.btn_huyDichVu.Name = "btn_huyDichVu";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_huyDichVu.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_huyDichVu.OnPressedState = stateProperties4;
            this.btn_huyDichVu.Size = new System.Drawing.Size(102, 38);
            this.btn_huyDichVu.TabIndex = 2;
            this.btn_huyDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_huyDichVu.TextMarginLeft = 0;
            this.btn_huyDichVu.UseDefaultRadiusAndThickness = true;
            this.btn_huyDichVu.Click += new System.EventHandler(this.btn_huyDichVu_Click);
            // 
            // btn_dangKyThem
            // 
            this.btn_dangKyThem.AllowToggling = false;
            this.btn_dangKyThem.AnimationSpeed = 200;
            this.btn_dangKyThem.AutoGenerateColors = false;
            this.btn_dangKyThem.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangKyThem.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btn_dangKyThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dangKyThem.BackgroundImage")));
            this.btn_dangKyThem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_dangKyThem.ButtonText = "Đăng ký thêm";
            this.btn_dangKyThem.ButtonTextMarginLeft = 0;
            this.btn_dangKyThem.ColorContrastOnClick = 45;
            this.btn_dangKyThem.ColorContrastOnHover = 45;
            this.btn_dangKyThem.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_dangKyThem.CustomizableEdges = borderEdges3;
            this.btn_dangKyThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangKyThem.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_dangKyThem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_dangKyThem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_dangKyThem.Enabled = false;
            this.btn_dangKyThem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_dangKyThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_dangKyThem.ForeColor = System.Drawing.Color.White;
            this.btn_dangKyThem.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangKyThem.IconMarginLeft = 11;
            this.btn_dangKyThem.IconPadding = 10;
            this.btn_dangKyThem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangKyThem.IdleBorderColor = System.Drawing.Color.LawnGreen;
            this.btn_dangKyThem.IdleBorderRadius = 3;
            this.btn_dangKyThem.IdleBorderThickness = 1;
            this.btn_dangKyThem.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_dangKyThem.IdleIconLeftImage = null;
            this.btn_dangKyThem.IdleIconRightImage = null;
            this.btn_dangKyThem.IndicateFocus = false;
            this.btn_dangKyThem.Location = new System.Drawing.Point(107, 83);
            this.btn_dangKyThem.Name = "btn_dangKyThem";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_dangKyThem.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_dangKyThem.OnPressedState = stateProperties6;
            this.btn_dangKyThem.Size = new System.Drawing.Size(102, 38);
            this.btn_dangKyThem.TabIndex = 0;
            this.btn_dangKyThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangKyThem.TextMarginLeft = 0;
            this.btn_dangKyThem.UseDefaultRadiusAndThickness = true;
            this.btn_dangKyThem.Click += new System.EventHandler(this.btn_dangKyThem_Click);
            // 
            // fDichVuMoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.treeList_khuTang);
            this.Name = "fDichVuMoiPhong";
            this.Text = "Dịch vụ mỗi phòng";
            this.Load += new System.EventHandler(this.fDichVuMoiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList_khuTang)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dichVuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dichVuPhong)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList_khuTang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn_khuTang;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_dichVuPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_dichVuPhong;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lb_tenPhong;
        private System.Windows.Forms.Label lb_khuTang;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_lamMoi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_huyDichVu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_dangKyThem;
    }
}