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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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
        {   /*
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile("C:\\Users\\ierima\\acer.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

*/
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
                bigLabels[i].Text = produses[i].Pret.ToString()+" Lei";

            }

        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Visible=true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            label24.Text = produses[0].NumeProdus;
            pret.Text = produses[0].Pret.ToString()+" Lei";

            if (CheckStoc.Check(produses[0]) == true)
            {
                label12.Text = "In Stoc";
                label12.BackColor = Color.Green;
            }
            else if (CheckStoc.Check(produses[0]) == false)
            {
                label12.Text = "Stoc epuizat";
                label12.BackColor = Color.Red;

            }
            label21.Text = produses[0].Caracteristici;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }

        /*private void button12_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            label24.Text = produses[1].NumeProdus;
            pret.Text = produses[1].Pret.ToString() + " Lei";

            if (CheckStoc.Check(produses[1]) == true)
            {
                label12.Text = "In Stoc";
                label12.BackColor = Color.Green;
            }
            else if (CheckStoc.Check(produses[1]) == false)
            {
                label12.Text = "Stoc epuizat";
                label12.BackColor = Color.Red;

            }
            label21.Text = produses[1].Caracteristici;

        }*/
        private void buttonHandler(object sender, EventArgs e,int i)
        {
            
            
            panel4.Visible = true;
            panel2.Visible = false;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            label23.Text = "Livrare standard: Ajunge in data de " + tomorrow.ToString("dd-MM-yyyy");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Chiorean Dan\\Desktop\\Poze produse\\acer.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            label24.Text = produses[i].NumeProdus;
            pret.Text = produses[i].Pret.ToString() + " Lei";

            if (CheckStoc.Check(produses[i]) == true)
            {
                label12.Text = "In Stoc";
                label12.BackColor = Color.Green;
            }
            else if (CheckStoc.Check(produses[i]) == false)
            {
                label12.Text = "Stoc epuizat";
                label12.BackColor = Color.Red;

            }
            label21.Text = produses[i].Caracteristici;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            for(int i = 0; i < comboBox2.Items.Count; i++)
            {
                comboBox2.Items.RemoveAt(i);
            }
            List<Produse> produses = new List<Produse>();
            produses = CautareProduse.searchP(comboBox2.Text);
            comboBox2.DroppedDown = true;
            foreach(Produse p in produses)
            {
                comboBox2.Items.Add(p.NumeProdus);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            AddProducts product = new AddProducts();
            product.Show();
        }
    }
}
