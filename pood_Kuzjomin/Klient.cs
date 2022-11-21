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
    public partial class Klient : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Daniil Kuzjomin TARpv21\pood_Kuzjomin\pood_Kuzjomin\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        private SqlDataAdapter adapter_toode;

        public Klient()
        {
            InitializeComponent();
            Naita_Andmed();
        }

        public void Kustuta_Andmed()
        {
            text2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }


        public void Naita_Andmed()
        {
            connect.Open();
            DataTable tbl = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Klient", connect);
            adapter_toode.Fill(tbl);
            dataGridView1.DataSource = tbl;

            connect.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != String.Empty && textBox2.Text.Trim() != String.Empty && text2.Text.Trim() != String.Empty)
            {

                cmd = new SqlCommand("INSERT INTO Klient (nimi, telefoninumber, isikukood) VALUES (@nimi, @telef, @isik)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@nimi", text2.Text);
                cmd.Parameters.AddWithValue("@telef", textBox1.Text);
                cmd.Parameters.AddWithValue("@isik", textBox2.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                Kustuta_Andmed();
                Naita_Andmed();



            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    return;

                string sql = "DELETE FROM Klient WHERE Id = @rowID";

                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    connect.Open();

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int RowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = RowID;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);

                    connect.Close();
                }
            }
        }
    }
}
