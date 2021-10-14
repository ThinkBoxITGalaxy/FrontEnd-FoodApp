namespace Justeat_replica
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernametb = new Guna.UI.WinForms.GunaTextBox();
            this.passwordtb = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Loginpb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Loginpb)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.BackColor = System.Drawing.Color.Transparent;
            this.usernametb.BaseColor = System.Drawing.Color.White;
            this.usernametb.BorderColor = System.Drawing.Color.Silver;
            this.usernametb.BorderSize = 1;
            this.usernametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametb.FocusedBaseColor = System.Drawing.Color.White;
            this.usernametb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernametb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.usernametb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernametb.Location = new System.Drawing.Point(40, 334);
            this.usernametb.Name = "usernametb";
            this.usernametb.PasswordChar = '\0';
            this.usernametb.Radius = 5;
            this.usernametb.SelectedText = "";
            this.usernametb.Size = new System.Drawing.Size(345, 35);
            this.usernametb.TabIndex = 6;
            this.usernametb.Tag = "";
            this.usernametb.Enter += new System.EventHandler(this.usernametb_Enter);
            // 
            // passwordtb
            // 
            this.passwordtb.BackColor = System.Drawing.Color.Transparent;
            this.passwordtb.BaseColor = System.Drawing.Color.White;
            this.passwordtb.BorderColor = System.Drawing.Color.Silver;
            this.passwordtb.BorderSize = 1;
            this.passwordtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtb.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordtb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordtb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtb.Location = new System.Drawing.Point(40, 385);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '●';
            this.passwordtb.Radius = 5;
            this.passwordtb.SelectedText = "";
            this.passwordtb.Size = new System.Drawing.Size(345, 35);
            this.passwordtb.TabIndex = 17;
            this.passwordtb.UseSystemPasswordChar = true;
            this.passwordtb.Enter += new System.EventHandler(this.passwordtb_Enter);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(40, 441);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(345, 42);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Login";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Loginpb
            // 
            this.Loginpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginpb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Loginpb.Location = new System.Drawing.Point(0, 0);
            this.Loginpb.Name = "Loginpb";
            this.Loginpb.Size = new System.Drawing.Size(423, 236);
            this.Loginpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loginpb.TabIndex = 3;
            this.Loginpb.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 598);
            this.Controls.Add(this.Loginpb);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.Loginpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox usernametb;
        private Guna.UI.WinForms.GunaTextBox passwordtb;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox Loginpb;
    }
}