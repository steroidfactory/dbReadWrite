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
    public partial class authenticationID : Form
    {
        public string ID { get; set; }
        public authenticationID()
        {
            InitializeComponent();
        }

        private void authenticationID_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginID_Click(object sender, EventArgs e)
        {
            closeOK();  
        }

        private void btnInputIDCancel_Click(object sender, EventArgs e)
        {
            closeCancel();
        }

        private void inputLoginID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                closeOK();
            }
            if (e.KeyCode == Keys.Escape)
            {
                closeCancel();
            }
        }
        
        private void closeOK()
        {
            if (inputLoginID.Text != "")
            {
                this.ID = inputLoginID.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeCancel()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
