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
        Database PackingDB = new Database();
        public Form1()
        {
            InitializeComponent();
            setupWindow();
            PackingDB.initDB();
            addTable();
            
        }

        //public Dictionary<int, List<string>> portsText = new Dictionary<int, List<string>>();



        //
        //  Quantity Select
        //
        private void listQT_SelectedIndexChanged(object sender, EventArgs e)
        {
            input1.Focus();
        }
        //
        //  Quantity Intialization
        //
        private void setupWindow()
        {
            for (int i = 1; i < 100; i++)
            {
                Task taskA = Task.Factory.StartNew(() => listQT.Items.Add(i));
                taskA.Wait();
            }
            listQT.SelectedIndex = 0;
            listDM.SelectedIndex = 0;
            readBox.ClearSelection();
            input1.Focus();
        }

        //
        //  Input 1
        //
        private void input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("enter pressed");
                input2.Focus();
                
            }
        }

        //
        //  Input 2
        //
        private void input2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("enter pressed");
                input3.Focus();
            }
        }

        //
        //  Input 3
        //
        private void input3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("enter pressed");
                PackingDB.Insert(listDM.Text, listQT.SelectedIndex + 1, input1.Text, input2.Text, input3.Text);
                resetInput();
                updateTable();
            }

        }

        //
        //  Resets Input
        //
        private void resetInput()
        {
            listQT.SelectedIndex = 0;
            input1.Clear();
            input2.Clear();
            input3.Clear();
            input1.Focus();
        }

        //
        //  Add Input values to Read Box
        //
        private void addReadBox(string Dimensions, string QT, string orderNumber, string ID, string trackingNumber, string timeIn)
        {
            if (ID == "1333")
            {
                ID = "Sashko";
            }
            string[] data = { Dimensions.ToString(), QT.ToString(), orderNumber.ToString(),
                ID.ToString(), trackingNumber.ToString(), timeIn.ToString() };
            readBox.Rows.Add(data);
        }


        //
        //  Convert ID Number to Initials
        //
        private void checkID(string ID)
        {
            //Convert ID Number to Initials by checking the database
        }

            

        private void readBox_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //readBox.Rows.RemoveAt(readBox.SelectedRows[0].Index);
            //Console.WriteLine(readBox.Rows[0].Cells[0].Value.ToString());
            //input1.Text = readBox.Rows[readBox.SelectedRows.ToString()]
            //Console.WriteLine(readBox.CurrentCell.RowIndex.ToString);
        }

        

        //
        //  Delete Button
        //
        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Console.WriteLine();
            //Insert();
            //CloseConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void addTable()
        {
            int countNum = PackingDB.Count();
            for (int i = 0; i < countNum; i++)
            {
                addReadBox(PackingDB.Select()[0][i], PackingDB.Select()[1][i], PackingDB.Select()[2][i],
                    PackingDB.Select()[3][i], PackingDB.Select()[4][i], PackingDB.Select()[5][i]);
            }
        }

        private void updateTable()
        {
            readBox.Rows.Clear();
            addTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkOrder();
        }
        private void statusOrder()
        {
            lblStatusOrder.Text = PackingDB.statusOrder(inputOrderStatus.Text.ToString());
        }
        private void statusOrderNumber()
        {
            lblOrderStatusNumber.Text = "Order: " + inputOrderStatus.Text;
        }

        private void inputOrderStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkOrder();
            }
        }

        private void checkOrder()
        {
            statusOrder();
            statusOrderNumber();
            inputOrderStatus.Clear();
        }
    }
}
