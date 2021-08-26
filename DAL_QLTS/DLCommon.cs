using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QLTS
{
    public class DLCommon
    {
        private int m_iStateMode;
        private string m_sTableName;
        private string sStoreName;
        public int StateMode
        {
            get { return m_iStateMode; }
            set { m_iStateMode = value; }
        }

        public string TableName
        {
            get { return m_sTableName; }
            set 
            { 
                m_sTableName = value;
                if (m_iStateMode == 1)
                    sStoreName = "Proc_DM_" + m_sTableName + "_SelectAll";
                if (m_iStateMode == 2)
                    sStoreName = "Proc_DM_" + m_sTableName + "_Insert";
                if (m_iStateMode == 3)
                    sStoreName = "Proc_DM_" + m_sTableName + "_Update";
                if (m_iStateMode == 4)
                    sStoreName = "Proc_DM_" + m_sTableName + "_DeleteRow";
            }
        }

        public void GetAllData(string cnn, DataSet ds, string tableName)
        {
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sStoreName ,cn );
            cmd.CommandText = sStoreName;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, tableName);
            cn.Close();

        }


        public void TimkiemPhieuthu(string cnn, DataSet ds, string tableName, DateTime tungay, DateTime denngay)
        {
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_TimkiemPhieuthu", cn);
            cmd.CommandText = "Proc_TimkiemPhieuthu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Tungay", typeof(DateTime )).Value = tungay ;
            cmd.Parameters.Add("@Denngay", typeof(DateTime)).Value = denngay ;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, tableName);
            cn.Close();
            cn.Dispose();
        }

        public void TimkiemPhieuthutheosinhvien(string cnn, DataSet ds, string tableName, DateTime tungay, DateTime denngay, string Masinhvien)
        {
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_TimkiemPhieuthutheosinhvien", cn);
            cmd.CommandText = "Proc_TimkiemPhieuthutheosinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Tungay", typeof(DateTime)).Value = tungay;
            cmd.Parameters.Add("@Denngay", typeof(DateTime)).Value = denngay;
            cmd.Parameters.Add("@Masinhvien", typeof(String  )).Value = Masinhvien  ;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, tableName);
            cn.Close();
            cn.Dispose();
        }

        public void Danhsachsinhvientheolop(string cnn, DataSet ds, string tableName, string Malop)
        {
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_Danhsachsinhvientheolop", cn);
            cmd.CommandText = "Proc_Danhsachsinhvientheolop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Malop", typeof(String)).Value = Malop;
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, tableName);
            cn.Close();
            cn.Dispose();
        }

        public void Danhsachsinhviendanophocphi(string cnn, DataSet ds, string tableName, string Malop)
        {
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_Danhsachsinhviendanophocphi", cn);
            cmd.CommandText = "Proc_Danhsachsinhviendanophocphi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Malop", typeof(String)).Value = Malop;
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, tableName);
            cn.Close();
            cn.Dispose();
        }

        public bool InsertData(string cnn,DataSet ds, DataRow dr, string tableName)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sStoreName, cn);
            cmd.CommandText = sStoreName;
            cmd.CommandType = CommandType.StoredProcedure;

            //add param
            foreach (DataColumn dc in ds.Tables[tableName].Columns)
            {
                cmd.Parameters.Add("@" + dc.ColumnName, dc.DataType).Value = dr[dc.ColumnName];
            }
            
            bKQ= (cmd.ExecuteNonQuery() >0);
            cn.Close();
            return bKQ;
        }

        public bool DeleteKhoanthu(string cnn, string tableName, string id)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from " + tableName + " where Makhoanthu = '" + id + "'", cn);

            bKQ = (cmd.ExecuteNonQuery() > 0);
            cn.Close();
            return bKQ;
        }

        public bool DeletetLop(string cnn,string tableName,string id)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from " + tableName + " where Malop = '" + id + "'", cn);
            
            bKQ = (cmd.ExecuteNonQuery() > 0);
            cn.Close();
            return bKQ;
        }

        public bool DeletetNhanvien(string cnn, string tableName, string id)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from " + tableName + " where Manhanvien = '" + id + "'", cn);

            bKQ = (cmd.ExecuteNonQuery() > 0);
            cn.Close();
            return bKQ;
        }

        public bool DeleteSinhvien(string cnn, string tableName, string Masinhvien)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from " + tableName + " where Masinhvien = '" + Masinhvien + "'", cn);

            bKQ = (cmd.ExecuteNonQuery() > 0);
            cn.Close();
            return bKQ;
        }
        public bool DeletePhieuthu(string cnn, string tableName, string Sophieu)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Delete from " + tableName + " where Sophieu = '" + Sophieu + "'", cn);

            bKQ = (cmd.ExecuteNonQuery() > 0);
            cn.Close();
            return bKQ;
        }
        public bool CheckLogin(string cnn, string username, string pass)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_CheckLogin", cn);
            cmd.CommandText = "Proc_CheckLogin";
            cmd.CommandType = CommandType.StoredProcedure;

            //add param
           
                cmd.Parameters.Add("@Tennhanvien" , typeof (String)).Value = username ;
                cmd.Parameters.Add("@Matkhau", typeof(String)).Value = pass ;

            bKQ = ((int)cmd.ExecuteScalar () > 0);
            cn.Close();
            return bKQ;
        }

        public bool ChangePassWord(string cnn, string username, string oldPass,string newPass)
        {
            bool bKQ = false;
            SqlConnection cn = new SqlConnection(cnn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Proc_ChangePassWord", cn);
            cmd.CommandText = "Proc_ChangePassWord";
            cmd.CommandType = CommandType.StoredProcedure;

            //add param

            cmd.Parameters.Add("@UserName", typeof(String)).Value = username;
            cmd.Parameters.Add("@OldPassWord", typeof(String)).Value = oldPass;
            cmd.Parameters.Add("@NewPassWord", typeof(String)).Value = newPass;

            bKQ = (cmd.ExecuteNonQuery () > 0);
            cn.Close();
            return bKQ;
        }
    }
}
