namespace Justeat_replica
{
    partial class opendish
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
            this.itemdesc_lbl = new System.Windows.Forms.Label();
            this.itemname_lbl = new System.Windows.Forms.Label();
            this.buy_btn = new System.Windows.Forms.Button();
            this.itemcount = new System.Windows.Forms.Label();
            this.atc_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.OpenDishAccessoryPnl = new System.Windows.Forms.Panel();
            this.itemprice_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemdesc_lbl
            // 
            this.itemdesc_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.itemdesc_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemdesc_lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.itemdesc_lbl.Location = new System.Drawing.Point(39, 58);
            this.itemdesc_lbl.Name = "itemdesc_lbl";
            this.itemdesc_lbl.Size = new System.Drawing.Size(373, 166);
            this.itemdesc_lbl.TabIndex = 0;
            this.itemdesc_lbl.Text = "label1";
            // 
            // itemname_lbl
            // 
            this.itemname_lbl.AutoSize = true;
            this.itemname_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemname_lbl.Location = new System.Drawing.Point(38, 24);
            this.itemname_lbl.Name = "itemname_lbl";
            this.itemname_lbl.Size = new System.Drawing.Size(65, 22);
            this.itemname_lbl.TabIndex = 1;
            this.itemname_lbl.Text = "label1";
            this.itemname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy_btn
            // 
            this.buy_btn.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.Location = new System.Drawing.Point(104, 490);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(100, 51);
            this.buy_btn.TabIndex = 3;
            this.buy_btn.Text = "+";
            this.buy_btn.UseVisualStyleBackColor = true;
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // itemcount
            // 
            this.itemcount.AutoSize = true;
            this.itemcount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemcount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemcount.Location = new System.Drawing.Point(221, 502);
            this.itemcount.Name = "itemcount";
            this.itemcount.Size = new System.Drawing.Size(25, 27);
            this.itemcount.TabIndex = 6;
            this.itemcount.Text = "0";
            // 
            // atc_btn
            // 
            this.atc_btn.Location = new System.Drawing.Point(104, 564);
            this.atc_btn.Name = "atc_btn";
            this.atc_btn.Size = new System.Drawing.Size(257, 51);
            this.atc_btn.TabIndex = 7;
            this.atc_btn.Text = "Add to Cart";
            this.atc_btn.UseVisualStyleBackColor = true;
            this.atc_btn.Click += new System.EventHandler(this.atc_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(261, 490);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(100, 51);
            this.remove_btn.TabIndex = 8;
            this.remove_btn.Text = "-";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click_1);
            // 
            // OpenDishAccessoryPnl
            // 
            this.OpenDishAccessoryPnl.AutoScroll = true;
            this.OpenDishAccessoryPnl.BackColor = System.Drawing.Color.White;
            this.OpenDishAccessoryPnl.Location = new System.Drawing.Point(42, 227);
            this.OpenDishAccessoryPnl.Name = "OpenDishAccessoryPnl";
            this.OpenDishAccessoryPnl.Size = new System.Drawing.Size(393, 257);
            this.OpenDishAccessoryPnl.TabIndex = 9;
            // 
            // itemprice_lbl
            // 
            this.itemprice_lbl.AutoSize = true;
            this.itemprice_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemprice_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemprice_lbl.Location = new System.Drawing.Point(39, 648);
            this.itemprice_lbl.Name = "itemprice_lbl";
            this.itemprice_lbl.Size = new System.Drawing.Size(47, 16);
            this.itemprice_lbl.TabIndex = 2;
            this.itemprice_lbl.Text = "label1";
            // 
            // opendish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 690);
            this.Controls.Add(this.OpenDishAccessoryPnl);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.atc_btn);
            this.Controls.Add(this.itemcount);
            this.Controls.Add(this.buy_btn);
            this.Controls.Add(this.itemprice_lbl);
            this.Controls.Add(this.itemname_lbl);
            this.Controls.Add(this.itemdesc_lbl);
            this.Name = "opendish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "opendish";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.opendish_FormClosed);
            this.Load += new System.EventHandler(this.opendish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemdesc_lbl;
        private System.Windows.Forms.Label itemname_lbl;
        private System.Windows.Forms.Button buy_btn;
        private System.Windows.Forms.Label itemcount;
        private System.Windows.Forms.Button atc_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Panel OpenDishAccessoryPnl;
        private System.Windows.Forms.Label itemprice_lbl;
    }
}