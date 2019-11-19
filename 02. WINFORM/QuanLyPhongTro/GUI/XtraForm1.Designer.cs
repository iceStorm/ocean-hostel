namespace GUI
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(487, 262);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(487, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(487, 262);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Page 1";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 312);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "XtraForm1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;

    }
}