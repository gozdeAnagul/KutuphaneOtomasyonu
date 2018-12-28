using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        private UyeForm uyeForm;
        private KitapForm kitapForm;
        private KiraForm kiraForm;
 

        private void uyeEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (uyeForm == null || uyeForm.IsDisposed)
            {
                uyeForm = new UyeForm();
            }
            uyeForm.MdiParent = this;
            uyeForm.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kitapForm == null || kitapForm.IsDisposed)
            {
                kitapForm = new KitapForm();
            }
            kitapForm.MdiParent = this;
            kitapForm.Show();
        }

        private void kiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiraForm == null || kiraForm.IsDisposed)
            {
                kiraForm = new KiraForm();
            }
            kiraForm.MdiParent = this;
            kiraForm.Show();
        }
    }
}
