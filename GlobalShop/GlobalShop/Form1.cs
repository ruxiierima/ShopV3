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

namespace GlobalShop
{
    public partial class Form1 : Form
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
            LoginController.Login(emailAdress);
            

            
        }
    }
}
