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

namespace GlobalShop
{
    public partial class Magazin : MetroForm
    {
        User user;
        public static List<Produse> produses;
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

            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;


            List<PictureBox> pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            List<Label> smallLabels = new List<Label> { label3, label4, label5, label6, label7, label8, label9, label10 };
            List<Label> bigLabels = new List<Label> { label13, label14, label15, label16, label17, label18, label19, label20 };
            
            produses = RandomProducts.RandomProduse();
            for (int i = 0; i < 8; i++)
            {
                smallLabels[i].Text = produses[i].NumeProdus;
                bigLabels[i].Text = produses[i].Pret.ToString();

            }

        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Visible=true;
            panel2.Visible = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }
    }
}
