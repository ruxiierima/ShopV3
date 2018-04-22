using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalShop.Controllers;
using MetroFramework.Forms;

namespace GlobalShop
{
    public partial class Form1 : MetroForm
    {
        string emailAdress;
        public Form1()
        {
            InitializeComponent();
            ShopEntities shop = new ShopEntities();

            
        }

        private void continua_Click(object sender, EventArgs e)
        {
            emailAdress = email.Text;
            if (LoginController.IsValidEmail(emailAdress) == true)
            {
                if (LoginController.Login(emailAdress) == true)
                {
                    Log log = new Log(emailAdress);
                    log.Show();

                }
                else
                {
                    Register register = new Register(emailAdress);
                    register.Show();
                }
            }
            else
            {
                MessageBox.Show("Adresa de email este invalida", "Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Clear();
            }

            

            
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
