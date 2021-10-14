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

namespace Justeat_replica
{
    public partial class SelectionsForm : Form
    {
        public SelectionsForm()
        {
            InitializeComponent();
        }
        public static int QueryData = 0;
        public int x = 20;
        public int y = 70;
        public static string itemtext = "";
        public static string FoodNameLbl = "";
        private void SelectionsForm_Load(object sender, EventArgs e)
        {
            SqlDataReader viewform = Query.GlobalDataReader("select food_id, food_sizes, food_price, size_id from SectionItemView where food_id = '" + QueryData + "'");
            SelectionsFoodNameLbl.Text = FoodNameLbl;
            while (viewform.Read())
            {
                GunaElipsePanel acc = new GunaElipsePanel();
                acc.Name = viewform["food_id"].ToString();
                acc.Location = new Point(x, y);
                acc.TabStop = false;
                acc.Height = 55;
                acc.Width = 320;
                acc.ForeColor = Color.Black;
                acc.BaseColor = Color.Gainsboro;
                acc.Font = new Font("Arial", 9);
                acc.Radius = 10;
                SelectionsPnl.Controls.Add(acc);

                GunaButton sizeLbl = new GunaButton();
                sizeLbl.Name = viewform["size_id"].ToString();
                sizeLbl.Text = viewform["food_sizes"].ToString();
                sizeLbl.Click += new EventHandler(OpenDishForm);
                sizeLbl.Location = new Point(0, 0);
                sizeLbl.BackColor = Color.Transparent;
                sizeLbl.BaseColor = Color.Transparent;
                sizeLbl.Image = null;
                sizeLbl.Radius = 10;
                sizeLbl.Size = new Size(320, 55);
                sizeLbl.TabStop = false;
                sizeLbl.Cursor = Cursors.Hand;
                sizeLbl.ForeColor = Color.Black;
                sizeLbl.Font = new Font("Arial", 9);
                acc.Controls.Add(sizeLbl);

                Label priceLbl = new Label();
                //priceLbl.BackColor = Color.Pink;
                priceLbl.Name = viewform["food_id"].ToString();
                priceLbl.Text = "\u20b1" + viewform["food_price"].ToString();
                priceLbl.Location = new Point(280, 20);
                priceLbl.TextAlign = ContentAlignment.MiddleLeft;
                priceLbl.AutoSize = true;
                priceLbl.TabStop = false;
                priceLbl.Cursor = Cursors.Hand;
                priceLbl.ForeColor = Color.Black;
                priceLbl.Font = new Font("Arial", 9);
                sizeLbl.Controls.Add(priceLbl);

                y += 60;
            }
            this.Size = new Size(380, y + 60);
        }
        private void OpenDishForm(object sender, EventArgs e)
        {
            GunaButton btn = (GunaButton)sender;

            Form1.food_food.Clear();
            opendish ss = new opendish();
            opendish.food_size = btn.Text;
            opendish.size_id = int.Parse(btn.Name);
            Query.viewOptionGroup(QueryData.ToString(), btn.Name);
            Query.SizeBtn(btn.Name);
            ss.ShowDialog();
            this.Close();
        }
    }
}
