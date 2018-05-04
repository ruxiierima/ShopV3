using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalShop.Controllers.Seller
{
    class AddProductController
    {
        private static ShopEntities shop = new ShopEntities();
        
        public static void AddProduct(string Nume,decimal Pret,int Stoc,string Caracteristici, byte[] Imagine)
        {
            Produse produs = new Produse(Nume, Pret, Stoc, Caracteristici, Imagine);
            try
            {
                AddProductController.CreateProduct(produs);
                MessageBox.Show("Produs adaugat cu succes","ADAUGAt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception)
            {
                MessageBox.Show("A aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CreateProduct(Produse produs)
        {
            shop.Produses.Add(produs);
           // shop.SaveChanges();
        }
       
    }
}
