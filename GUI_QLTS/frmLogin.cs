using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;

namespace GUI_QLTS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DataTable GetServerList(bool isLoadLocal)
        {
            if (cboMaychu.DataSource == null)
            {
                DataTable table2;
                table2 = SmoApplication.EnumAvailableSqlServers(isLoadLocal);
                cboMaychu.DataSource = table2;
                cboMaychu.DisplayMember = "Name";
                cboMaychu.ValueMember = "Name";
                return table2;
            }
            return null ;
        }

        public Server GetServer()
        {
            return new Server(new ServerConnection(cboMaychu .Text ));
        }

        public Server GetServer(string userName, string pass)
        {
            return new Server(new ServerConnection(cboMaychu.Text,userName ,pass ));
        }

        public DataTable GetDBList()
        {
            if (cboCSDL.DataSource == null)
            {
                Server m_server =null ;
                if(cboTypeConnect .Text.Trim () == "sa")
                     m_server=  GetServer(cboTypeConnect .Text .Trim (),txtPassSA .Text .Trim ());
                else
                    m_server=GetServer();

                DataTable table = new DataTable("DBList");
                table.Columns.Add("Name");
                foreach (Database database in m_server.Databases)
                {
                    if (!database.IsSystemObject)
                    {
                        DataRow row = table.NewRow();
                        row["Name"] = database.Name;
                        table.Rows.Add(row);
                    }
                }
                cboCSDL.DataSource = table;
                cboCSDL.DisplayMember = "Name";
                cboCSDL.ValueMember = "Name";
                return table;
            }
            return null;
        }

        private void cboMaychu_DropDown(object sender, EventArgs e)
        {
            try
            {
                GetServerList(false);
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void cboCSDL_DropDown(object sender, EventArgs e)
        {
            try
            {
                GetDBList();
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
             
                BuidConnectionString(cboMaychu.Text, cboCSDL.Text);
                if (CheckLogin())
                {
                    clsCommon.UserName = txtTendangnhap.Text;
                    clsCommon.ServerName = cboMaychu.Text;
                    clsCommon.DBName = cboCSDL.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                    clsCommon.ShowMessageException("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }
            catch (Exception ex)
            {
                clsCommon.ShowMessageException(ex.ToString());
            }
        }

        private bool CheckLogin()
        {
            BUS_QLTS.BLCommon oBL = new BUS_QLTS.BLCommon();
            oBL.sSqlConnectionString = clsCommon.SqlConnectionString;
          return   oBL.CheckLogin(txtTendangnhap.Text, txtMatkhau.Text);
        }

        private  string BuidConnectionString(string serverName, string dbName)
        {
            SqlConnectionStringBuilder cnnBuilder = new SqlConnectionStringBuilder();
            cnnBuilder.DataSource = serverName;
            cnnBuilder.InitialCatalog = dbName;
            cnnBuilder.IntegratedSecurity = true;
            cnnBuilder.MultipleActiveResultSets = true;
            clsCommon .SqlConnectionString  = cnnBuilder.ConnectionString;
            return cnnBuilder.ConnectionString;
            //cnnBuilder = null;
        }

        private string BuidConnectionString(string serverName, string dbName,string userName,string pass)
        {
            SqlConnectionStringBuilder cnnBuilder = new SqlConnectionStringBuilder();
            cnnBuilder.DataSource = serverName;
            cnnBuilder.InitialCatalog = dbName;
            cnnBuilder.IntegratedSecurity = true;
            cnnBuilder.MultipleActiveResultSets = true;
            cnnBuilder.UserID = userName;
            cnnBuilder.Password = pass;
            clsCommon.SqlConnectionString = cnnBuilder.ConnectionString;
            return cnnBuilder.ConnectionString;
            //cnnBuilder = null;
        }

        private void cboTypeConnect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTypeConnect.Text.Trim() == "sa")
            {
                txtPassSA.Visible = true;
                lblSApass.Visible = true;
            }
            else
            {
                txtPassSA.Visible = false ;
                lblSApass.Visible = false ;
            }
        }
    }
}
