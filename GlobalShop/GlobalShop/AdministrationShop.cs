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
            
           // viewUsersLIst.Items.Add(shop.Users.ToList());
            using (OleDbCommand command = new OleDbCommand())
            {
                
                 //   command.Connection = connection;
                command.CommandText = "SELECT NumePrenume FROM Users ";
                //whenever you want to get some data from the database
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        viewUsersLIst.Items.Add(reader["CountryName"].ToString());
                    }
                }
            }
        }

        private void viewUsersLIst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            viewUsersLIst.Items.Remove(viewUsersLIst.SelectedItem);
        }
    }
}
