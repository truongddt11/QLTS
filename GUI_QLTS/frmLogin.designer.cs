namespace GUI_QLTS
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaychu = new System.Windows.Forms.ComboBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCSDL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTypeConnect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSApass = new System.Windows.Forms.Label();
            this.txtPassSA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn máy chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMaychu
            // 
            this.cboMaychu.FormattingEnabled = true;
            this.cboMaychu.Location = new System.Drawing.Point(192, 64);
            this.cboMaychu.Name = "cboMaychu";
            this.cboMaychu.Size = new System.Drawing.Size(168, 21);
            this.cboMaychu.TabIndex = 3;
            this.cboMaychu.Text = "DDT-THINKPAD-PC\\SQLEXPRESS";
            this.cboMaychu.DropDown += new System.EventHandler(this.cboMaychu_DropDown);
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(192, 192);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(168, 20);
            this.txtTendangnhap.TabIndex = 11;
            this.txtTendangnhap.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn CSDL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCSDL
            // 
            this.cboCSDL.FormattingEnabled = true;
            this.cboCSDL.Location = new System.Drawing.Point(192, 96);
            this.cboCSDL.Name = "cboCSDL";
            this.cboCSDL.Size = new System.Drawing.Size(168, 21);
            this.cboCSDL.TabIndex = 5;
            this.cboCSDL.Text = "QLTHUHOCPHI";
            this.cboCSDL.DropDown += new System.EventHandler(this.cboCSDL_DropDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên đăng nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(88, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(192, 224);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(168, 20);
            this.txtMatkhau.TabIndex = 13;
            // 
            // panel1
            // 
            //this.panel1.BackgroundImage = global::QLTHUHOCPHI.UI.Properties.Resources.key2;
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //this.btnCancel.Image = global::QLTHUHOCPHI.UI.Properties.Resources.No;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(280, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            //this.btnOK.Image = global::QLTHUHOCPHI.UI.Properties.Resources.Apply;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(192, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 24);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 56);
            this.panel2.TabIndex = 0;
            // 
            // cboTypeConnect
            // 
            this.cboTypeConnect.FormattingEnabled = true;
            this.cboTypeConnect.Items.AddRange(new object[] {
            "Window",
            "sa"});
            this.cboTypeConnect.Location = new System.Drawing.Point(192, 128);
            this.cboTypeConnect.Name = "cboTypeConnect";
            this.cboTypeConnect.Size = new System.Drawing.Size(168, 21);
            this.cboTypeConnect.TabIndex = 7;
            this.cboTypeConnect.Text = "Window";
            this.cboTypeConnect.SelectedValueChanged += new System.EventHandler(this.cboTypeConnect_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(88, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chế độ đăng nhập";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSApass
            // 
            this.lblSApass.Location = new System.Drawing.Point(88, 160);
            this.lblSApass.Name = "lblSApass";
            this.lblSApass.Size = new System.Drawing.Size(88, 24);
            this.lblSApass.TabIndex = 8;
            this.lblSApass.Text = "Mật khẩu SA";
            this.lblSApass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSApass.Visible = false;
            // 
            // txtPassSA
            // 
            this.txtPassSA.Location = new System.Drawing.Point(192, 160);
            this.txtPassSA.Name = "txtPassSA";
            this.txtPassSA.PasswordChar = '*';
            this.txtPassSA.Size = new System.Drawing.Size(168, 20);
            this.txtPassSA.TabIndex = 9;
            this.txtPassSA.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 288);
            this.Controls.Add(this.lblSApass);
            this.Controls.Add(this.txtPassSA);
            this.Controls.Add(this.cboTypeConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCSDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.cboMaychu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaychu;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCSDL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboTypeConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSApass;
        private System.Windows.Forms.TextBox txtPassSA;
    }
}