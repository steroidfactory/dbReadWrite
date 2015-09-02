using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App
{
    class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string tableOrders;
        private string tableInventory;


        public void initDB()
        {
            setDB();
            //OpenConnection();
            Console.WriteLine("DB Initiated");
        }

        //
        //  Connect to Database
        //
        private void setDB()
        {
            server = "10.11.3.3";
            database = "packing";
            uid = "steroid";
            password = "andriyk";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Convert Zero Datetime=True;";
            connection = new MySqlConnection(connectionString);
            tableOrders = "orders";
            tableInventory = "inventory";
        }



        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    
                    Console.WriteLine("Connect is to open");
                    connection.Open();
                    return true;
                }
                else if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection is already open");
                    return true;
                }
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    return false;
                }
                    return true;
                
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine("Error in open connection is : " + ex);
                return false;
                
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error in close connection: " + ex);
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Insert statement
        public void Insert(string Dimensions, int QT, string OrderNumber, string Employee, string TrackingNumber)
        {

            string query = "";
                if (TrackingNumber == "")
                {
                    //"INSERT INTO orders (Dimensions, QT, OrderNumber, ID, TrackingNumber, TimeIn) VALUES('QT','OrderNumber','ID,'TrackingNumber',now());
                    query = "INSERT INTO " + tableOrders + " (OrderNumber, Dimensions, QT, Employee, TimeIn)" +
                        " VALUES(" + OrderNumber + "," + "'" +  Dimensions + "'" + "," + "'" + QT + "'" + "," + "'" + Employee + "'" + "," + "now());";
                }
                else
                {
                //"INSERT INTO orders (Dimensions, QT, OrderNumber, ID, TrackingNumber, TimeIn) VALUES('QT','OrderNumber','ID,'TrackingNumber',now());
                    query = "INSERT INTO " + tableOrders + " (OrderNumber, Dimensions, QT, Employee, TrackingNumber, TimeIn)" +
                " VALUES(" + OrderNumber + ',' + "'" + Dimensions + "'" + "," + "'" + QT + "'" + "," + "'" + Employee + "'" + "," + "'" + TrackingNumber + "'" + "," + "now());";
                }
            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                catch (MySqlException s)
                {
                    Console.WriteLine("Insert" + s);
                }

            }
            
        }

        public bool checkIsDuplicateOrder(string input)
        {
            string query = ("SELECT Count(*) FROM packing.orders WHERE OrderNumber = " + input + ";");
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd1 = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command

                    //Read the data and store them in the list
                    using (MySqlDataReader dataReader1 = cmd1.ExecuteReader())
                    {
                        while (dataReader1.Read())
                        {
                            if (dataReader1 != null)
                            {
                                if (dataReader1.GetInt32(0) == 0)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }

                        }
                        CloseConnection();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Connection error" + ex);
                }
            }
            else
            {
                Console.WriteLine("Connection is still closed");
            }
            return true;

        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM " + tableOrders + ";";
            //int countNum = Count();
            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            //for (int i = 0; i<=4; i++)
            //{
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            //}




            //Open connection
            if (this.OpenConnection() == true)
            {
                
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Dimensions"] + "");
                    list[1].Add(dataReader["QT"] + "");
                    list[2].Add(dataReader["OrderNumber"] + "");
                    list[3].Add(dataReader["Employee"] + "");
                    list[4].Add(dataReader["TrackingNumber"] + "");
                    list[5].Add(dataReader["TimeIn"] + "");
                    //Console.WriteLine(dataReader["Index_ID"].ToString() + dataReader["QT"] + dataReader["OrderNumber"]
                    //+ dataReader["ID"] + dataReader["TrackingNumber"] + dataReader["TimeIn"] );
                }
                
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }


        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM " + tableOrders + ";";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public string statusOrder(string order)
        {
            if ((string.IsNullOrEmpty(order)))
            {
                return "";
            }
            string query = ("SELECT * FROM " + tableOrders + " WHERE OrderNumber = " + order +  ";");
            string status = null;
            bool timeIn = false;
            bool timeOut = false;
            DateTime calcIn = DateTime.MinValue;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                timeIn = false;
                timeOut = false;
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if ((dataReader["TimeIn"].ToString()) != "")
                    {
                        timeIn = true;
                        calcIn = DateTime.Parse(dataReader["TimeIn"].ToString());
                    }
                    if ((dataReader["TimeOut"].ToString()) != "")
                    {
                        timeOut = true;
                    }
                    
                }
                Console.WriteLine(calcIn);
                if (timeIn == true && timeOut == false)
                {
                    status = "Order Open for: " + calcTime(calcIn);
                    
                }
                if(timeIn == false && timeOut == false)
                {
                    status = "Order does not exist";
                }
                if (timeIn == true && timeOut == true)
                {
                    status = "Order Closed";
                }

                //close Connection
                this.CloseConnection();

                return status;
            }
            else
            {
                return "Connection closed";
            }
        }

        public string calcTime(DateTime started)
        {
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - started;
            // Difference in days.
            int differenceInDays = ts.Days;
            // Difference in days.
            int differenceInHours = ts.Hours;
            // Difference in Minutes.
            int differenceInMinutes = ts.Minutes;
            return ("Open For " + differenceInDays + " Days, " + differenceInHours + " hours, and " + differenceInMinutes + " minutes");
        }

    }
}
