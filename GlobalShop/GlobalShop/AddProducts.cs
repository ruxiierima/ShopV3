using GlobalShop.Controllers.Seller;
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
            int optiune = checkedListBox1.SelectedIndex;
            int optiune1 = checkedListBox2.SelectedIndex;
            string CategorieProdus = checkedListBox1.GetItemText(optiune);
            string BrandProdus = checkedListBox2.GetItemText(optiune1);
            byte[] imagine = imageToByteArray(pictureBox1.Image);
            int categorieId=0;
            int branduriId = 0;

           // try
          //  {
                switch (CategorieProdus)
                {
                    case "Laptopuri":
                        categorieId = 1;
                        break;
                    case "Tablete":
                        categorieId = 2;
                        break;
                    case "Telefoane":
                        categorieId = 3;
                        break;
                    case "PC si Periferice":
                        categorieId = 4;
                        break;
                    case "TV si Audio-Video":
                        categorieId = 5;
                        break;
                    case "Gaming":
                        categorieId = 6;
                        break;
                    case "Haine":
                        categorieId = 7;
                        break;
                    case "Carti":
                        categorieId = 8;
                        break;
                    case "Auto si Moto":
                        categorieId = 9;
                        break;
                         }

                switch (BrandProdus)
                {
                    case "Lenovo":
                        branduriId = 1;
                        break;
                    case "HP":
                        branduriId = 2;
                        break;
                    case "Asus":
                        branduriId = 3;
                        break;
                    case "Dell":
                        branduriId = 4;
                        break;
                    case "Acer":
                        branduriId = 5;
                        break;
                    case "Apple":
                        branduriId = 6;
                        break;
                    case "MSI":
                        branduriId = 7;
                        break;
                    case "Toshiba":
                        branduriId = 8;
                        break;
                    case "Microsoft":
                        branduriId = 9;
                        break;
                    case "Samsung":
                        branduriId = 10;
                        break;
                    case "Huawei":
                        branduriId = 11;
                        break;
                    case "Xia0mi":
                        branduriId = 12;
                        break;
                    case "Sony":
                         branduriId = 13;
                    break;
                    case "LG":
                        branduriId = 14;
                    break;
                    case "Allview":
                        branduriId = 15;
                    break;
                     case "HTC":
                        branduriId = 16;
                    break;


            }

            AddProductController.AddProduct(nume, pret, stocProduse, caracteristici, imagine, categorieId,branduriId);

          //  }
            //catch
            //{
             //   MessageBox.Show("A aparut o eroareeeeee", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }

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
