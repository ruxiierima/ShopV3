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
    public partial class InfoUsers : Form
    {
        public InfoUsers()
        {
            InitializeComponent();
        }

        public  System.Windows.Forms.Label returnEmail()
        {
            
            return emailtxt;
        }
        public System.Windows.Forms.Label returnTelfon()
        {
            return telefontxt;
        }
        public System.Windows.Forms.Label returnAdresa()
        {
            return adresatxt;
        }
        public System.Windows.Forms.Label returnNickname()
        {
            return nicknametxt;
        }
        public System.Windows.Forms.Label returnName()
        {
            return usersNameAppend;
        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
