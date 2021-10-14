using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justeat_replica
{
    class ImageCaller
    {
        public static byte[] GetImage()
        {
            var con = Connection.sqlConnz;
            byte[] fromDB;
            string sql = "select LoginImage from AppDetails where AppName = 'monke'";

            var com = new SqlCommand(sql, con);
            con.Open();
            var rd = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(rd, LoadOption.PreserveChanges);
            con.Close();

            string data = tbl.Rows[0].ItemArray[0].ToString();
            fromDB = Convert.FromBase64String(data);
            return fromDB;
        }
    }
}
