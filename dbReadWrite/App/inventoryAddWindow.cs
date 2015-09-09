using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class inventoryAddWindow : Form
    {
        Database PackingDB = new Database();
        public inventoryAddWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (inputEm.Text != "")
            {
                string iii = PackingDB.checkEmployee("1337")[5][0];
                Console.WriteLine(iii);
            }
           
        }

    }
}
