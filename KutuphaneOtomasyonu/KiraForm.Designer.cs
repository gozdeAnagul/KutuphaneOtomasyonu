namespace KutuphaneOtomasyonu
{
    partial class KiraForm
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
            this.lst_Kitap = new System.Windows.Forms.ListBox();
            this.lst_Kira = new System.Windows.Forms.ListBox();
            this.txt_KiraId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_KiralamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_Uyeler = new System.Windows.Forms.ComboBox();
            this.btn_Kirala = new System.Windows.Forms.Button();
            this.btn_iade = new System.Windows.Forms.Button();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_Kitap
            // 
            this.lst_Kitap.FormattingEnabled = true;
            this.lst_Kitap.Location = new System.Drawing.Point(12, 46);
            this.lst_Kitap.Name = "lst_Kitap";
            this.lst_Kitap.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_Kitap.Size = new System.Drawing.Size(249, 329);
            this.lst_Kitap.TabIndex = 0;
            // 
            // lst_Kira
            // 
            this.lst_Kira.FormattingEnabled = true;
            this.lst_Kira.Location = new System.Drawing.Point(295, 197);
            this.lst_Kira.Name = "lst_Kira";
            this.lst_Kira.Size = new System.Drawing.Size(304, 173);
            this.lst_Kira.TabIndex = 1;
            // 
            // txt_KiraId
            // 
            this.txt_KiraId.Location = new System.Drawing.Point(362, 46);
            this.txt_KiraId.Name = "txt_KiraId";
            this.txt_KiraId.Size = new System.Drawing.Size(200, 20);
            this.txt_KiraId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kira No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kiralama Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Üyeler:";
            // 
            // dtp_KiralamaTarihi
            // 
            this.dtp_KiralamaTarihi.Location = new System.Drawing.Point(362, 144);
            this.dtp_KiralamaTarihi.Name = "dtp_KiralamaTarihi";
            this.dtp_KiralamaTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_KiralamaTarihi.TabIndex = 9;
            // 
            // cmb_Uyeler
            // 
            this.cmb_Uyeler.FormattingEnabled = true;
            this.cmb_Uyeler.Location = new System.Drawing.Point(362, 91);
            this.cmb_Uyeler.Name = "cmb_Uyeler";
            this.cmb_Uyeler.Size = new System.Drawing.Size(200, 21);
            this.cmb_Uyeler.TabIndex = 8;
            // 
            // btn_Kirala
            // 
            this.btn_Kirala.Location = new System.Drawing.Point(568, 46);
            this.btn_Kirala.Name = "btn_Kirala";
            this.btn_Kirala.Size = new System.Drawing.Size(83, 45);
            this.btn_Kirala.TabIndex = 14;
            this.btn_Kirala.Text = "Kirala";
            this.btn_Kirala.UseVisualStyleBackColor = true;
            // 
            // btn_iade
            // 
            this.btn_iade.Location = new System.Drawing.Point(568, 119);
            this.btn_iade.Name = "btn_iade";
            this.btn_iade.Size = new System.Drawing.Size(83, 45);
            this.btn_iade.TabIndex = 15;
            this.btn_iade.Text = "İade Et";
            this.btn_iade.UseVisualStyleBackColor = true;
            this.btn_iade.Visible = false;
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(12, 13);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(249, 20);
            this.txt_Ara.TabIndex = 16;
            // 
            // KiraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 382);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.btn_iade);
            this.Controls.Add(this.btn_Kirala);
            this.Controls.Add(this.txt_KiraId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_KiralamaTarihi);
            this.Controls.Add(this.cmb_Uyeler);
            this.Controls.Add(this.lst_Kira);
            this.Controls.Add(this.lst_Kitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "KiraForm";
            this.Text = "KiraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Kitap;
        private System.Windows.Forms.ListBox lst_Kira;
        private System.Windows.Forms.TextBox txt_KiraId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_KiralamaTarihi;
        private System.Windows.Forms.ComboBox cmb_Uyeler;
        private System.Windows.Forms.Button btn_Kirala;
        private System.Windows.Forms.Button btn_iade;
        private System.Windows.Forms.TextBox txt_Ara;
    }
}