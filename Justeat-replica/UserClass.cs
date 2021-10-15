using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justeat_replica
{
    public class UserClass
    {
        public string usern { get; set; }
        public string passw { get; set; }
    }
    public class LoginUser
    {
        public static string username = string.Empty;
        public static string password = string.Empty;

        public static List<UserClass> UserData(string un, string pw)
        {
            SqlDataReader users = Query.GlobalDataReader("select * from users");
            List<UserClass> ucList = new List<UserClass>();

            while (users.Read())
            {
                if (un == users["username"].ToString() && pw == users["password"].ToString())
                {
                    UserClass uc = new UserClass();
                    uc.usern = users["username"].ToString();
                    uc.passw = users["password"].ToString();
                    ucList.Add(uc);
                }
            }
            return ucList;
        }
    }
}
