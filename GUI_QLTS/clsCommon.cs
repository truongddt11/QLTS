using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BUS_QLTS;

namespace GUI_QLTS
{
   public static  class clsCommon
    {
       public static string SqlConnectionString;
       public static string UserName ;
       public static string ServerName;
       public static string DBName;
       public static void ShowMessageException(string mesage)
       {
           System.Windows.Forms.MessageBox.Show(mesage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
       }

       public static System .Windows .Forms .DialogResult  ShowMessageQuestion(string mesage)
       {
           return System.Windows.Forms.MessageBox.Show(mesage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            
       }

       public static  void GetData(DataSet ds,string tableName)
       {
           BUS_QLTS.BLCommon oBL = new BUS_QLTS.BLCommon();
           oBL.sSqlConnectionString = clsCommon.SqlConnectionString;
           oBL.GetAllData(ds,tableName );
           oBL = null;
       }

     
    }
}
