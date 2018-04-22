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
    public partial class Register : MetroForm
    {
        private string email;
        public Register(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void numar_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(numar.Text, out parsedValue))
            {
                MessageBox.Show("Caracter invalid");
                return;
            }
        }

        private void continua_Click(object sender, EventArgs e)
        {
            string name = nume.Text;
            string tel = numar.Text;
            string nick = nickname.Text;
            string adr = adresa.Text;
            string passwrd = pass.Text;
            string passconf = passconfirmation.Text;
            if (passwrd == passconf && RegisterController.ValidatePassword(passwrd)==true)
            {
                try
                {
                    RegisterController.Register(name, email, tel, adr, passwrd, nick);
                    Magazin magazin = new Magazin();
                    magazin.Show();
                    this.Close();
                    ConfirmationMail.SendEmail(email,nick);
                }
                catch
                {
                    MessageBox.Show("A aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Parola este invalida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
