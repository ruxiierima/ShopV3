﻿using GlobalShop.Controllers.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalShop
{
    public partial class AddProducts : Form
    {
        public static List<Produse> produse;

        public AddProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = ProductNameTextBox.Text;
            decimal pret = Decimal.Parse(pretTExtBox.Text);
            int stocProduse = int.Parse(stoc.Text);
            string caracteristici = textBox1.Text;
            int optiune = checkedListBox1.SelectedIndex+1;
            int optiune1 = checkedListBox2.SelectedIndex+1;
            byte[] imagine = imageToByteArray(pictureBox1.Image);
            int categorieId=0;
            int branduriId = 0;

           try
            {
               
            AddProductController.AddProduct(nume, pret, stocProduse, caracteristici, imagine, categorieId,branduriId);

            }
            catch
            {
                MessageBox.Show("A aparut o eroareeeeee", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void deleteLabels()
        {
            ProductNameTextBox.Text = "";
            pretTExtBox.Text = "";
            stoc.Text = "";
            textBox1.Text = "";
            pictureBox1.Image = null;
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }


        //convert Image-to-byte[]
        private byte[] imageToByteArray(Image imagine)
        {
            MemoryStream ms = new MemoryStream();
            imagine.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categorie_Click(object sender, EventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imagine_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg";

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
