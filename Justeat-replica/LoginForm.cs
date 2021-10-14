using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (string.IsNullOrWhiteSpace(passwordtb.Text))
            {
                passwordtb.Text = "Password";
            }
            if (string.IsNullOrWhiteSpace(usernametb.Text))
            {
                usernametb.Text = "Username";
            }
        }

        private void usernametb_Enter(object sender, EventArgs e)
        {
            usernametb.Text = string.Empty;
        }

        private void passwordtb_Enter(object sender, EventArgs e)
        {
            passwordtb.Text = string.Empty;
        }
    }
}
