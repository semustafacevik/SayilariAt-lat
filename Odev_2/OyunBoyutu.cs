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

        private void On_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            boyut = Convert.ToInt32(btn.Name.Substring(3, 1)); // 5x5 boyutunda oyun oluşturulacak.
            Hide();
        }
    }
}
