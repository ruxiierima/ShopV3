using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalShop
{
    
    public partial class AdministrationShop : Form
    {

      

        private static ShopEntities shop = new ShopEntities();
        public AdministrationShop()
        {
            InitializeComponent();
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            
            users = Controllers.UserController.GeetUsers();
            viewUsersLIst.Items.AddRange(users.ToArray());
            viewUsersLIst.DisplayMember = "NumePrenume";
           




        }

        private void viewUsersLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            viewUsersLIst.Items.Remove(viewUsersLIst.SelectedItem);
            string numeUser = viewUsersLIst.GetItemText(viewUsersLIst.SelectedItem);
            DeleteUser(numeUser);
            
        }

        private void viewProduct_Click(object sender, EventArgs e)
        {
           
            
            
        }

       

        private void info_user_Click(object sender, EventArgs e)
        {
            
         
            List<User> users = new List<User>();

            users = Controllers.UserController.GeetUsers();
            InfoUsers info = new InfoUsers();
           

            ShopEntities shop = new ShopEntities();
            string numeUser = viewUsersLIst.GetItemText(viewUsersLIst.SelectedItem).ToString();
            var getinformation = shop.Users.Where(a => a.NumePrenume == numeUser).FirstOrDefault();
             info.returnEmail().Text= getinformation.Email;
            info.returnAdresa().Text = getinformation.Adresa;
            info.returnNickname().Text = getinformation.Nickname;
            info.returnTelfon().Text = getinformation.Telefon;
            info.returnName().Text = "Informatii utilizator :" + getinformation.NumePrenume;




            
            info.Show();
        }

        public void DeleteUser(string nume)
        {
            User delObj = shop.Users.Where(a => a.NumePrenume == nume).FirstOrDefault();
            shop.Users.Remove(delObj);
            shop.SaveChanges();
        }
    }
    }

