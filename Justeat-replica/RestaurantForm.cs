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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Justeat_replica
{
    public partial class RestaurantForm : Form
    {
        public RestaurantForm()
        {
            InitializeComponent();
            label1.Parent = homepagepb;
            label1.BackColor = Color.Transparent;
            NoUserLbl.Parent = homepagepb;
            NoUserLbl.BackColor = Color.Transparent;
        }
        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            LoadRestaurant();
            HomePageImage();

          
            //panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void HomePageImage()
        {
            var con = Connection.sqlConnz;
            byte[] fromDB;
            string sql = "select Image from AppDetails where AppName = 'monke'";

            var com = new SqlCommand(sql, con);
            con.Open();
            var rd = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(rd, LoadOption.PreserveChanges);
            con.Close();

            string data = tbl.Rows[0].ItemArray[0].ToString();
            fromDB = Convert.FromBase64String(data);
            homepagepb.Image = ImageViaByte.ByteToImage(fromDB);
        }
        public void LoadRestaurant()
        {
            SqlDataReader LoadAll = Query.GlobalDataReader("select Logo, restaurantname, RPID from restaurantname");
            int x = 1;
            int y = 1;
            int i = 1;
            while (LoadAll.Read())
            {
                try
                {
                    Panel pnls = new Panel();
                    pnls.AutoSize = true;
                    pnls.Location = new Point(x + 15, y + 100);
                    pnls.BackColor = Color.Transparent;
                    RestaurantsPnl.Controls.Add(pnls);

                    Label RestaurantName = new Label(); //Restaurant Name Label
                    RestaurantName.Name = LoadAll["RPID"].ToString();
                    RestaurantName.Text = LoadAll["restaurantname"].ToString();
                    RestaurantName.Font = new Font("Verdana", 10, FontStyle.Bold);
                    RestaurantName.AutoSize = true;
                    RestaurantName.Padding = new Padding(0, 5, 0, 20);
                    RestaurantName.Dock = DockStyle.Top;
                    pnls.Controls.Add(RestaurantName);

                    byte[] fromDB;
                    var data = Query.ViewLogo(LoadAll["RPID"].ToString());
                    GunaPictureBox pb = new GunaPictureBox();
                    pb.Name = LoadAll["RPID"].ToString();
                    pb.Dock = DockStyle.Top;
                    pnls.Width = 260;
                    pb.Height = 150;

                    foreach (DataRow dt in data.Rows)
                    {
                        if (string.IsNullOrWhiteSpace(dt["Logo"].ToString()))
                        {
                            pb.Image = Image.FromFile(@"C:\Users\jhayr\source\repos\Justeat-replica\Justeat-replica\img\noimage.png");
                            continue;
                        }
                        else
                        {
                            fromDB = Convert.FromBase64String(dt["Logo"].ToString());
                            pb.Image = ImageViaByte.ByteToImage(fromDB);
                        }

                    }
                    pb.Radius = 7;
                    pb.Cursor = Cursors.Hand;
                    pb.BackColor = Color.Transparent;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new EventHandler(Restaurant_Click);
                    pnls.Controls.Add(pb);

                    #region Old Button
                    //GunaButton RestaurantButton = new GunaButton();
                    //RestaurantButton.Name = LoadAll["RPID"].ToString();
                    //RestaurantButton.Text = LoadAll["restaurantname"].ToString();
                    //RestaurantButton.Radius = 5;
                    //RestaurantButton.Location = new Point(x + 150, y);
                    //RestaurantButton.Height = 100;
                    //RestaurantButton.Width = 300;
                    //RestaurantButton.Image = null;
                    //RestaurantButton.Click += new EventHandler(Restaurant_Click);
                    //RestaurantPanel.Controls.Add(RestaurantButton);
                    //y += RestaurantButton.Height + 5;
                    #endregion
                    if (i <= 3)
                    {
                        x += pb.Width + 15;
                        i++;
                    }
                    else
                    {
                        y += pb.Height + 50;
                        x = 1;
                        i = 1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Restaurant_Click(object sender, EventArgs e)
        {
            GunaPictureBox btn = (GunaPictureBox)sender;
            Form1.RestaurantID = btn.Name;

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void RestaurantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region Just in case Radius

        //public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        //{
        //    GraphicsPath gp = new GraphicsPath();
        //    gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
        //    gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
        //    gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
        //    gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
        //    gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
        //    gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
        //    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
        //    gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
        //    gp.CloseFigure();
        //    g.DrawPath(p, gp);
        //    gp.Dispose();
        //}
        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{
        //        Graphics v = e.Graphics;
        //        DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
        //        //Without rounded corners
        //        //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
        //        base.OnPaint(e);
        //}
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }
        public static string user = string.Empty;
        private void RestaurantForm_Activated(object sender, EventArgs e)
        {
            NoUserLbl.Text = user;
        }
    }
}
