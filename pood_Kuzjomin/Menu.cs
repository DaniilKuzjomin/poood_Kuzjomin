using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pood_Kuzjomin
{
    public partial class Menu : Form
    {


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Daniil Kuzjomin TARpv21\pood_Kuzjomin\pood_Kuzjomin\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        int Id;
        private SqlDataAdapter adapter;
        private SqlCommand cmd1;

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kassa kas = new Kassa();
            kas.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
