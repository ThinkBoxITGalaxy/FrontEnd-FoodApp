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

namespace Justeat_replica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Loginpb.Image = ImageViaByte.ByteToImage(ImageCaller.GetImage());

            passwordtb.Text = "Password";
            usernametb.Text = "Username";

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void usernametb_Enter(object sender, EventArgs e)
        {
            usernametb.Text = string.Empty;
        }

        private void passwordtb_Enter(object sender, EventArgs e)
        {
            passwordtb.Text = string.Empty;
        }

        private void CreateAccountBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            userCreate.Text = "Username";
            passCreate.Text = "Password";
            emailCreate.Text = "Email";
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            Query.GlobalAdd("Insert into users(username, password, email) values ('" + userCreate.Text + "','" + passCreate.Text + "','" + emailCreate.Text + "')");
            MessageBox.Show("Goodluck");
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var userdata = LoginUser.UserData(usernametb.Text, passwordtb.Text);
            foreach (var ud in userdata)
            {
                RestaurantForm.user = ud.usern;
            }
        }
    }
}
