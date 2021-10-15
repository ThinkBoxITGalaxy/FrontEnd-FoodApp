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
            this.Loginbtn = new Guna.UI.WinForms.GunaButton();
            this.Loginpb = new System.Windows.Forms.PictureBox();
            this.CreateAccountLink = new Guna.UI.WinForms.GunaLinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emailCreate = new Guna.UI.WinForms.GunaTextBox();
            this.passCreate = new Guna.UI.WinForms.GunaTextBox();
            this.userCreate = new Guna.UI.WinForms.GunaTextBox();
            this.CreateAccountBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.Loginpb)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.usernametb.Location = new System.Drawing.Point(29, 88);
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
            this.passwordtb.Location = new System.Drawing.Point(29, 139);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '●';
            this.passwordtb.Radius = 5;
            this.passwordtb.SelectedText = "";
            this.passwordtb.Size = new System.Drawing.Size(345, 35);
            this.passwordtb.TabIndex = 17;
            this.passwordtb.UseSystemPasswordChar = true;
            this.passwordtb.Enter += new System.EventHandler(this.passwordtb_Enter);
            // 
            // Loginbtn
            // 
            this.Loginbtn.AnimationHoverSpeed = 0.07F;
            this.Loginbtn.AnimationSpeed = 0.03F;
            this.Loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Loginbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.BorderColor = System.Drawing.Color.Black;
            this.Loginbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Loginbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Image = null;
            this.Loginbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Loginbtn.Location = new System.Drawing.Point(29, 195);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Loginbtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.OnHoverImage = null;
            this.Loginbtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.Radius = 5;
            this.Loginbtn.Size = new System.Drawing.Size(345, 42);
            this.Loginbtn.TabIndex = 1;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
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
            // CreateAccountLink
            // 
            this.CreateAccountLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateAccountLink.AutoSize = true;
            this.CreateAccountLink.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateAccountLink.Location = new System.Drawing.Point(161, 292);
            this.CreateAccountLink.Name = "CreateAccountLink";
            this.CreateAccountLink.Size = new System.Drawing.Size(82, 13);
            this.CreateAccountLink.TabIndex = 18;
            this.CreateAccountLink.TabStop = true;
            this.CreateAccountLink.Text = "Create Account";
            this.CreateAccountLink.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.CreateAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountBtn_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(423, 362);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.usernametb);
            this.tabPage1.Controls.Add(this.CreateAccountLink);
            this.tabPage1.Controls.Add(this.passwordtb);
            this.tabPage1.Controls.Add(this.Loginbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.emailCreate);
            this.tabPage2.Controls.Add(this.passCreate);
            this.tabPage2.Controls.Add(this.userCreate);
            this.tabPage2.Controls.Add(this.CreateAccountBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // emailCreate
            // 
            this.emailCreate.BackColor = System.Drawing.Color.Transparent;
            this.emailCreate.BaseColor = System.Drawing.Color.White;
            this.emailCreate.BorderColor = System.Drawing.Color.Silver;
            this.emailCreate.BorderSize = 1;
            this.emailCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailCreate.FocusedBaseColor = System.Drawing.Color.White;
            this.emailCreate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.emailCreate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.emailCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailCreate.Location = new System.Drawing.Point(35, 151);
            this.emailCreate.Name = "emailCreate";
            this.emailCreate.PasswordChar = '\0';
            this.emailCreate.Radius = 5;
            this.emailCreate.SelectedText = "";
            this.emailCreate.Size = new System.Drawing.Size(345, 35);
            this.emailCreate.TabIndex = 10;
            this.emailCreate.Tag = "";
            // 
            // passCreate
            // 
            this.passCreate.BackColor = System.Drawing.Color.Transparent;
            this.passCreate.BaseColor = System.Drawing.Color.White;
            this.passCreate.BorderColor = System.Drawing.Color.Silver;
            this.passCreate.BorderSize = 1;
            this.passCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passCreate.FocusedBaseColor = System.Drawing.Color.White;
            this.passCreate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passCreate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passCreate.Location = new System.Drawing.Point(35, 99);
            this.passCreate.Name = "passCreate";
            this.passCreate.PasswordChar = '\0';
            this.passCreate.Radius = 5;
            this.passCreate.SelectedText = "";
            this.passCreate.Size = new System.Drawing.Size(345, 35);
            this.passCreate.TabIndex = 9;
            this.passCreate.Tag = "";
            // 
            // userCreate
            // 
            this.userCreate.BackColor = System.Drawing.Color.Transparent;
            this.userCreate.BaseColor = System.Drawing.Color.White;
            this.userCreate.BorderColor = System.Drawing.Color.Silver;
            this.userCreate.BorderSize = 1;
            this.userCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userCreate.FocusedBaseColor = System.Drawing.Color.White;
            this.userCreate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userCreate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.userCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userCreate.Location = new System.Drawing.Point(35, 48);
            this.userCreate.Name = "userCreate";
            this.userCreate.PasswordChar = '\0';
            this.userCreate.Radius = 5;
            this.userCreate.SelectedText = "";
            this.userCreate.Size = new System.Drawing.Size(345, 35);
            this.userCreate.TabIndex = 8;
            this.userCreate.Tag = "";
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.AnimationHoverSpeed = 0.07F;
            this.CreateAccountBtn.AnimationSpeed = 0.03F;
            this.CreateAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateAccountBtn.BorderColor = System.Drawing.Color.Black;
            this.CreateAccountBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateAccountBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccountBtn.ForeColor = System.Drawing.Color.White;
            this.CreateAccountBtn.Image = null;
            this.CreateAccountBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.CreateAccountBtn.Location = new System.Drawing.Point(35, 254);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CreateAccountBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateAccountBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateAccountBtn.OnHoverImage = null;
            this.CreateAccountBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateAccountBtn.Radius = 5;
            this.CreateAccountBtn.Size = new System.Drawing.Size(345, 42);
            this.CreateAccountBtn.TabIndex = 7;
            this.CreateAccountBtn.Text = "Create";
            this.CreateAccountBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Loginpb);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Loginpb)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox usernametb;
        private Guna.UI.WinForms.GunaTextBox passwordtb;
        private Guna.UI.WinForms.GunaButton Loginbtn;
        private System.Windows.Forms.PictureBox Loginpb;
        private Guna.UI.WinForms.GunaLinkLabel CreateAccountLink;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaTextBox emailCreate;
        private Guna.UI.WinForms.GunaTextBox passCreate;
        private Guna.UI.WinForms.GunaTextBox userCreate;
        private Guna.UI.WinForms.GunaButton CreateAccountBtn;
    }
}