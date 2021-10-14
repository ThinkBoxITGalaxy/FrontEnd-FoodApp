using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using ComponentFactory.Krypton.Toolkit;
namespace Justeat_replica
{
    public partial class opendish : Form
    {
        public opendish()
        {
            InitializeComponent();
        }
        public static Stack<string> itemCount = new Stack<string>();
        public static List<string> AccessCount = new List<string>();
        public static Stack<string> tempAccess = new Stack<string>();
        //public static Stack<foodaccessory> foodacc = new Stack<foodaccessory>();
        public static Dictionary<string, string> addtocart_dict = new Dictionary<string, string>();
        public static List<OptionGroup> optionList = new List<OptionGroup>();
        public static List<string> AccessoryList = new List<string>(); //make dictionary to this
        public static string food_size = " ";
        public static int size_id = 0;
        public static GunaButton btnClick;
        public static int foodId = 0;
        public static int OptionId = 0;
        public int sum = 0;
        public int OriginalPrice = 0;

        public int x = 1;
        public int y = 1;

        private void opendish_Load(object sender, EventArgs e)
        {
            OpenDishAccessoryPnl.Controls.Clear();
            foreach (Foodclass fc in Form1.food_food)
            {
                itemname_lbl.Text = fc.foodname;
                itemdesc_lbl.Text = fc.fooddesc;
                itemprice_lbl.Text = fc.food_price.ToString();
                OriginalPrice = fc.food_price;
                sum = int.Parse(itemprice_lbl.Text);
            }
            string optionN = "";
            itemCount.Push(itemname_lbl.Text);
            itemcount.Text = itemCount.Count().ToString();

            SqlDataReader view = Query.GlobalDataReader("select food_id, option_id from ItemOptionView where food_id = '" + foodId + "' and size_id = '" + size_id + "'");

            while (view.Read())
            {
                OptionId = int.Parse(view["option_id"].ToString());
                Panel panel = new Panel();
                panel.Name = view["option_id"].ToString();
                panel.Location = new Point(x + 10, y + 10);
                panel.AutoSize = true;
                panel.Width = 335;
                panel.AutoSize = true;
                panel.BackColor = Color.Transparent;
                OpenDishAccessoryPnl.Controls.Add(panel);

                y = 50;
                foreach (OptionGroup opt in optionList) // view accessories when food/sizes click
                {
                    if (opt.option_id == OptionId)
                    {
                        optionN = opt.optionN;
                        // accessory whole button name
                        Label accPrice = new Label(); // accessory price
                        GunaButton ButtonA = new GunaButton();

                        accPrice.Name = "price" + opt.acc_id.ToString();
                        accPrice.Text = opt.acc_price.ToString();
                        accPrice.Location = new Point(260, 20);
                        accPrice.ForeColor = Color.Gray;
                        accPrice.AutoSize = true;
                        accPrice.BackColor = Color.Transparent;
                        accPrice.Font = new Font("Arial", 9, FontStyle.Bold);
                        ButtonA.Controls.Add(accPrice);

                        ButtonA.Name = /*"accs"+ */ opt.acc_id.ToString();
                        ButtonA.Text = opt.option_name.ToString();
                        ButtonA.Click += new EventHandler(AccessoriesWhenClicked_Click);
                        ButtonA.ForeColor = Color.Blue;
                        ButtonA.Location = new Point(x + 5, y);
                        ButtonA.BaseColor = Color.White;
                        ButtonA.TabStop = false;
                        ButtonA.Cursor = Cursors.Hand;
                        ButtonA.Height = 55;
                        ButtonA.Width = 320;
                        ButtonA.TextAlign = HorizontalAlignment.Left;
                        //ButtonA.BaseColor = Color.FromArgb(151, 143, 255);
                        ButtonA.Font = new Font("Arial", 9, FontStyle.Bold);
                        ButtonA.Image = null;
                        ButtonA.Radius = 5;
                        panel.Controls.Add(ButtonA);


                        y += 65;
                    }
                }
                Label lbl = new Label(); // Option Group Name onli
                lbl.Name = view["option_id"].ToString();
                lbl.Text = optionN;
                lbl.Size = new Size(330, 30);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Cursor = Cursors.Hand;
                lbl.Font = new Font("Arial", 15, FontStyle.Bold);
                panel.Controls.Add(lbl);
            }
        }
        public static string tempname = "";

