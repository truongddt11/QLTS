namespace GUI_QLTS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.HethongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhmucMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoanthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhvienMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ThuhocphiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HethongMenu,
            this.DanhmucMenu,
            this.SinhvienMenu,
            this.ThuhocphiMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // HethongMenu
            // 
            this.HethongMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoimatkhau,
            this.mnuDangnhap,
            this.mnuDangxuat,
            this.mnuThoat});
            this.HethongMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.HethongMenu.Name = "HethongMenu";
            this.HethongMenu.Size = new System.Drawing.Size(63, 20);
            this.HethongMenu.Text = "&Hệ thống";
            // 
            // mnuDoimatkhau
            // 
            this.mnuDoimatkhau.Name = "mnuDoimatkhau";
            this.mnuDoimatkhau.Size = new System.Drawing.Size(152, 22);
            this.mnuDoimatkhau.Text = "Đổi mật khẩu";
            this.mnuDoimatkhau.Click += new System.EventHandler(this.mnuDoimatkhau_Click);
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(152, 22);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(152, 22);
            this.mnuDangxuat.Text = "Đăng xuất";
            this.mnuDangxuat.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(152, 22);
            this.mnuThoat.Text = "Th&oát";
            this.mnuThoat.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // DanhmucMenu
            // 
            this.DanhmucMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuKhoanthu,
            this.mnuNhanvien});
            this.DanhmucMenu.Name = "DanhmucMenu";
            this.DanhmucMenu.Size = new System.Drawing.Size(66, 20);
            this.DanhmucMenu.Text = "&Danh mục";
            // 
            // mnuLop
            // 
            this.mnuLop.Image = ((System.Drawing.Image)(resources.GetObject("mnuLop.Image")));
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(134, 22);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuKhoanthu
            // 
            //this.mnuKhoanthu.Image = global::QLTHUHOCPHI.UI.Properties.Resources.hanghoa;
            this.mnuKhoanthu.Name = "mnuKhoanthu";
            this.mnuKhoanthu.Size = new System.Drawing.Size(134, 22);
            this.mnuKhoanthu.Text = "Khoản thu";
            this.mnuKhoanthu.Click += new System.EventHandler(this.mnuKhoanthu_Click);
            // 
            // mnuNhanvien
            // 
            //this.mnuNhanvien.Image = global::QLTHUHOCPHI.UI.Properties.Resources.Text;
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(134, 22);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // SinhvienMenu
            // 
            this.SinhvienMenu.Name = "SinhvienMenu";
            this.SinhvienMenu.Size = new System.Drawing.Size(62, 20);
            this.SinhvienMenu.Text = "&Sinh viên";
            this.SinhvienMenu.Click += new System.EventHandler(this.SinhvienMenu_Click);
            // 
            // ThuhocphiMenu
            // 
            this.ThuhocphiMenu.Name = "ThuhocphiMenu";
            this.ThuhocphiMenu.Size = new System.Drawing.Size(74, 20);
            this.ThuhocphiMenu.Text = "&Thu học phí";
            this.ThuhocphiMenu.Click += new System.EventHandler(this.ThuhocphiMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp,
            this.toolStripSeparator8,
            this.mnuAbout});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(58, 20);
            this.helpMenu.Text = "Trợ giú&p";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHelp.Size = new System.Drawing.Size(211, 22);
            this.mnuHelp.Text = "&Nội dung trợ giúp";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuAbout
            // 
            //this.mnuAbout.Image = global::QLTHUHOCPHI.UI.Properties.Resources.Info;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(211, 22);
            this.mnuAbout.Text = "&G&iới thiệu.";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AllowDrop = true;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(632, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "ToolStrip";
            // 
            // toolStripButton1
            // 
            //this.toolStripButton1.Image = global::QLTHUHOCPHI.UI.Properties.Resources.Search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "Tìm kiếm";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton2.Text = "Báo cáo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Quản lý thu học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem HethongMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem DanhmucMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoanthu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem SinhvienMenu;
        private System.Windows.Forms.ToolStripMenuItem ThuhocphiMenu;
    }
}



