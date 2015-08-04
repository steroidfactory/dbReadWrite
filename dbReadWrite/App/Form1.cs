using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addQ();
            input1.Focus();
            //createDB();
        }

        //public Dictionary<int, List<string>> portsText = new Dictionary<int, List<string>>();



        //
        //  Quantity Select
        //
        private void listQT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input1.Focus();
            }
        }

        //
        //  Quantity Intialization
        //
        private void addQ()
        {
            for (int i = 1; i < 100; i++)
            {
                Task taskA = Task.Factory.StartNew(() => listQT.Items.Add(i));
                taskA.Wait();
            }
            listQT.SelectedIndex = 0;
        }

        //
        //  Input 1
        //
        private void input1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
                addReadBox(listQT.SelectedIndex + 1, input1.Text, input2.Text, input3.Text);
                resetInput();
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
        private void addReadBox(int QT, string orderNumber, string ID, string trackingNumber)
        {
            if (ID == "1333")
            {
                ID = "Sashko";
            }
            string[] data = { QT.ToString(), orderNumber.ToString(), ID.ToString(), trackingNumber.ToString() };
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
        //  Connect to Database
        //
        private void createDB()
        {
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE MyDatabase ON PRIMARY " +
        "(NAME = MyDatabase_Data, " +
        "FILENAME = 'C:\\MyDatabaseData.mdf', " +
        "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
        "LOG ON (NAME = MyDatabase_Log, " +
        "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
        "SIZE = 1MB, " +
        "MAXSIZE = 5MB, " +
        "FILEGROWTH = 10%)";


            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }


        //
        //  Delete Button
        //
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
