namespace frmquanlybanhang
{
    partial class frmChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChung));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongkehanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongkedoanhthuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHàngHóaToolStripMenuItem,
            this.hóaĐơnBánHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1380, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.quảnLýHàngHóaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản lý hàng hóa";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // hóaĐơnBánHàngToolStripMenuItem
            // 
            this.hóaĐơnBánHàngToolStripMenuItem.Name = "hóaĐơnBánHàngToolStripMenuItem";
            this.hóaĐơnBánHàngToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.hóaĐơnBánHàngToolStripMenuItem.Text = "Hóa đơn bán hàng";
            this.hóaĐơnBánHàngToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongkehanghoaToolStripMenuItem,
            this.ThongkedoanhthuToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // ThongkehanghoaToolStripMenuItem
            // 
            this.ThongkehanghoaToolStripMenuItem.Name = "ThongkehanghoaToolStripMenuItem";
            this.ThongkehanghoaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ThongkehanghoaToolStripMenuItem.Text = "Thống kê hàng hóa";
            this.ThongkehanghoaToolStripMenuItem.Click += new System.EventHandler(this.ThongkehanghoaToolStripMenuItem_Click);
            // 
            // ThongkedoanhthuToolStripMenuItem
            // 
            this.ThongkedoanhthuToolStripMenuItem.Name = "ThongkedoanhthuToolStripMenuItem";
            this.ThongkedoanhthuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ThongkedoanhthuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.ThongkedoanhthuToolStripMenuItem.Click += new System.EventHandler(this.ThongkedoanhthuToolStripMenuItem_Click);
            // 
            // frmChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 561);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng bán hàng tạp hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChung_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongkehanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongkedoanhthuToolStripMenuItem;
    }
}