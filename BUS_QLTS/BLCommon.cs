using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data ;
namespace BUS_QLTS
{
    public class BLCommon
    {
        private string m_sTableName = "";
        private int m_iStateMode = 1;
        private DataSet m_oDataObject;        
        private DataRow m_oCurrentRow;
        public string sSqlConnectionString = @"Data Source=HC\SQLEXPRESS;Initial Catalog=QLTHUHOCPHI;Integrated Security=True";
        private DAL_QLTS.DLCommon oDL = null;

        public string TableName
        {
            get { return m_sTableName; }
            set { m_sTableName = value; }
        }
      
        public DataSet  DataObject
        {
            get { return m_oDataObject; }
            set { m_oDataObject = value; }
        }

       
        private void InitObjectDL()
        {
            oDL = new DAL_QLTS.DLCommon();
        }

        public void GetAllData(DataSet ds, string tableName)
        {
            InitObjectDL();
            ds.Tables[tableName].Clear();
            oDL.StateMode = 1;
            oDL.TableName = tableName;
            oDL.GetAllData(sSqlConnectionString, ds, tableName);
            oDL = null;
        }


        public void TimkiemPhieuthu(DataSet ds, string tableName,DateTime tungay,DateTime denngay)
        {
            InitObjectDL();
            ds.Tables[tableName].Clear();

            oDL.TimkiemPhieuthu(sSqlConnectionString, ds, tableName, tungay, denngay);
            oDL = null;
        }

        public void TimkiemPhieuthutheosinhvien(DataSet ds, string tableName, DateTime tungay, DateTime denngay,string  Masinhvien)
        {
            InitObjectDL();
            ds.Tables[tableName].Clear();

            oDL.TimkiemPhieuthutheosinhvien(sSqlConnectionString, ds, tableName, tungay, denngay, Masinhvien);
            oDL = null;
        }

        public void Danhsachsinhvientheolop(DataSet ds, string tableName, string Malop)
        {
            InitObjectDL();
            ds.Tables[tableName].Clear();

            oDL.Danhsachsinhvientheolop(sSqlConnectionString, ds, tableName, Malop);
            oDL = null;
        }

        public void Danhsachsinhviendanophocphi(DataSet ds, string tableName, string Malop)
        {
            InitObjectDL();
            ds.Tables[tableName].Clear();

            oDL.Danhsachsinhviendanophocphi(sSqlConnectionString, ds, tableName, Malop);
            oDL = null;
        }

        public DataRow AddNewLop()
        {
            DataRow drRow = m_oDataObject.Tables[m_sTableName].NewRow();
            drRow["Malop"] = "";
            drRow["Tenlop"] = "";
            drRow["Hedaotao"] = "" ;

            m_oDataObject.Tables[m_sTableName].Rows.InsertAt(drRow, 0); //'Chuyen ban ghi moi them vao len dau tien          
            return drRow;
        }

        public DataRow AddNewKhoanthu()
        {
            DataRow drRow = m_oDataObject.Tables[m_sTableName].NewRow();
           
            drRow["Makhoanthu"] = "";
            drRow["Noidung"] = "";
            drRow["Malop"] = "";
            drRow["Sotien"] = 0;
            drRow["Ngaybatdau"] = DateTime.Now;
            drRow["Ngayketthuc"] = DateTime.Now;
            drRow["Ghichu"] = "";
           
            m_oDataObject.Tables[m_sTableName].Rows.InsertAt(drRow, 0); //'Chuyen ban ghi moi them vao len dau tien          
            return drRow;
        }

        public DataRow AddNewSinhvien()
        {
            DataRow drRow = m_oDataObject.Tables[m_sTableName].NewRow();

            drRow["Masinhvien"] = "";
            drRow["Tensinhvien"] = "";
            drRow["Gioitinh"] = false;
            drRow["Ngaysinh"] = DateTime.Now;
            drRow["Diachi"] = "";
            drRow["Malop"] = "";

            m_oDataObject.Tables[m_sTableName].Rows.InsertAt(drRow, 0); //'Chuyen ban ghi moi them vao len dau tien          
            return drRow;
        }
        public DataRow AddNewNhanvien()
        {
            DataRow drRow = m_oDataObject.Tables[m_sTableName].NewRow();

            drRow["Manhanvien"] = "";
            drRow["Tennhanvien"] = "";
            drRow["Matkhau"] = "";


            m_oDataObject.Tables[m_sTableName].Rows.InsertAt(drRow, 0); //'Chuyen ban ghi moi them vao len dau tien          
            return drRow;
        }
        public DataRow AddNewPhieuthu()
        {
            DataRow drRow = m_oDataObject.Tables[m_sTableName].NewRow();
            drRow["Sophieu"] = "";
            drRow["Masinhvien"] = "";
            drRow["Makhoanthu"] = "";
            drRow["Ngaythu"] = DateTime.Now;
            drRow["Manhanvien"] = "";
            drRow["Ghichu"] = "";

            m_oDataObject.Tables[m_sTableName].Rows.InsertAt(drRow, 0); //'Chuyen ban ghi moi them vao len dau tien          
            return drRow;
        }
        public bool InsertData(DataSet ds, DataRow dr,string tableName,int stateMode)
        {
            bool bKQ;
            InitObjectDL();
            oDL.StateMode = stateMode;
            oDL.TableName = tableName;
            bKQ= oDL.InsertData(sSqlConnectionString ,ds, dr, tableName);
            oDL = null;
            return bKQ;
        }

        public bool DeleteKhoanthu(string tableName, string Makhoanthu)
        {
            bool bKQ;
            InitObjectDL();
            oDL.TableName = tableName;
            bKQ = oDL.DeleteKhoanthu(sSqlConnectionString, tableName, Makhoanthu);
            oDL = null;
            return bKQ;
        }
        public bool DeleteLop(string tableName,string Malop)
        {
            bool bKQ;
            InitObjectDL();           
            oDL.TableName = tableName;
            bKQ = oDL.DeletetLop(sSqlConnectionString, tableName,Malop );
            oDL = null;
            return bKQ;
        }
        public bool DeleteNhanvien(string tableName, string Manhanvien)
        {
            bool bKQ;
            InitObjectDL();
            oDL.TableName = tableName;
            bKQ = oDL.DeletetNhanvien(sSqlConnectionString, tableName, Manhanvien);
            oDL = null;
            return bKQ;
        }
       
        public bool DeleteSinhvien(string tableName, string Masinhvien)
        {
            bool bKQ;
            InitObjectDL();
            oDL.TableName = tableName;
            bKQ = oDL.DeleteSinhvien(sSqlConnectionString, tableName, Masinhvien);
            oDL = null;
            return bKQ;
        }
        public bool DeletePhieuthu(string tableName, string Sophieu)
        {
            bool bKQ;
            InitObjectDL();
            oDL.TableName = tableName;
            bKQ = oDL.DeletePhieuthu(sSqlConnectionString, tableName, Sophieu);
            oDL = null;
            return bKQ;
        }
        public bool CheckLogin(string userName,string pass)
        {
            bool bKQ;
            InitObjectDL();

            bKQ = oDL.CheckLogin(sSqlConnectionString, userName, pass);
            oDL = null;
            return bKQ;
        }

        public bool ChangePassWord(string userName, string oldPass,string newPass)
        {
            bool bKQ;
            InitObjectDL();
            bKQ = oDL.ChangePassWord(sSqlConnectionString, userName, oldPass ,newPass );
            oDL = null;
            return bKQ;
        }

    }
}
