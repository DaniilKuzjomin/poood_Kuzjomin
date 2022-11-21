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
    public partial class Login : Form
    {
        private SqlConnection connect;
        private SqlCommand cmd, cmd1;
        private SqlDataReader dr, dr1;
        private SqlDataAdapter adapter_oig;
        public string oigus_ch;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Daniil Kuzjomin TARpv21\pood_Kuzjomin\pood_Kuzjomin\AppData\Tooded_DB.mdf;Integrated Security=True");
            connect.Open();
        }


        private void robert()
        {
            adapter_oig = new SqlDataAdapter("SELECT oigused FROM Login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", connect);


            DataTable dt_oig = new DataTable();
            adapter_oig.Fill(dt_oig);

            foreach (DataRow nimetus in dt_oig.Rows)
            {
                oigus_ch = (string)nimetus["oigused"];
            }

            connect.Close();




        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {

                robert();


                connect.Open();

                cmd1 = new SqlCommand("select oigused from Login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", connect);

                dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {
                    if (oigus_ch == "Admin")
                    {
                        dr1.Close();
                        MenuAdmin admin = new MenuAdmin();
                        admin.ShowDialog();
                    }
                    else if (oigus_ch == "Kasutaja")
                    {
                        dr1.Close();
                        Menu kasutaja = new Menu();
                        kasutaja.ShowDialog();
                    }
                    else
                    {
                        dr1.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dr1.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                connect.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
