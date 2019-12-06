namespace GUI.ChildrenForms.QuanLyThietBi.PhanBoThietBi
{
    partial class fPhanBoThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanBoThietBi));
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
            this.gridControl_thietBiPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView_thietBiPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lb_tenPhong = new System.Windows.Forms.Label();
            this.lb_khuTang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lamMoi = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_xoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_them = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_khuTang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_thietBiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_thietBiPhong)).BeginInit();
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
            this.treeList_khuTang.TabIndex = 3;
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
            this.panel1.Controls.Add(this.gridControl_thietBiPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 364);
            this.panel1.TabIndex = 4;
            // 
            // gridControl_thietBiPhong
            // 
            this.gridControl_thietBiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_thietBiPhong.Location = new System.Drawing.Point(0, 0);
            this.gridControl_thietBiPhong.MainView = this.gridView_thietBiPhong;
            this.gridControl_thietBiPhong.Name = "gridControl_thietBiPhong";
            this.gridControl_thietBiPhong.Size = new System.Drawing.Size(728, 364);
            this.gridControl_thietBiPhong.TabIndex = 1;
            this.gridControl_thietBiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_thietBiPhong});
            // 
            // gridView_thietBiPhong
            // 
            this.gridView_thietBiPhong.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView_thietBiPhong.Appearance.EvenRow.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.gridView_thietBiPhong.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView_thietBiPhong.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gridView_thietBiPhong.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView_thietBiPhong.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView_thietBiPhong.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView_thietBiPhong.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.gridView_thietBiPhong.Appearance.FocusedRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView_thietBiPhong.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView_thietBiPhong.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_thietBiPhong.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_thietBiPhong.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView_thietBiPhong.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView_thietBiPhong.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_thietBiPhong.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView_thietBiPhong.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView_thietBiPhong.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_thietBiPhong.GridControl = this.gridControl_thietBiPhong;
            this.gridView_thietBiPhong.Name = "gridView_thietBiPhong";
            this.gridView_thietBiPhong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_thietBiPhong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_thietBiPhong.OptionsBehavior.Editable = false;
            this.gridView_thietBiPhong.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView_thietBiPhong.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_thietBiPhong.OptionsSelection.MultiSelect = true;
            this.gridView_thietBiPhong.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_thietBiPhong.OptionsView.EnableAppearanceEvenRow = true;
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
            this.bunifuGradientPanel2.Controls.Add(this.btn_xoa);
            this.bunifuGradientPanel2.Controls.Add(this.btn_them);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(193, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(728, 143);
            this.bunifuGradientPanel2.TabIndex = 8;
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
            this.lb_khuTang.Location = new System.Drawing.Point(396, 22);
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
            this.btn_lamMoi.Location = new System.Drawing.Point(548, 83);
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
            // btn_xoa
            // 
            this.btn_xoa.AllowToggling = false;
            this.btn_xoa.AnimationSpeed = 200;
            this.btn_xoa.AutoGenerateColors = false;
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BackColor1 = System.Drawing.Color.Crimson;
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_xoa.ButtonText = "Gỡ thiết bị";
            this.btn_xoa.ButtonTextMarginLeft = 0;
            this.btn_xoa.ColorContrastOnClick = 45;
            this.btn_xoa.ColorContrastOnHover = 45;
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_xoa.CustomizableEdges = borderEdges2;
            this.btn_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoa.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_xoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_xoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_xoa.Enabled = false;
            this.btn_xoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.IconMarginLeft = 11;
            this.btn_xoa.IconPadding = 10;
            this.btn_xoa.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.IdleBorderColor = System.Drawing.Color.DeepPink;
            this.btn_xoa.IdleBorderRadius = 3;
            this.btn_xoa.IdleBorderThickness = 1;
            this.btn_xoa.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_xoa.IdleIconLeftImage = null;
            this.btn_xoa.IdleIconRightImage = null;
            this.btn_xoa.IndicateFocus = false;
            this.btn_xoa.Location = new System.Drawing.Point(332, 83);
            this.btn_xoa.Name = "btn_xoa";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_xoa.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_xoa.OnPressedState = stateProperties4;
            this.btn_xoa.Size = new System.Drawing.Size(102, 38);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.TextMarginLeft = 0;
            this.btn_xoa.UseDefaultRadiusAndThickness = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_them.CustomizableEdges = borderEdges3;
            this.btn_them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btn_them.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_them.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_them.Enabled = false;
            this.btn_them.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IconMarginLeft = 11;
            this.btn_them.IconPadding = 10;
            this.btn_them.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.IdleBorderColor = System.Drawing.Color.LawnGreen;
            this.btn_them.IdleBorderRadius = 3;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_them.IdleIconLeftImage = null;
            this.btn_them.IdleIconRightImage = null;
            this.btn_them.IndicateFocus = false;
            this.btn_them.Location = new System.Drawing.Point(107, 83);
            this.btn_them.Name = "btn_them";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_them.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_them.OnPressedState = stateProperties6;
            this.btn_them.Size = new System.Drawing.Size(102, 38);
            this.btn_them.TabIndex = 0;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.TextMarginLeft = 0;
            this.btn_them.UseDefaultRadiusAndThickness = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // fPhanBoThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.treeList_khuTang);
            this.Name = "fPhanBoThietBi";
            this.Text = "Phân bổ thiết bị";
            this.Load += new System.EventHandler(this.fPhanBoThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList_khuTang)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_thietBiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_thietBiPhong)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList_khuTang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn_khuTang;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_lamMoi;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_xoa;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_them;
        private DevExpress.XtraGrid.GridControl gridControl_thietBiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_thietBiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tenPhong;
        private System.Windows.Forms.Label lb_khuTang;


    }
}