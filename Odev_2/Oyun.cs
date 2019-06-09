using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    public partial class Oyun : Form
    {
        Kontrol kntrl;
        OyunBoyutu oyunb = new OyunBoyutu();
        
        public Oyun()
        {
            InitializeComponent();
            kntrl = new Kontrol(pnlOyun, lblKutucuk, lblHamle);
            Show();
            oyunb.ShowDialog();
            kntrl.KutucuklariOlustur(oyunb.boyut);
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            DialogResult dr = MsgBox.Show("Oyun Sıfırlansın Mı?", "Yeni Oyun",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                kntrl.OyunuSifirla();
                oyunb.ShowDialog();
                kntrl.KutucuklariOlustur(oyunb.boyut);
            }
        }

        private void Oyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MsgBox.Show("Oyundan Çıkış Yapılacak. Onaylıyor Musunuz?", "Çıkış",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                Environment.Exit(0);

            else
                e.Cancel = true;
        }
    }
}
