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
        }

        private void Magazin_Load(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
