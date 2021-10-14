using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Justeat_replica
{
    class Query : Connection
    {
        public static DataTable Select(string e)
        {
            var con = sqlConnz;
            string sql = "select food_name, food_id, food_sizes, food_price, size_id from FoodSizesView where food_id = '" + e + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(reader);
            con.Close();
            return tbl;
        }
        public static SqlDataReader ViewQ(params string[] view)
        {
            var cnn = Connection.sqlConnz;
            SqlCommand cmd = new SqlCommand();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select food_id, food_name, iDescription, min(food_price) as iPrice from SectionItemView group by food_id, food_name, iDescription";
            SqlDataReader sda = cmd.ExecuteReader();
            return sda;
        }
        public static void viewBtns(string e)
        {
            SqlDataReader views = ViewQ(e);
            while (views.Read())
            {
                if (e == views["food_id"].ToString())
                {
                    Foodclass fc1 = new Foodclass();
                    opendish.foodId = Convert.ToInt32(views["food_id"]);
                    fc1.food_id = Convert.ToInt32(views["food_id"]);
                    fc1.foodname = views["food_name"].ToString();
                    fc1.fooddesc = views["idescription"].ToString();
                    //fc1.food_price = int.Parse(views["food_price"].ToString());
                    fc1.food_price = int.Parse(views["iPrice"].ToString());
                    Form1.food_food.Add(fc1);
                }
            }
        }
        public static SqlDataReader ViewSizes(params string[] view)
        {
            var cnn = Connection.sqlConnz;
            SqlCommand cmd = new SqlCommand();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select food_id, food_name, iDescription, min(food_price) as iPrice, size_id, food_sizes from SectionItemView group by food_id, food_name, iDescription, food_sizes, size_id";
            SqlDataReader sda = cmd.ExecuteReader();
            return sda;
        }
        public static void SizeBtn(string e)
        {
            SqlDataReader views = ViewSizes(e);
            while (views.Read())
            {
                if (e == views["size_id"].ToString())
                {
                    Foodclass fc1 = new Foodclass();
                    opendish.foodId = Convert.ToInt32(views["food_id"]);
                    fc1.food_id = Convert.ToInt32(views["food_id"]);
                    fc1.foodname = views["food_name"].ToString() + " - " + views["food_sizes"].ToString();
                    fc1.fooddesc = views["idescription"].ToString();
                    //fc1.food_price = int.Parse(views["food_price"].ToString());
                    fc1.food_price = int.Parse(views["iPrice"].ToString());
                    Form1.food_food.Add(fc1);
                }
            }
        }

        public static SqlDataReader GlobalDataReader(string e)
        {
            var con = Connection.sqlConnz;
            SqlCommand command = new SqlCommand();

            con.Open();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = e;

            SqlDataReader sda = command.ExecuteReader();
            return sda;
        }
        public static void GlobalAdd(string e)
        {
            var con = sqlConnz;
            string sql = e;
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void viewOptionGroup(params string[] e)
        {
            SqlDataReader views = GlobalDataReader("select acc_price, acc_id, option_name, food_id, option_id, acc_name, RPID from OptionsPerItemView where food_id = '" + e[0] + "' and size_id = '" + e[1] + "'");

            while (views.Read())
            {
                OptionGroup og = new OptionGroup();
                og.food_id = int.Parse(views["food_id"].ToString());
                og.option_id = int.Parse(views["option_id"].ToString());
                og.option_name = views["acc_name"].ToString();
                og.RPID = int.Parse(views["RPID"].ToString());
                og.optionN = views["option_name"].ToString();
                og.acc_id = int.Parse(views["acc_id"].ToString());
                og.acc_price = int.Parse(views["acc_price"].ToString());
                opendish.optionList.Add(og);
            }
        }
        public static DataTable ViewImage(string e)
        {
            var con = sqlConnz;
            string sql = "select AppImage from restaurantname where RPID = '" + e + "'";

            var com = new SqlCommand(sql, con);
            con.Open();
            var rd = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(rd, LoadOption.PreserveChanges);
            con.Close();
            return tbl;
        }
        public static DataTable ViewLogo(string e)
        {
            var con = sqlConnz;
            string sql = "select Logo from restaurantname where RPID = '" + e + "'";

            var com = new SqlCommand(sql, con);
            con.Open();
            var rd = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(rd, LoadOption.PreserveChanges);
            con.Close();
            return tbl;
        }
    }
}
