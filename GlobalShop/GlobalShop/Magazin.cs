using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalShop.Controllers.Products;
using System.Windows.Forms;

namespace GlobalShop
{
    public partial class Magazin : MetroForm
    {
        User user;
        public Magazin(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        public Magazin()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
           

        }

        private void Magazin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;


            List<Produse> produse = new List<Produse>();
            produse=ProduseController.GetProduse().ToList();
            foreach(Produse p in produse)
            {
                comboBox1.Items.Add(p.NumeProdus+" Pret=  "+p.Pret);
            }
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            List<Produse> produses = new List<Produse>(8);
            produse = RandomProducts.RandomProduse();
            for(int i = 0; i < 8; i++)
            {
                smallLabels[i].Text = produse[i].NumeProdus;
                bigLabels[i].Text = produse[i].Pret.ToString();
                
            }

        }

        private void CategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            /*crollBar1.Dock = DockStyle.Right();
            vScrollBar1.Scroll += (sender, e) => { panel2.VerticalScroll.Value = vScrollBar1.Value; };
            panel2.Controls.Add(vScrollBar1);
            */
    }

        private void Magazin_Resize(object sender, EventArgs e)
        {

        }
    }
}
