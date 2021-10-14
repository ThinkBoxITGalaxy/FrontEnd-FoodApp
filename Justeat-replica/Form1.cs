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
using System.Collections;
using System.Drawing.Drawing2D;
using Guna.UI.WinForms;
using System.IO;

namespace Justeat_replica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string RestaurantID = "";
        public void Form1_Load(object sender, EventArgs e)
        {
            ViewImage();
            loopingbtn(null);
            this.panel1.MouseWheel += panel1_MouseWheel;
        }
        public void ViewImage()
        {
            byte[] fromDB;

            var data = Query.ViewImage(RestaurantID);
            //var con = Connection.sqlConnz;

            foreach (DataRow dt in data.Rows)
            {
                if (string.IsNullOrWhiteSpace(dt["AppImage"].ToString()))
                {
                    Restaurantpb.Image = Image.FromFile(@"C:\Users\jhayr\source\repos\Justeat-replica\Justeat-replica\img\noimage.png");
                    continue;
                }
                else
                {
                    fromDB = Convert.FromBase64String(dt["AppImage"].ToString());
                    Restaurantpb.Image = ImageViaByte.ByteToImage(fromDB);
                }
            }
        }

        List<string> sectionname = new List<string>();
        List<string> RPsectionList = new List<string>();
        Dictionary<string, string> RpidAndDescription = new Dictionary<string, string>();
        List<SectionData> sectiondata = new List<SectionData>();


        public string loopingbtn(string btntxt) /*restaurant's section names*/
        {
            SqlDataReader SectionView = Query.GlobalDataReader("select section_name, section_id, section_desc from SectionView where RPID = '" + RestaurantID + "'");
            string ltext = "";
            int sv_x = 20;
            int sv_y = 20;
            string section = "";
            int x = 1;
            int y = 1;
            int loopcount = 0;

            while (SectionView.Read()) /*Left side section names*/
            {
                Label sv = new Label();
                sv.Name = SectionView["section_id"].ToString();
                sv.Text = SectionView["section_name"].ToString();
                sv.TabIndex = 5;
                sv.Location = new Point(sv_x, sv_y);
                sv.ForeColor = Color.Black;
                sv.BackColor = Color.Transparent;
                sv.Font = new Font("Arial", 9);
                SectionPanel.Controls.Add(sv);
                sv_y += 40;
                section = SectionView["section_id"].ToString();
                sectionname.Add(SectionView["section_name"].ToString());
                RpidAndDescription[SectionView["section_name"].ToString()] = SectionView["section_id"].ToString();

                SectionData sd = new SectionData();
                sd.Name = SectionView["section_name"].ToString();
                sd.id = SectionView["section_id"].ToString();
                sd.Description = SectionView["section_desc"].ToString();
                sectiondata.Add(sd);
            }

            foreach (SectionData sections in sectiondata)
            {
                Panel ItemPnl = new Panel();
                ItemPnl.Location = new Point(x + 740, y + 730);
                ItemPnl.AutoSize = true;
                ItemPnl.TabIndex = 5;
                ItemPnl.Width = 450;
                panel1.Controls.Add(ItemPnl);

                SqlDataReader views = Query.GlobalDataReader("select section_name, section_id, food_id, food_name, iDescription, min(food_price) as iPrice from SectionItemView where RPID = '" + RestaurantID + "'group by section_name, section_id, food_id, food_name, iDescription");

                while (views.Read())
                {
                    if (sections.Name == views["section_name"].ToString())
                    {
                        Panel panel = new Panel();
                        panel.Dock = DockStyle.Top;
                        panel.Name = views["section_id"].ToString();
                        panel.TabIndex = 5;
                        panel.Width = 450;
                        panel.Height = 130;
                        panel.BackColor = Color.White;
                        panel.Margin = new Padding(25, 225, 25, 225);
                        //panel.BorderStyle = BorderStyle.FixedSingle;
                        ItemPnl.Controls.Add(panel);

                        Label lbldesc = new Label();
                        lbldesc.Name = views["food_id"].ToString();
                        lbldesc.Text = views["idescription"].ToString();
                        lbldesc.Click += new EventHandler(itemlbl_Click);
                        lbldesc.Location = new Point(15, 45);
                        lbldesc.Cursor = Cursors.Hand;
                        lbldesc.TabIndex = 5;
                        lbldesc.Height = 55;
                        lbldesc.Width = 420;
                        lbldesc.ForeColor = Color.Gray;
                        lbldesc.TextAlign = ContentAlignment.MiddleLeft;
                        lbldesc.Font = new Font("Arial", 9);
                        panel.Controls.Add(lbldesc);

                        Label lblprice = new Label();
                        lblprice.Name = views["food_id"].ToString();
                        lblprice.Text = "\u20b1" + views["iPrice"].ToString();
                        lblprice.Click += new EventHandler(itemlbl_Click);
                        lblprice.Location = new Point(15, 100);
                        lblprice.Cursor = Cursors.Hand;
                        lblprice.Font = new Font("Verdana", 10, FontStyle.Bold);
                        lblprice.AutoSize = true;
                        lblprice.TabIndex = 5;
                        lblprice.ForeColor = Color.Black;
                        panel.Controls.Add(lblprice);

                        Label item_lbl = new Label();
                        item_lbl.Name = views["food_id"].ToString();
                        item_lbl.Text = views["food_name"].ToString();
                        item_lbl.Click += new EventHandler(itemlbl_Click);
                        item_lbl.Padding = new Padding(15, 15, 15, 15);
                        item_lbl.Width = 450;
                        item_lbl.Height = 130;
                        item_lbl.TabIndex = 5;
                        item_lbl.Cursor = Cursors.Hand;
                        item_lbl.TextAlign = ContentAlignment.TopLeft;
                        item_lbl.Font = new Font("Arial", 15, FontStyle.Bold);
                        panel.Controls.Add(item_lbl);

                        Panel temppanel = new Panel();
                        temppanel.Dock = DockStyle.Top;
                        temppanel.Width = 450;
                        temppanel.Height = 10;
                        temppanel.TabIndex = 5;
                        ItemPnl.Controls.Add(temppanel);
                    }
                }

                Panel DescriptionPnl = new Panel();
                DescriptionPnl.Dock = DockStyle.Top;
                DescriptionPnl.AutoSize = true;
                DescriptionPnl.TabIndex = 5;
                DescriptionPnl.Margin = new Padding(15, 15, 15, 15);
                ItemPnl.Controls.Add(DescriptionPnl);

                Label SecDescription = new Label();
                SecDescription.TabIndex = 5;
                SecDescription.Name = sections.id;
                SecDescription.Text = sections.Description;
                SecDescription.Margin = new Padding(15, 15, 15, 15);
                SecDescription.MaximumSize = new Size(450, 0);
                SecDescription.AutoSize = true;
                SecDescription.Cursor = Cursors.Hand;
                SecDescription.ForeColor = Color.Gray;
                SecDescription.TextAlign = ContentAlignment.MiddleLeft;
                SecDescription.Font = new Font("Arial", 9);
                DescriptionPnl.Controls.Add(SecDescription);

                Panel sectionPnl = new Panel();
                sectionPnl.Dock = DockStyle.Top;
                sectionPnl.AutoSize = true;
                sectionPnl.TabIndex = 5;
                sectionPnl.Padding = new Padding(15, 15, 15, 15);
                ItemPnl.Controls.Add(sectionPnl);

                Label sectionName = new Label(); /*section name*/
                sectionName.Name = sections.id;
                sectionName.Text = sections.Name;
                sectionName.TabIndex = 5;
                sectionName.AutoSize = true;
                sectionName.Cursor = Cursors.Hand;
                sectionName.ForeColor = Color.Black;
                sectionName.TextAlign = ContentAlignment.MiddleLeft;
                sectionName.Font = new Font("Arial", 15, FontStyle.Bold);
                sectionPnl.Controls.Add(sectionName);

                loopcount += 1;
                if (loopcount == 1)
                {
                    loopcount = 0;
                    y += ItemPnl.Height + 20;
                    x = 1;
                }
            }
            RPsectionList.Clear();
            return ltext;
        }
        private void itemlbl_Click(object sender, EventArgs e) // when main form food clicked
        {
            Label itemlbl = (Label)sender;
            //food_acc.Clear();
            opendish.optionList.Clear();

            var ss = Query.Select(itemlbl.Name);

            foreach (DataRow ee in ss.Rows)
            {
                if (string.IsNullOrWhiteSpace(ee["food_sizes"].ToString()))
                {
                    Query.viewOptionGroup(itemlbl.Name, null);
                    Query.viewBtns(itemlbl.Name);
                    food_food.Clear();
                    opendish od = new opendish();

                    opendish.food_size = null; //item empty sizes accessories/option group
                    opendish.size_id = int.Parse(ee["size_id"].ToString());
                    Query.viewOptionGroup(itemlbl.Name, ee["size_id"].ToString());
                    Query.SizeBtn(ee["size_id"].ToString());
                    od.ShowDialog();
                }
                else
                {
                    SelectionsForm.QueryData = int.Parse(itemlbl.Name);
                    SelectionsForm.FoodNameLbl = ee["food_name"].ToString();
                    SelectionsForm sf = new SelectionsForm();
                    sf.ShowDialog();
                    return;
                }
            }
        }
        /*========== Food items =========*/

        public static string text;
        public static List<Foodclass> food_food = new List<Foodclass>(); // opendish.Load is using this
        public static List<foodOrder> foodList = new List<foodOrder>(); // Crucial part for this form
                                                                        //public static List<foodaccessory> food_acc = new List<foodaccessory>(); // accessories
        private void Form1_Activated(object sender, EventArgs e) // Reactivate form every transaction *************************
        {
            cont();
            if (foodList.Count > 0)
            {
                addtocart_panel.Visible = true;
            }
        }

        #region Add to Cart codes includes the cont() method
        /*======== Add to Cart ===========================================================*/
        public void cont()
        {
            addtocart_panel.Controls.Clear();
            int x = 0;
            int y = 1;
            int ex = 25;
            int ey = 45;
            int i = 0;
            foreach (foodOrder foodlist in foodList)
            {
                Panel panel = new Panel(); //per order
                panel.Location = new Point(x, y);
                panel.MinimumSize = new Size(288, 0);
                panel.AutoSize = true;
                panel.Margin = new Padding(0, 1, 0, 1);
                panel.BackColor = Color.White;
                addtocart_panel.Controls.Add(panel);

                Label foodQ = new Label();
                foodQ.Name = foodlist.foodname;
                foodQ.Text = foodlist.foodquantity.ToString();
                foodQ.Click += new EventHandler(lbl_Click);
                foodQ.Cursor = Cursors.Hand;
                foodQ.Location = new Point(1, 25);
                foodQ.Font = new Font("Verdana", 10, FontStyle.Bold);
                foodQ.AutoSize = true;
                foodQ.ForeColor = Color.Blue;
                foodQ.BackColor = Color.FromArgb(237, 241, 254);
                panel.Controls.Add(foodQ);

                Label foodN = new Label();
                foodN.Name = foodlist.foodid.ToString();
                foodN.Text = foodlist.foodname;
                foodN.Cursor = Cursors.Hand;
                foodN.Click += new EventHandler(lbl_Click);
                foodN.Location = new Point(30, 25);
                foodN.Font = new Font("Arial", 10);
                foodN.AutoSize = true;
                foodN.ForeColor = Color.Blue;
                panel.Controls.Add(foodN);

                Label x_lbl = new Label();
                x_lbl.Name = foodlist.foodname;
                x_lbl.Cursor = Cursors.Hand;
                x_lbl.Text = "X";
                x_lbl.Font = new Font("Verdana", 10, FontStyle.Bold);
                x_lbl.Click += new EventHandler(x_lbl_Click);
                x_lbl.Location = new Point(210, 24);
                x_lbl.AutoSize = true;
                x_lbl.ForeColor = Color.Red;
                panel.Controls.Add(x_lbl);

                Label foodP = new Label();
                foodP.Name = foodlist.foodid.ToString();
                foodP.Text = "\u20b1" + foodlist.foodprice.ToString();
                foodP.Location = new Point(230, 25);
                foodP.Font = new Font("Verdana", 9);
                foodP.AutoSize = true;
                foodP.ForeColor = Color.Blue;
                foodP.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(foodP);

                Label foodacc = new Label(); /******show choices of accessories on addtocart*/
                foodacc.Name = "foodacc";
                foodacc.Text = foodlist.foodacc_name;
                foodacc.Cursor = Cursors.Hand;
                //foodN.Click += new EventHandler(lbl_Click);
                foodacc.Location = new Point(30, 45);
                foodacc.Font = new Font("Arial", 10);
                foodacc.AutoSize = true;
                foodacc.ForeColor = Color.Gray;
                foodacc.Margin = new Padding(10);
                panel.Controls.Add(foodacc);

                ey += 20;

                y += panel.Height + 1;
                i += foodlist.foodprice;
            }
            totalprice_lbl.Text = "Total price: \u20b1" + i.ToString();
        }
        private void x_lbl_Click(object sender, EventArgs e)
        {
            Label xbtn = (Label)sender;
            int index = 0;

            foreach (foodOrder foodArr in foodList)
            {
                if (foodArr.foodname == xbtn.Name)
                {
                    foodList.RemoveAt(index);
                    cont();
                    break;
                }
                index++;
            }
        }

        private void lbl_Click(object sender, EventArgs e) /*==== Add to cart item update*/
        {
            Label lbl = (Label)sender;
            opendish.itemCount.Clear();
            Query.viewBtns(lbl.Name);

            foreach (var ss in foodList)
            {
                if (ss.foodid.ToString() == lbl.Name)
                {
                    for (int i = 1; i <= ss.foodquantity - 1; i++)
                    {
                        opendish.itemCount.Push(ss.foodname);
                    }
                }
            }
            opendish dishform = new opendish();
            dishform.ShowDialog();
        }
        #endregion
        #region ninpo scrolling technique
        private void panel1_Scroll(object sender, ScrollEventArgs e) // ninpo scrolling technique
        {

            if (panel1.VerticalScroll.Value > 500)
            {
                SectionPanel.Location = new Point(420, (panel1.VerticalScroll.Value - panel1.VerticalScroll.Value) + 50);
                panel3.Location = new Point(1575, (panel1.VerticalScroll.Value - panel1.VerticalScroll.Value) + 50);
            }
            else
            {
                SectionPanel.Location = new Point(420, 550 - panel1.VerticalScroll.Value);
                panel3.Location = new Point(1575, 550 - panel1.VerticalScroll.Value);
            }
        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (panel1.VerticalScroll.Value > 500)
            {
                SectionPanel.Location = new Point(420, (panel1.VerticalScroll.Value - panel1.VerticalScroll.Value) + 50);
                panel3.Location = new Point(1575, (panel1.VerticalScroll.Value - panel1.VerticalScroll.Value) + 50);
            }

            else
            {
                SectionPanel.Location = new Point(420, 550 - panel1.VerticalScroll.Value);
                panel3.Location = new Point(1575, 550 - panel1.VerticalScroll.Value);
            }
        }
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            RestaurantForm rf = new RestaurantForm();
            rf.Show();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);
        }
    }
}

