﻿using System.Windows.Forms;

namespace pood_Kuzjomin
{
    partial class Form1
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
            this.tooded_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.kategooria_lbl = new System.Windows.Forms.Label();
            this.Kat_Combo = new System.Windows.Forms.ComboBox();
            this.Otsi_btn = new System.Windows.Forms.Button();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kat_button = new System.Windows.Forms.Button();
            this.kat_btn = new System.Windows.Forms.Button();
            this.Kogus_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Hind_UpDown = new System.Windows.Forms.NumericUpDown();
            this.Toode_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hind_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_img)).BeginInit();
            this.SuspendLayout();
            // 
            // tooded_txt
            // 
            this.tooded_txt.Location = new System.Drawing.Point(95, 42);
            this.tooded_txt.Name = "tooded_txt";
            this.tooded_txt.Size = new System.Drawing.Size(100, 20);
            this.tooded_txt.TabIndex = 0;
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Location = new System.Drawing.Point(12, 45);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(77, 13);
            this.Toode_lbl.TabIndex = 2;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Location = new System.Drawing.Point(52, 89);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(37, 13);
            this.Kogus_lbl.TabIndex = 3;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Location = new System.Drawing.Point(60, 129);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(29, 13);
            this.Hind_lbl.TabIndex = 4;
            this.Hind_lbl.Text = "Hind";
            // 
            // kategooria_lbl
            // 
            this.kategooria_lbl.AutoSize = true;
            this.kategooria_lbl.Location = new System.Drawing.Point(12, 173);
            this.kategooria_lbl.Name = "kategooria_lbl";
            this.kategooria_lbl.Size = new System.Drawing.Size(58, 13);
            this.kategooria_lbl.TabIndex = 6;
            this.kategooria_lbl.Text = "Kategooria";
            // 
            // Kat_Combo
            // 
            this.Kat_Combo.FormattingEnabled = true;
            this.Kat_Combo.Location = new System.Drawing.Point(74, 170);
            this.Kat_Combo.Name = "Kat_Combo";
            this.Kat_Combo.Size = new System.Drawing.Size(121, 21);
            this.Kat_Combo.TabIndex = 7;
            // 
            // Otsi_btn
            // 
            this.Otsi_btn.Location = new System.Drawing.Point(577, 63);
            this.Otsi_btn.Name = "Otsi_btn";
            this.Otsi_btn.Size = new System.Drawing.Size(143, 64);
            this.Otsi_btn.TabIndex = 9;
            this.Otsi_btn.Text = "Otsi fail";
            this.Otsi_btn.UseVisualStyleBackColor = true;
            this.Otsi_btn.Click += new System.EventHandler(this.Otsi_btn_Click);
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.Location = new System.Drawing.Point(699, 175);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(89, 41);
            this.Kustuta_btn.TabIndex = 10;
            this.Kustuta_btn.Text = "Kustuta";
            this.Kustuta_btn.UseVisualStyleBackColor = true;
            this.Kustuta_btn.Click += new System.EventHandler(this.Kustuta_btn_Click);
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Location = new System.Drawing.Point(509, 175);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(89, 41);
            this.Lisa_btn.TabIndex = 11;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Location = new System.Drawing.Point(604, 175);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(89, 41);
            this.Uuenda_btn.TabIndex = 12;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            this.Uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(728, 214);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // kat_button
            // 
            this.kat_button.Location = new System.Drawing.Point(3, 197);
            this.kat_button.Name = "kat_button";
            this.kat_button.Size = new System.Drawing.Size(100, 29);
            this.kat_button.TabIndex = 14;
            this.kat_button.Text = "Lisa kategooria";
            this.kat_button.UseVisualStyleBackColor = true;
            this.kat_button.Click += new System.EventHandler(this.kat_button_Click);
            // 
            // kat_btn
            // 
            this.kat_btn.Location = new System.Drawing.Point(109, 197);
            this.kat_btn.Name = "kat_btn";
            this.kat_btn.Size = new System.Drawing.Size(113, 29);
            this.kat_btn.TabIndex = 15;
            this.kat_btn.Text = "Kustuta Kategooria";
            this.kat_btn.UseVisualStyleBackColor = true;
            this.kat_btn.Click += new System.EventHandler(this.kat_btn_Click);
            // 
            // Kogus_UpDown
            // 
            this.Kogus_UpDown.Location = new System.Drawing.Point(95, 86);
            this.Kogus_UpDown.Name = "Kogus_UpDown";
            this.Kogus_UpDown.Size = new System.Drawing.Size(100, 20);
            this.Kogus_UpDown.TabIndex = 16;
            // 
            // Hind_UpDown
            // 
            this.Hind_UpDown.Location = new System.Drawing.Point(95, 127);
            this.Hind_UpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Hind_UpDown.Name = "Hind_UpDown";
            this.Hind_UpDown.Size = new System.Drawing.Size(100, 20);
            this.Hind_UpDown.TabIndex = 17;
            // 
            // Toode_img
            // 
            this.Toode_img.Location = new System.Drawing.Point(228, 12);
            this.Toode_img.Name = "Toode_img";
            this.Toode_img.Size = new System.Drawing.Size(275, 204);
            this.Toode_img.TabIndex = 8;
            this.Toode_img.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hind_UpDown);
            this.Controls.Add(this.Kogus_UpDown);
            this.Controls.Add(this.kat_btn);
            this.Controls.Add(this.kat_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.Otsi_btn);
            this.Controls.Add(this.Toode_img);
            this.Controls.Add(this.Kat_Combo);
            this.Controls.Add(this.kategooria_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.tooded_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kogus_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hind_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tooded_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label kategooria_lbl;
        private System.Windows.Forms.ComboBox Kat_Combo;
        private System.Windows.Forms.PictureBox Toode_img;
        private System.Windows.Forms.Button Otsi_btn;
        private System.Windows.Forms.Button Kustuta_btn;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kat_button;
        private System.Windows.Forms.Button kat_btn;
        private NumericUpDown Kogus_UpDown;
        private NumericUpDown Hind_UpDown;
    }
}

