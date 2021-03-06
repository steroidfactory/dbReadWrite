﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            panelMain.Visible = true;
            panelReports.Visible = false;
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
            inventoryShow("");
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
                listDM.Enabled = true; 
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
                        if (PackingDB.checkEmployee(inputEmployee.Text)[3][0] != "" && Authentication(inputEmployee.Text) >= 1)
                        {
                            PackingDB.Insert(listDM.Text, listQT.SelectedIndex + 1, inputOrderNumber.Text, inputEmployee.Text, inputTracking.Text);
                            PackingDB.removeFromInventory(listDM.Text, Int32.Parse(listQT.Text));
                        }
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

                    //Untested
                    else if (inputEmployee.Text == "" || inputEmployee.Text == null)
                    {
                        MessageBox.Show("Please enter a valid Employee ID");
                        resetInput();
                    }
                }
                catch
                {
                    MessageBox.Show("Unauthorized User");
                    resetInput();
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
            ID = PackingDB.checkEmployee(ID)[3][0];
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

        private void reportAddReadBox(string Dimensions, string QT, string orderNumber, string ID, string trackingNumber, string timeIn, string timeOut)
        {
            ID = PackingDB.checkEmployee(ID)[3][0];
            string timeOpened = "";
            if (timeOut == "")
            {
                timeOpened = PackingDB.calcTimeOpen(DateTime.Parse(timeIn));
            }
            else if (timeOut != "")
            {
                timeOpened = PackingDB.calcTimeClosed(DateTime.Parse(timeIn), DateTime.Parse(timeOut));
            }
            string[] data = { orderNumber, ID, trackingNumber, Dimensions, QT, timeIn, timeOut, timeOpened };
            reportReadBox.Rows.Add(data);
        }

        /// <summary>
        /// PackingDB.Select is causing the performance issue
        /// </summary>
        private void addTable()
        {
            int countNum = PackingDB.Count();
            for (int i = 0; i < countNum; i++)
            {
               if (PackingDB.Select()[6][i] == "")
               {
                    addReadBox(PackingDB.Select()[0][i], PackingDB.Select()[1][i], PackingDB.Select()[2][i],
                     PackingDB.Select()[3][i], PackingDB.Select()[4][i], PackingDB.Select()[5][i]);
               }

                
            }
            readBox.Sort(readTimeIn, ListSortDirection.Descending);
        }

        private void reportAddTable()
        {
            int countNum = PackingDB.Count();
            for (int i = 0; i < countNum; i++)
            {
                    reportAddReadBox(PackingDB.Select()[0][i], PackingDB.Select()[1][i], PackingDB.Select()[2][i],
                     PackingDB.Select()[3][i], PackingDB.Select()[4][i], PackingDB.Select()[5][i], PackingDB.Select()[6][i]);
            }
            reportReadBox.Sort(TimeIn, ListSortDirection.Descending);
        }

        private void updateTable()
        {
            readBox.Rows.Clear();
            addTable();
            readBox.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputOrderNumber);
        }
        private void inputNumbersOnly(TextBox inputTextbox)
        {
             if (System.Text.RegularExpressions.Regex.IsMatch(inputTextbox.Text, "[^0-9]"))
            {
                inputTextbox.Clear();
                MessageBox.Show("Please use your scanner or input numbers only");
                //inputOrderNumber.Text.Remove(inputOrderNumber.Text.Length - 1);
                
             //resetInput();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (inputOrderStatus.Text != "")
            {
                checkOrder(inputOrderStatus.Text);
            }
           
        }

        private void inputOrderStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (inputOrderStatus.Text != "")
                {
                    checkOrder(inputOrderStatus.Text);
                }
                    
            }
        }

        private void checkOrder(string order)
        {
            int orderNumber = Int32.Parse(order);
            try
            {
                if (PackingDB.checkIsDuplicateOrder(inputOrderStatus.Text) == true)
                {
                    string employee = PackingDB.SelectByOrder(orderNumber)[3][0];
                    MessageBox.Show(
                        "Order Number: " + orderNumber
                        + Environment.NewLine +
                        "Quantity: " + PackingDB.SelectByOrder(orderNumber)[1][0]
                        + Environment.NewLine +
                        "Dimentions: " + PackingDB.SelectByOrder(orderNumber)[0][0]
                        + Environment.NewLine +
                        PackingDB.statusOrder(order)
                        + Environment.NewLine +
                        "Employee: " + PackingDB.checkEmployee(employee)[3][0]
                        + Environment.NewLine +
                        "Time In: " + PackingDB.SelectByOrder(orderNumber)[5][0]
                        + Environment.NewLine +
                        "Time Out: " + PackingDB.SelectByOrder(orderNumber)[6][0]
                        + Environment.NewLine +
                        "Tracking Number: " + PackingDB.SelectByOrder(orderNumber)[4][0]
                        );
                }
                else if(PackingDB.checkIsDuplicateOrder(inputOrderStatus.Text) == false)
                {
                    MessageBox.Show("Order does not exist");
                }
                
            }
            catch
            {
                MessageBox.Show("Order Does Not Exist");
            }
            
            inputOrderStatus.Clear();
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
            inventoryShow("login");
            inputLogin.Focus();
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
                if (PackingDB.SelectInventoryQT(listDM.Text)[1][0] != "0")
                {
                    InputEnable();
                    for (int i = 1; i <= Int32.Parse(PackingDB.SelectInventoryQT(listDM.Text)[1][0]); i++)
                    {
                        listQT.Items.Add(i);
                    }
                    listQT.SelectedIndex = 0;
                }
                else if (PackingDB.SelectInventoryQT(listDM.Text)[1][0] == "0")
                    {
                    InputDisable();
                    listQT.Text = "0";
                    listDM.Enabled = true;
                    }
            }
        }

        private int Authentication(string ID)
        {
            try
            {
                if (PackingDB.checkEmployee(ID)[3][0] != "")
                {
                    return Int32.Parse(PackingDB.checkEmployee(ID)[5][0]);
                }
                return 0;
            }
            catch
            {
                MessageBox.Show("Unauthorized User");
                inputLogin.Clear();
                return 0;
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            inventoryAddLogin();
        }

        private void inventoryShow(string window)
        {
            //Login panel
            if (window == "login")
            {
                panelInventory.Visible = false;
                panelLogin.Visible = true;
                panelInventoryAdd.Visible = false;
            }

            //Add to inventory panel
            else if (window == "inventoryAdd")
            {
                panelInventory.Visible = false;
                panelLogin.Visible = false;
                panelInventoryAdd.Visible = true;
            }

            //Main inventory panel
            else
            {
                panelInventory.Visible = true;
                panelLogin.Visible = false;
                panelInventoryAdd.Visible = false;
            }

        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            inventoryShow("");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            inventoryShow("");
        }

        private void btnInventoryAddAdd_Click(object sender, EventArgs e)
        {
            addInventory();
        }
        private void addInventory()
        {
            string dim = "";
            if (inputInventoryAddLength.Text != "" && inputInventoryAddWidth.Text != "" && inputInventoryAddHeight.Text != "" && inputInventoryAddQT.Text != "")
            {
                dim = (inputInventoryAddLength.Text + "x" + inputInventoryAddWidth.Text + "x" + inputInventoryAddHeight.Text);
                PackingDB.inventoryAdd(dim, inputInventoryAddQT.Text);
                inputInventoryAddLength.Clear();
                inputInventoryAddWidth.Clear();
                inputInventoryAddHeight.Clear();
                inputInventoryAddQT.Clear();
                updateDMList();
                updateQTList();
                inputInventoryAddLength.Focus();
            }
        }

        private void readBox_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int orderNumber = Int32.Parse(readBox.Rows[readBox.CurrentCell.RowIndex].Cells[2].Value.ToString());
            
            //
            using (authenticationID checkID = new authenticationID())
            {
                var result = checkID.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string ID = checkID.ID;
                    if (PackingDB.SelectByOrder(orderNumber)[3][0] == ID)
                    {
                        PackingDB.closeOrder(orderNumber.ToString());
                        updateTable();
                    }
                    else if (PackingDB.SelectByOrder(orderNumber)[3][0] != ID)
                    {
                        MessageBox.Show("Invalid Employee ID Entered");
                    }
                }
            };
            
        }

        private void readBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                using (authenticationID checkID = new authenticationID())
                {
                    var result = checkID.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string ID = checkID.ID;

                        try
                        {
                            if (Int32.Parse(PackingDB.checkEmployee(ID)[5][0]) >= 4)
                            {
                                panelMain.Visible = false;
                                panelReports.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("You shouldn't be here");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("You shouldn't be here");
                        }
                       

                    }

                };
            }
        }

        private void readBox_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(readBox.Rows[readBox.CurrentCell.RowIndex].Cells[3]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateTracking();
        }

        private void updateTracking()
        {
            if (inputUpdateTrackingOrder.Text != "" && inputUpdateTrackingNew.Text != "")
            {

                if (PackingDB.checkIsDuplicateOrder(inputUpdateTrackingOrder.Text) == true)
                {
                    using (authenticationID checkID = new authenticationID())
                    {
                        var result = checkID.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string ID = checkID.ID;
                            try
                            {


                                if (PackingDB.SelectByOrder(Int32.Parse(inputUpdateTrackingOrder.Text))[3][0] == ID)
                                {
                                    PackingDB.updateTracking(inputUpdateTrackingOrder.Text, inputUpdateTrackingNew.Text);
                                    inputUpdateTrackingNew.Clear();
                                    inputUpdateTrackingOrder.Clear();
                                    updateTable();
                                    inputUpdateTrackingOrder.Focus();
                                }
                                else if (PackingDB.SelectByOrder(Int32.Parse(inputUpdateTrackingOrder.Text))[3][0] != ID)
                                {
                                    inputUpdateTrackingNew.Clear();
                                    inputUpdateTrackingOrder.Clear();
                                    MessageBox.Show("Unauthorized user");
                                }
                            }
                            catch { }
                        }

                    }
                }
                else
                {
                    inputUpdateTrackingNew.Clear();
                    inputUpdateTrackingOrder.Clear();
                    MessageBox.Show("Order number not found");
                }
            }
        }

        private void inputInventoryAddLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputInventoryAddWidth.Focus();
            }
        }

        private void inputInventoryAddWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputInventoryAddHeight.Focus();
            }
        }

        private void inputInventoryAddHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputInventoryAddQT.Focus();
            }
        }

        private void inputInventoryAddQT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addInventory();
            }
        }

        private void inputLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inventoryAddLogin();
            }
        }
        private void inventoryAddLogin()
        {
            if (Authentication(inputLogin.Text) >= 2)
            {
                inputLogin.Clear();
                inventoryShow("inventoryAdd");
                inputInventoryAddLength.Focus();
            }
            else
            {
                inputLogin.Clear();
                MessageBox.Show("Unauthorized User");
            }
        }

        private void inputEmployee_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputEmployee);
        }

        private void inputTracking_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputTracking);
        }

        private void inputOrderStatus_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputOrderStatus);
        }

        private void inputUpdateTrackingOrder_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputUpdateTrackingOrder);
        }

        private void inputUpdateTrackingNew_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputUpdateTrackingNew);
        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputLogin);
        }

        private void inputInventoryAddLength_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputInventoryAddLength);
        }

        private void inputInventoryAddWidth_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputInventoryAddWidth);
        }

        private void inputInventoryAddHeight_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputInventoryAddHeight);
        }

        private void inputInventoryAddQT_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(inputInventoryAddQT);
        }

        private void inputUpdateTrackingOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputUpdateTrackingNew.Focus();
            }
        }

        private void inputUpdateTrackingNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateTracking();
            }
           
        }


        //Converts the DataGridView to DataTable
        public DataTable dgvToTable(DataGridView dgv, String tblName)
        {
            int minRow = 0;
            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }


        private void reportExport(string location)
        {
            try
            {
                DataTable dTable = dgvToTable(reportReadBox, "dataTable");
                ExportToExcel.CreateExcelFile.CreateExcelDocument(dTable, location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            panelReports.Visible = false;
            panelMain.Visible = true;
        }

        private void btnReportCheckOrder_Click(object sender, EventArgs e)
        {
            if (reportInputCheckStatus.Text != "")
            {
                checkOrder(reportInputCheckStatus.Text);
                reportInputCheckStatus.Clear();
            }
        }

        private void reportInputCheckStatus_TextChanged(object sender, EventArgs e)
        {
            inputNumbersOnly(reportInputCheckStatus);
        }

        private void menuFileExport_Click(object sender, EventArgs e)
        {
            exportSave.Filter = "Excel File | *.xlsx";
            DialogResult result = exportSave.ShowDialog();
            // string [] file = Directory.GetFiles(SSelectedPath);
            Console.WriteLine(exportSave.FileName);
            if (exportSave.FileName != "")
            {
                reportExport(exportSave.FileName.ToString());
                exportSave.FileName = "";
                
            }
            else
            {
                MessageBox.Show("Please enter a file name");
            }
            
        }

        private void reportBtnUpdateReadBox_Click(object sender, EventArgs e)
        {
            reportUpdateReadBox();
        }
        
        private void reportUpdateReadBox()
        {
            reportReadBox.Rows.Clear();
            reportAddTable();
        }

        private void menuFilterByDate_Click(object sender, EventArgs e)
        {
            filterDateStart.Visible = true;
            filterDateEnd.Visible = true;
        }

        private void filterDateStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(e.Start);
        }

        //END
    }
}
