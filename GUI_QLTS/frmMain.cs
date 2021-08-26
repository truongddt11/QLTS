using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QLTS
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       
        private void ShowChildForm(Form  frm)
        {

            AddItemMenu();
            CloseAllChildrenForm();

                    frm.MdiParent = this;
                  
                  
                    frm.Padding = new Padding(3, 3, 3, 3);
                    frm.Show  ();
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Maximized ;
                    frm.StartPosition = FormStartPosition.CenterParent;
                    if(frm.Name != "frmViewReport")
                    System.Windows.Forms.ToolStripManager.Merge((ToolStrip)frm.Controls["toolStripMain"], "toolStripMain");
               
        }

        public  void AddItemMenu()
        {
            toolStripMain.Items.Clear();

            ToolStripButton btnTimkiem = new ToolStripButton();
            btnTimkiem.Click += new EventHandler(toolStripButton1_Click);
            //btnTimkiem.Image = global::QLTHUHOCPHI.UI.Properties.Resources.Search;
            btnTimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnTimkiem.Name = "mnuTimkiem";
            btnTimkiem.Size = new System.Drawing.Size(77, 22);
            btnTimkiem.Text = "Tìm kiếm";
            // 
            // toolStripButton2
            // 
            ToolStripButton btnBaocao = new ToolStripButton();
            btnBaocao.Click += new EventHandler(toolStripButton2_Click);
           // btnBaocao.Image = global::QLTHUHOCPHI.UI.Properties.Resources.report_thuphi_icon;
            btnBaocao.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnBaocao.Name = "mnuBaocao";
            btnBaocao.Size = new System.Drawing.Size(69, 22);
            btnBaocao.Text = "Báo cáo";

            
            ToolStripSeparator btnSeparator = new ToolStripSeparator();
            toolStripMain.Items.Add(btnTimkiem);
            toolStripMain.Items.Add(btnBaocao);
            toolStripMain.Items.Add(btnSeparator);
        }

        private void CloseAllChildrenForm()
        {
            foreach (Form frm in this.MdiChildren)
            {

                frm.Close();
            }
        }

        private bool CheckFormClosed(string formName)
        {
            foreach (System.Windows.Forms.Form oControl in this.MdiChildren)
            {
                if (oControl.Name == formName)
                    return true;
            }
            return false;
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            try
            {
                //frmLop frmL = new frmLop();
                //ShowChildForm(frmL);
                //frmL = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void mnuKhoanthu_Click(object sender, EventArgs e)
        {
            try
            {
                //frmKhoanthu frmKT = new frmKhoanthu();
                //ShowChildForm(frmKT);
               //frmKT = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                //frmDanhsachnguoidung frmDSND = new frmDanhsachnguoidung();
                //ShowChildForm(frmDSND);
                //frmDSND = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                menuStrip.Items["DanhmucMenu"].Enabled = true;
                menuStrip.Items["SinhvienMenu"].Enabled = true;
                menuStrip.Items["ThuhocphiMenu"].Enabled = true;
                menuStrip.Items["helpMenu"].Enabled = true ;
                mnuDangnhap.Visible = false ;
                mnuDangxuat.Visible = true;
                mnuDoimatkhau.Visible = true;
                toolStripMain.Enabled = true;
                toolStripStatusLabel.Text = "Trạng thái: Đã kết nối";
            }

        }

        private void Logout()
        {
            CloseAllChildrenForm();
            menuStrip.Items["DanhmucMenu"].Enabled = false;
            menuStrip.Items["SinhvienMenu"].Enabled = false;
            menuStrip.Items["ThuhocphiMenu"].Enabled = false;
            menuStrip.Items["helpMenu"].Enabled = false;
            mnuDangnhap.Visible = true;
            mnuDangxuat.Visible = false;
            mnuDoimatkhau.Visible = false;
            toolStripStatusLabel.Text = "Trạng thái: Ngắt kết nối";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            menuStrip.Items ["DanhmucMenu"].Enabled  = false ;
            menuStrip.Items["SinhvienMenu"].Enabled = false;
            menuStrip.Items["ThuhocphiMenu"].Enabled = false;
            menuStrip.Items["helpMenu"].Enabled = false;           
            mnuDangnhap.Visible = true;
            mnuDangxuat.Visible = false;
            mnuDoimatkhau.Visible = false;
            toolStripMain.Enabled = false ;
            toolStripStatusLabel.Text = "Trạng thái: Ngắt kết nối";
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //frmGioithieu frm = new frmGioithieu();
            //frm.ShowDialog();
            //frm = null;
        }

        

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //frmTimKiem frmTK = new frmTimKiem();
                //frmTK.ShowDialog();
                //ShowChildForm(frmTK);
                //frmTK = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
            //frmViewReport frm = new frmViewReport();
            //ShowChildForm(frm );
            //frm = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void SinhvienMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //frmSinhvien frmSV = new frmSinhvien();
                //ShowChildForm(frmSV);
                //frmSV = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void ThuhocphiMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //frmPhieuthu frmPT = new frmPhieuthu();
                //ShowChildForm(frmPT);
                //frmPT = null;
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void mnuDoimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                //frmDanhsachnguoidung frmDSND = new frmDanhsachnguoidung();
                //ShowChildForm(frmDSND);
                //frmDSND = null;
                //ShowDetail(3);
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

      
    }
}
