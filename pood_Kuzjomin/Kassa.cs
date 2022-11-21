﻿using SautinSoft.Document;
using SautinSoft.Document.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pood_Kuzjomin
{
    public partial class Kassa : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Daniil Kuzjomin TARpv21\pood_Kuzjomin\pood_Kuzjomin\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_toode2, adapter_toode3, adapter_toode4;
        public int Hind;
        PictureBox pictureBox;


        public Kassa()
        {
            InitializeComponent();
            Naita_Andmed();
            Kategooriad();
        }


        int kat_Id;
        List<string> fail_list;
        private SqlDataAdapter failinimi_adap;
        private SqlDataAdapter adapter_kat;

        public List<string> Failid_KatId(int kat_Id) //Failide loetelu igas kategoorijas 
        {
            fail_list = new List<string>();
            failinimi_adap = new SqlDataAdapter("SELECT Pilt FROM Toodetable WHERE Kategooria_Id=" + kat_Id, connect);
            DataTable failid = new DataTable();
            failinimi_adap.Fill(failid);
            foreach (DataRow fail in failid.Rows)
            {
                fail_list.Add(fail["Pilt"].ToString()); //liisame pildi nimetus listisse
            }
            return fail_list;
        }
        public void Kategooriad()
        {

            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);

            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            ImageList iconsList = new ImageList();//
            iconsList.ColorDepth = ColorDepth.Depth32Bit;//
            iconsList.ImageSize = new System.Drawing.Size(25, 25);//

            int i = 0;//
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                tabControl1.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
                iconsList.Images.Add(Image.FromFile(@"..\..\Images\Kat_pildid\" + (string)nimetus["Kategooria_nimetus"] + ".jpg"));//
                tabControl1.TabPages[i].ImageIndex = i;//
                i++;//
                kat_Id = (int)nimetus["Id"]; //Kategooria Id mis kaart loodakse
                fail_list = Failid_KatId(kat_Id);//Failide loetelu
                int r = 0;
                int c = 0;
                foreach (var fail in fail_list)
                {
                    //MessageBox.Show(fail);
                    pictureBox = new PictureBox(); //loob pildi kast
                    pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail);
                    pictureBox.Width = pictureBox.Height = 100; //kasti suurus
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Location = new System.Drawing.Point(c, r); //kasti asukoht
                    c = c + 100 + 2; //järgmise kasti positsion(liigume paremale)
                    tabControl1.TabPages[i - 1].Controls.Add(pictureBox); //lisame pilt kaardile

                }
            }
            tabControl1.ImageList = iconsList;//
            connect.Close();
            this.Controls.Add(tabControl1);
        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                numericUpDown1.Enabled = true;

                nimi1_lbl.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                numericUpDown1.Maximum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                Hind = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception)
            {
            }

           
            try
            {
                kassa_img.Image = System.Drawing.Image.FromFile(@"..\..\images\" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
                kassa_img.Image = System.Drawing.Image.FromFile(@"..\..\Images\about.png");
                MessageBox.Show("Pilt puudub");

            }


        }

        private void Tsekk_btn_Click(object sender, EventArgs e)
        {
            CreatePdfUsingDocumentBuilder();
            Kustuta_Korv();

        }

        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Korv (Toodenimetus, Kogus, Hind) VALUES (@Toodenimetus, @Kogus, @Hind)",connect);

            connect.Open();

            cmd.Parameters.AddWithValue("@Toodenimetus", nimi1_lbl.Text);
            cmd.Parameters.AddWithValue("@Kogus", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@Hind", Hind);
            
            cmd.ExecuteNonQuery();
            kogusiki();
            connect.Close();
            Naita_Andmed();




        }
        int Id;

        private void kogusiki()
        {
            cmd = new SqlCommand("UPDATE Toodetable SET Kogus=Kogus-@kogus WHERE Id=@id", connect);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@kogus", numericUpDown1.Value);

            cmd.ExecuteNonQuery();
        }

        private void Tabcontrol_Click(object sender, EventArgs e)
        {

        }

        private void Kustuta_Korv()
        {
            cmd = new SqlCommand("DELETE FROM Korv", connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();

        }


        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            adapter_toode = new SqlDataAdapter("SELECT Toodenimetus, Kogus, Hind, Pilt, Kategooria_id FROM Toodetable", connect);
            adapter_toode2 = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter_toode3 = new SqlDataAdapter("SELECT Toodenimetus, Kogus, Hind, Pilt, Kategooria_id FROM Toodetable", connect);

            adapter_toode.Fill(dt);
            dataGridView1.DataSource = dt;

            adapter_toode.Fill(dt1);
            dataGridView1.DataSource = dt1;

            adapter_toode.Fill(dt2);
            dataGridView1.DataSource = dt2;


            kassa_img.Image = Image.FromFile("../../Images/about.png");
            kassa_img.SizeMode = PictureBoxSizeMode.StretchImage;

            connect.Close();
        }


        public void CreatePdfUsingDocumentBuilder()
        {
            // Set a path to our document.
            string docPath = Path.GetFullPath(@"..\..\Tsekk") + @"\Tsekk.pdf";

            Random rnd = new Random();

            int value = rnd.Next(10000, 99999);
            

            // Create a new document and DocumentBuilder.
            DocumentCore dc = new DocumentCore();
            DocumentBuilder db = new DocumentBuilder(dc);

            // Set page size A4.
            Section section = db.Document.Sections[0];
            section.PageSetup.PaperType = PaperType.A4;

            // Add 1st paragraph with formatted text.
            db.CharacterFormat.FontName = "Arial";
            db.CharacterFormat.Size = 16;
            db.CharacterFormat.FontColor = SautinSoft.Document.Color.Gray;
            db.Write("Pyatorochka Market");
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.Write("Reg.kood " + value);
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            db.Write("Arve/Kviitung");
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            // Add a line break into the 1st paragraph.
            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
            // Add 2nd line to the 1st paragraph, create 2nd paragraph.
            string now = DateTime.Now.ToLongDateString();
            db.Writeln("Kuupaev " + now);

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);


            


            


            List<string> Tooded_list = new List<string>();

            Tooded_list.Add("Toode   Kogus   Hind");
            Tooded_list.Add(nimi1_lbl.Text + "         " + numericUpDown1.Value + "       " + (Hind*numericUpDown1.Value));




            foreach (var toode in Tooded_list)
            {
                db.Writeln(toode);
            }

            (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;

            db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

            db.Writeln("----------");

            db.Writeln("Kokku:" + Hind);

            (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Right;


            




            // Specify the paragraph alignment.
            (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Left;

            // Add text into the 2nd paragraph.
            db.CharacterFormat.ClearFormatting();
            db.CharacterFormat.Size = 25;
            db.CharacterFormat.FontColor = SautinSoft.Document.Color.Black;
            db.CharacterFormat.Bold = true;


            // Save the document to the file in PDF format.
            dc.Save(docPath, new PdfSaveOptions()
            { Compliance = PdfCompliance.PDF_A1a });

            // Open the result for demonstration purposes.
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(docPath) { UseShellExecute = true });
        }

    }
}
