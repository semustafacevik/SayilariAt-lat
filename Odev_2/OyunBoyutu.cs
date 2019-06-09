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
    public partial class OyunBoyutu : Form
    {
        public int boyut;

        public OyunBoyutu()
        {
            InitializeComponent();
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            boyut = 5; // 5x5 boyutunda oyun oluşturulacak.
            Hide();
        }

        private void btn6x6_Click(object sender, EventArgs e)
        {
            boyut = 6; // 6x6 boyutunda oyun oluşturulacak.
            Hide();
        }

        private void btn7x7_Click(object sender, EventArgs e)
        {
            boyut = 7; // 7x7 boyutunda oyun oluşturulacak.
            Hide();
        }

        private void btn8x8_Click(object sender, EventArgs e)
        {
            boyut = 8; // 8x8 boyutunda oyun oluşturulacak.
            Hide();
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            boyut = 9; // 9x9 boyutunda oyun oluşturulacak.
            Hide();
        } 
    }
}
