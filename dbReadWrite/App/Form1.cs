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
            PackingDB.initDB();
            setupWindow();
            addTable();
            
        }

        //public Dictionary<int, List<string>> portsText = new Dictionary<int, List<string>>();



        //
        //  Quantity Select
        //
        private void listQT_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputOrderNumber.Focus();
        }
        //
        //  Quantity Intialization
        //
        private void setupWindow()
        {
            //for (int i = 1; i < 100; i++)
          //  {
           //     Task taskA = Task.Factory.StartNew(() => listQT.Items.Add(i));
         //       taskA.Wait();
        //    }
            //listQT.SelectedIndex = 0;
            updateDMList();
            readBox.ClearSelection();
            inputOrderNumber.Focus();
        }

        private void updateDMList()
        {
            try
            {
                InputEnable();
                if (listDM.Items.Count > 0)
                {
                    listDM.Items.Clear();
                }

                for (int i = 0; i < PackingDB.CountInventory(); i++)
                {
                    listDM.Items.Add(PackingDB.SelectInventory()[0][i].ToString());
                }
                listDM.SelectedIndex = 0;
            }
            catch
            {
                InputDisable(); 
                MessageBox.Show("Inventory is empty");
            }


            }

          

        //
        //  Input 1
        //
        private void input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("enter pressed");
                inputEmployee.Focus();
                
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
                inputTracking.Focus();
            }
        }

        //
        //  Input 3
        //
        private void input3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (PackingDB.checkIsDuplicateOrder(inputOrderNumber.Text.ToString()) == false)
                    {
                        PackingDB.Insert(listDM.Text, listQT.SelectedIndex + 1, inputOrderNumber.Text, inputEmployee.Text, inputTracking.Text);
                        PackingDB.removeFromInventory(listDM.Text, Int32.Parse(listQT.Text));
                        resetInput();
                        updateDMList();
                        updateQTList();
                        updateTable();
                    }
                    else if (inputOrderNumber.Text.ToString() == "")
                    {
                        MessageBox.Show("Please Enter a Valid Order Number.");
                        resetInput();
                    }
                    else if (PackingDB.checkIsDuplicateOrder(inputOrderNumber.Text.ToString()) == true)
                    {
                        MessageBox.Show("The Entered Order Number Already Exists.");
                        resetInput();
                    }
                }
                catch
                {
                    Console.WriteLine("Error on enter");
                }
                }

        }

        //
        //  Resets Input
        //
        private void resetInput()
        {
            listQT.SelectedIndex = 0;
            inputOrderNumber.Clear();
            inputEmployee.Clear();
            inputTracking.Clear();
            inputOrderNumber.Focus();
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

        private void addDimensions(string Dimensions, string QT)
        {

            string[] data = { Dimensions.ToString(), QT.ToString() };
             
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

        /// <summary>
        /// PackingDB.Select is causing the performance issue
        /// </summary>
        private void addTable()
        {
            int countNum = PackingDB.Count();
            for (int i = 0; i < countNum; i++)
            {
                addReadBox(PackingDB.Select()[0][i], PackingDB.Select()[1][i], PackingDB.Select()[2][i],
                    PackingDB.Select()[3][i], PackingDB.Select()[4][i], PackingDB.Select()[5][i]);
            }
            readBox.Sort(readTimeIn, ListSortDirection.Descending);
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
            if (System.Text.RegularExpressions.Regex.IsMatch(inputOrderNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Congradulations! You didn't use a scanner and now you broke it.");
                inputOrderNumber.Text.Remove(inputOrderNumber.Text.Length - 1);
                resetInput();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkOrder();
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
            int orderNumber = Int32.Parse(inputOrderStatus.Text);
            MessageBox.Show(
                "Order Number: " +  orderNumber
                + Environment.NewLine +
                "Quantity: " + PackingDB.SelectByOrder(orderNumber)[1][0]
                + Environment.NewLine +
                "Dimentions: " + PackingDB.SelectByOrder(orderNumber)[0][0]
                + Environment.NewLine +
                PackingDB.statusOrder(inputOrderStatus.Text.ToString())
                + Environment.NewLine +
                "Employee: " + PackingDB.SelectByOrder(orderNumber)[3][0]
                + Environment.NewLine +
                "Time In: " + PackingDB.SelectByOrder(orderNumber)[5][0]
                + Environment.NewLine +
                "Time Out: " + PackingDB.SelectByOrder(orderNumber)[6][0]
                + Environment.NewLine +
                "Tracking Number: " + PackingDB.SelectByOrder(orderNumber)[4][0]
                );
            inputOrderStatus.Clear();
        }

        private void displayInventory()
        {

        }
        
        private void InputDisable()
        {
            listDM.Enabled = false;
            listQT.Enabled = false;
            inputOrderNumber.Enabled = false;
            inputEmployee.Enabled = false;
            inputTracking.Enabled = false;
        }

        private void InputEnable()
        {
            listDM.Enabled = true;
            listQT.Enabled = true;
            inputOrderNumber.Enabled = true;
            inputEmployee.Enabled = true;
            inputTracking.Enabled = true;
        }

        private void inventoryCheck()
        {
            string[] data = new string[PackingDB.CountInventory()];
            for (int i = 0; i < PackingDB.CountInventory(); i++)
            {
                data[i] = ( PackingDB.SelectInventory()[0][i].ToString() + "  :  " + PackingDB.SelectInventory()[1][i].ToString());
            }
            string list = string.Join(Environment.NewLine, data);
            MessageBox.Show(list);
        }

        private void btnInventoryCheck_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Inventory check");
            inventoryCheck();
        }

        private void btnInventoryAdd_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listDM_SelectedValueChanged(object sender, EventArgs e)
        {
            updateQTList();
        }

        private void updateQTList()
        {
            listQT.Items.Clear();
            if (listDM.Text != "")
            {
                for (int i = 1; i <= Int32.Parse(PackingDB.SelectInventoryQT(listDM.Text)[1][0]); i++)
                {
                    listQT.Items.Add(i);
                }
                listQT.SelectedIndex = 0;
            }
        }

    }
}
