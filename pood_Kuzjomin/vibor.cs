using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pood_Kuzjomin
{
    public partial class vibor : Form
    {
        public vibor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin kas = new Admin();
            kas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient kl = new Klient();
            kl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
