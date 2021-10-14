namespace Justeat_replica
{
    partial class SelectionsForm
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
            this.SelectionsPnl = new System.Windows.Forms.Panel();
            this.SelectionsFoodNameLbl = new System.Windows.Forms.Label();
            this.SelectionsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionsPnl
            // 
            this.SelectionsPnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectionsPnl.Controls.Add(this.SelectionsFoodNameLbl);
            this.SelectionsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectionsPnl.Location = new System.Drawing.Point(0, 0);
            this.SelectionsPnl.Margin = new System.Windows.Forms.Padding(20);
            this.SelectionsPnl.Name = "SelectionsPnl";
            this.SelectionsPnl.Padding = new System.Windows.Forms.Padding(20);
            this.SelectionsPnl.Size = new System.Drawing.Size(364, 114);
            this.SelectionsPnl.TabIndex = 0;
            // 
            // SelectionsFoodNameLbl
            // 
            this.SelectionsFoodNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectionsFoodNameLbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionsFoodNameLbl.Location = new System.Drawing.Point(20, 20);
            this.SelectionsFoodNameLbl.Name = "SelectionsFoodNameLbl";
            this.SelectionsFoodNameLbl.Size = new System.Drawing.Size(324, 41);
            this.SelectionsFoodNameLbl.TabIndex = 0;
            this.SelectionsFoodNameLbl.Text = "asdadaddasdasd";
            this.SelectionsFoodNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 114);
            this.Controls.Add(this.SelectionsPnl);
            this.Name = "SelectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionsForm";
            this.Load += new System.EventHandler(this.SelectionsForm_Load);
            this.SelectionsPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectionsPnl;
        private System.Windows.Forms.Label SelectionsFoodNameLbl;
    }
}