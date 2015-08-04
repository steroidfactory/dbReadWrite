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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addQ();
            input1.Focus();
        }

        //public Dictionary<int, List<string>> portsText = new Dictionary<int, List<string>>();

        private void input1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void input3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input2.Focus();
            }
        }

        private void input2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input3.Focus();
            }
        }

        private void input3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addReadBox(listQT.SelectedIndex + 1, input1.Text, input2.Text, input3.Text);
                resetInput();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void addQ()
        {
            for (int i = 1; i < 100; i++)
            {
                Task taskA = Task.Factory.StartNew(() => listQT.Items.Add(i));
                taskA.Wait();
            }
            listQT.SelectedIndex = 0;
        }

        private void listQT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input1.Focus();
            }
        }


        private void resetInput()
        {
            listQT.SelectedIndex = 0;
            input1.Clear();
            input2.Clear();
            input3.Clear();
            input1.Focus();
        }
        private void addReadBox (int QT, string orderNumber, string ID, string trackingNumber)
        {
            string[] data = { QT.ToString(), orderNumber.ToString(), ID.ToString(), trackingNumber.ToString() };
            readBox.Rows.Add(data);
        }

        private void readBox_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(readBox.Rows[0].Cells[0].Value.ToString());
            input1.Text = readBox.Rows[readBox.SelectedRows.ToString()]
            //Console.WriteLine(readBox.CurrentCell.RowIndex.ToString);
        }

      
    }
}
