using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Justeat_replica
{
    class Connection
    {
        public static SqlConnection sqlConnz
        {
            get
            {
                string constring = "Server=DESKTOP-UJBAK2U; user id=sa; password=admin123; database=justeat";
                return new SqlConnection(constring);
            }
        }
    }
}