        public static List<foodOrder> counting_accessories = new List<foodOrder>();
        private void AccessoriesWhenClicked_Click(object sender, EventArgs e)
        // change of plans - copy from the other foodapps on your phone - your idea wont work dumbass
        {
            GunaButton btn = (GunaButton)sender;
            foreach (Control items in btn.Controls)
                if (items.Name.Contains("price"))
                {
                    if (btn.Text.Contains("\u2714"))
                    {
                        btn.Text = btn.Text.Replace("\u2714", "");
                        AccessoryList.Remove("+" + btn.Text);
                        sum -= int.Parse(items.Text.Replace("price", ""));
                        itemprice_lbl.Text = sum.ToString();
                        break;
                    }

                    if (!btn.Text.Contains("\u2714"))
                    {
                        btn.Text = "\u2714" + " " + btn.Text;
                        AccessoryList.Add("+" + btn.Text.Replace("\u2714", ""));
                        sum += int.Parse(items.Text.Replace("price", ""));
                        itemprice_lbl.Text = sum.ToString();
                        break;
                    }
                }
        }
        private void atc_btn_Click(object sender, EventArgs e) // add to cart click
        {
            int totalprice = int.Parse(itemprice_lbl.Text);
            int index = Form1.foodList.Count;
            //foreach (foodOrder foodArr in Form1.foodList) // do not delete this
            //{
            //    if (foodArr.foodname == itemname_lbl.Text)
            //    {
            //        Form1.foodList.RemoveAt(index);
            //        break;
            //    }
            //    index++;
            //}
            foodOrder fo = new foodOrder();
            fo.foodid = foodId;
            fo.foodname = itemname_lbl.Text;
            fo.foodprice = totalprice;
            fo.foodquantity = int.Parse(itemcount.Text);

            if (AccessoryList.Count != 0)
            {
                foreach (string al in AccessoryList)
                {
                    fo.foodacc_name += al + "\n";
                }
            }
           
            AccessoryList.Clear();
            Form1.foodList.Insert(index, fo);
            this.Close();
        }
        private void buy_btn_Click(object sender, EventArgs e)
        {
            itemCount.Push(itemname_lbl.Text);
            itemcount.Text = itemCount.Count().ToString();
            sum += OriginalPrice;
            itemprice_lbl.Text = sum.ToString();
        }
        private void remove_btn_Click_1(object sender, EventArgs e)
        {
            if (itemCount.Count() <= 1)
            {
                return;
            }
            else
            {
                itemCount.Pop();
                itemcount.Text = itemCount.Count().ToString();
                sum -= OriginalPrice;
                itemprice_lbl.Text = sum.ToString();
            }
        }
        private void opendish_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemCount.Clear();
            AccessCount.Clear();
            food_size = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GunaNumeric num = new GunaNumeric();
            num.Location = new Point(0, 0);
            num.Height = 55;
            Controls.Add(num);

        }
    }
}
//GunaButton xbtn = new GunaButton();// accessory remove button
//xbtn.Name = ButtonAccessories.Name;
//xbtn.Text = "x";
////xbtn.Click += new EventHandler(RemoveAccessoryQuantity_Click);
//xbtn.OnHoverBaseColor = Color.Transparent;
//xbtn.OnPressedColor = Color.Transparent;
//xbtn.Location = /*new Point(270);*/new Point(x + 250, y);
//xbtn.TabStop = false;
//xbtn.Cursor = Cursors.Hand;
//xbtn.Height = 55;
//xbtn.Width = 55;
//xbtn.TextAlign = HorizontalAlignment.Center;
//xbtn.ForeColor = Color.Red;
//xbtn.BaseColor = Color.AliceBlue;
//xbtn.Font = new Font("Arial", 13, FontStyle.Bold);
//xbtn.Image = null;
//xbtn.Radius = 5;
//panel.Controls.Add(xbtn);