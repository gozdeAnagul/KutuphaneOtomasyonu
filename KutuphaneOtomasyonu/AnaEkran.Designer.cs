namespace KutuphaneOtomasyonu
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.msEkle = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEkle
            // 
            this.msEkle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.kiralaToolStripMenuItem});
            this.msEkle.Location = new System.Drawing.Point(0, 0);
            this.msEkle.Name = "msEkle";
            this.msEkle.Size = new System.Drawing.Size(959, 24);
            this.msEkle.TabIndex = 2;
            this.msEkle.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyeEkleToolStripMenuItem,
            this.kitapEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // uyeEkleToolStripMenuItem
            // 
            this.uyeEkleToolStripMenuItem.Name = "uyeEkleToolStripMenuItem";
            this.uyeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uyeEkleToolStripMenuItem.Text = "Uye ekle";
            this.uyeEkleToolStripMenuItem.Click += new System.EventHandler(this.uyeEkleToolStripMenuItem_Click_1);
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapEkleToolStripMenuItem.Text = "Kitap ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kiralaToolStripMenuItem
            // 
            this.kiralaToolStripMenuItem.Name = "kiralaToolStripMenuItem";
            this.kiralaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.kiralaToolStripMenuItem.Text = "Kirala";
            this.kiralaToolStripMenuItem.Click += new System.EventHandler(this.kiralaToolStripMenuItem_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 480);
            this.Controls.Add(this.msEkle);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msEkle;
            this.Name = "AnaEkran";
            this.Text = "Ana Ekran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msEkle.ResumeLayout(false);
            this.msEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEkle;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralaToolStripMenuItem;
    }
}

