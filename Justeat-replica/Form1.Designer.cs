namespace Justeat_replica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Restaurantpb = new System.Windows.Forms.PictureBox();
            this.SectionPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlaceOrderPanel = new System.Windows.Forms.Panel();
            this.placeorder_btn = new System.Windows.Forms.Button();
            this.totalprice_lbl = new System.Windows.Forms.Label();
            this.panel_atc = new System.Windows.Forms.Panel();
            this.addtocart_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurantpb)).BeginInit();
            this.panel3.SuspendLayout();
            this.PlaceOrderPanel.SuspendLayout();
            this.panel_atc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.SectionPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 3;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1165);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.panel5.Size = new System.Drawing.Size(1887, 327);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Footer";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Restaurantpb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1887, 545);
            this.panel4.TabIndex = 1;
            this.panel4.TabStop = true;
            // 
            // Restaurantpb
            // 
            this.Restaurantpb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Restaurantpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Restaurantpb.Location = new System.Drawing.Point(0, 0);
            this.Restaurantpb.Name = "Restaurantpb";
            this.Restaurantpb.Size = new System.Drawing.Size(1887, 545);
            this.Restaurantpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurantpb.TabIndex = 5;
            this.Restaurantpb.TabStop = false;
            // 
            // SectionPanel
            // 
            this.SectionPanel.AutoSize = true;
            this.SectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SectionPanel.Location = new System.Drawing.Point(420, 550);
            this.SectionPanel.Margin = new System.Windows.Forms.Padding(200, 3, 3, 500);
            this.SectionPanel.Name = "SectionPanel";
            this.SectionPanel.Size = new System.Drawing.Size(227, 21);
            this.SectionPanel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.PlaceOrderPanel);
            this.panel3.Controls.Add(this.panel_atc);
            this.panel3.Location = new System.Drawing.Point(1559, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 615);
            this.panel3.TabIndex = 5;
            // 
            // PlaceOrderPanel
            // 
            this.PlaceOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlaceOrderPanel.Controls.Add(this.placeorder_btn);
            this.PlaceOrderPanel.Controls.Add(this.totalprice_lbl);
            this.PlaceOrderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlaceOrderPanel.Location = new System.Drawing.Point(0, 496);
            this.PlaceOrderPanel.Name = "PlaceOrderPanel";
            this.PlaceOrderPanel.Size = new System.Drawing.Size(328, 119);
            this.PlaceOrderPanel.TabIndex = 11;
            // 
            // placeorder_btn
            // 
            this.placeorder_btn.BackColor = System.Drawing.Color.Salmon;
            this.placeorder_btn.FlatAppearance.BorderSize = 0;
            this.placeorder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeorder_btn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorder_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.placeorder_btn.Location = new System.Drawing.Point(14, 18);
            this.placeorder_btn.Name = "placeorder_btn";
            this.placeorder_btn.Size = new System.Drawing.Size(300, 49);
            this.placeorder_btn.TabIndex = 9;
            this.placeorder_btn.Text = "Place order";
            this.placeorder_btn.UseVisualStyleBackColor = false;
            // 
            // totalprice_lbl
            // 
            this.totalprice_lbl.AutoSize = true;
            this.totalprice_lbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice_lbl.Location = new System.Drawing.Point(12, 81);
            this.totalprice_lbl.Name = "totalprice_lbl";
            this.totalprice_lbl.Size = new System.Drawing.Size(0, 24);
            this.totalprice_lbl.TabIndex = 3;
            // 
            // panel_atc
            // 
            this.panel_atc.AutoScroll = true;
            this.panel_atc.BackColor = System.Drawing.Color.White;
            this.panel_atc.Controls.Add(this.addtocart_panel);
            this.panel_atc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atc.Location = new System.Drawing.Point(0, 0);
            this.panel_atc.MinimumSize = new System.Drawing.Size(0, 300);
            this.panel_atc.Name = "panel_atc";
            this.panel_atc.Padding = new System.Windows.Forms.Padding(20);
            this.panel_atc.Size = new System.Drawing.Size(328, 491);
            this.panel_atc.TabIndex = 10;
            // 
            // addtocart_panel
            // 
            this.addtocart_panel.AutoSize = true;
            this.addtocart_panel.BackColor = System.Drawing.Color.DarkGray;
            this.addtocart_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addtocart_panel.Location = new System.Drawing.Point(20, 20);
            this.addtocart_panel.Margin = new System.Windows.Forms.Padding(0);
            this.addtocart_panel.Name = "addtocart_panel";
            this.addtocart_panel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.addtocart_panel.Size = new System.Drawing.Size(288, 1);
            this.addtocart_panel.TabIndex = 7;
            this.addtocart_panel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 0);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurantpb)).EndInit();
            this.panel3.ResumeLayout(false);
            this.PlaceOrderPanel.ResumeLayout(false);
            this.PlaceOrderPanel.PerformLayout();
            this.panel_atc.ResumeLayout(false);
            this.panel_atc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel addtocart_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalprice_lbl;
        private System.Windows.Forms.Button placeorder_btn;
        private System.Windows.Forms.Panel panel_atc;
        private System.Windows.Forms.Panel PlaceOrderPanel;
        private System.Windows.Forms.PictureBox Restaurantpb;
        private System.Windows.Forms.Panel SectionPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}

