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
        private MySqlConnection connectionInventory;
        private MySqlConnection connectionEmployees;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string tableOrders;
        private string tableInventory;
        private string tableEmployees;


        public void initDB()
        {
            setDB();
        }

        //
        //  Connect to Database
        //
        private void setDB()
        {
            server = "10.11.3.3";
            database = "steroidfactory";
            uid = "steroid";
            password = "andriyk";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Convert Zero Datetime=True;";
            connection = new MySqlConnection(connectionString);
            connectionInventory = new MySqlConnection(connectionString);
            connectionEmployees = new MySqlConnection(connectionString);
            tableOrders = "packing_orders";
            tableInventory = "packing_inventory";
            tableEmployees = "employees";
        }



        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    //Console.WriteLine("Connect is to open");
                    connection.Open();
                    return true;
                }
                else if (connection.State == System.Data.ConnectionState.Open)
                {
                    //Console.WriteLine("Connection is already open");
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
                //Console.WriteLine("Error in open connection is : " + ex);
                return false;

            }
        }


        //Close connection
        private bool CloseConnection()
        {
            //Console.WriteLine("Closing connectiion");
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine("Error in close connection: " + ex);
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool OpenConnectionInventory()
        {
            try
            {
                if (connectionInventory.State == System.Data.ConnectionState.Closed)
                {
                  //  Console.WriteLine("Connect is to open");
                    connectionInventory.Open();
                    return true;
                }
                else if (connectionInventory.State == System.Data.ConnectionState.Open)
                {
                   // Console.WriteLine("Connection is already open");
                    return true;
                }
                if (connectionInventory.State == System.Data.ConnectionState.Closed)
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
                //Console.WriteLine("Error in open connection is : " + ex);
                return false;

            }
        }

        private bool OpenConnectionEmployees()
        {
            try
            {
                if (connectionEmployees.State == System.Data.ConnectionState.Closed)
                {
                    connectionEmployees.Open();
                    return true;
                }
                else if (connectionEmployees.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                if (connectionEmployees.State == System.Data.ConnectionState.Closed)
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
                //Console.WriteLine("Error in open connection is : " + ex);
                return false;

            }
        }

        //Close connection
        private bool CloseConnectionInventory()
        {
            //Console.WriteLine("Closing connectiion");
            try
            {
                connectionInventory.Close();
                return true;
            }
            catch (MySqlException ex)
            {
               // Console.WriteLine("Error in close connection: " + ex);
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
                    " VALUES(" + OrderNumber + "," + "'" + Dimensions + "'" + "," + "'" + QT + "'" + "," + "'" + Employee + "'" + "," + "now());";
            }
            else
            {
                //"INSERT INTO orders (Dimensions, QT, OrderNumber, ID, TrackingNumber, TimeIn) VALUES('QT','OrderNumber','ID,'TrackingNumber',now());
                query = "INSERT INTO " + tableOrders + " (OrderNumber, Dimensions, QT, Employee, TrackingNumber, TimeIn)" +
            " VALUES(" + OrderNumber + ',' + "'" + Dimensions + "'" + "," + "'" + QT + "'" + "," + "'" + Employee + "'" + "," + "'" + TrackingNumber + "'" + "," + "now());";
            }
            //open connection
            if (OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    CloseConnection();
                }
                catch (MySqlException s)
                {
                    Console.WriteLine("Insert" + s);
                }

            }
            Console.WriteLine("inserted");

        }

        public bool checkIsDuplicateOrder(string input)
        {
            string query = ("SELECT Count(*) FROM " + tableOrders + " WHERE OrderNumber = " + input + ";");
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
            list[6] = new List<string>();
            //}

            //Open connection
            if (OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                // MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["Dimensions"] + "");
                        list[1].Add(dataReader["QT"] + "");
                        list[2].Add(dataReader["OrderNumber"] + "");
                        list[3].Add(dataReader["Employee"] + "");
                        list[4].Add(dataReader["TrackingNumber"] + "");
                        list[5].Add(dataReader["TimeIn"] + "");
                        list[6].Add(dataReader["TimeOut"] + "");

                        //Console.WriteLine(dataReader["Index_ID"].ToString() + dataReader["QT"] + dataReader["OrderNumber"]
                        //+ dataReader["ID"] + dataReader["TrackingNumber"] + dataReader["TimeIn"] );
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();
                }
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
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

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
            string query = ("SELECT * FROM " + tableOrders + " WHERE OrderNumber = " + order + ";");
            string status = null;
            bool timeIn = false;
            bool timeOut = false;
            DateTime calcIn = DateTime.MinValue;
            DateTime calcOut = DateTime.MinValue;

            //Open Connection
            if (OpenConnection() == true)
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
                        if (dataReader["TimeOut"].ToString() != "")
                        {
                            calcOut = DateTime.Parse(dataReader["TimeOut"].ToString());
                        }

                    }
                    if ((dataReader["TimeOut"].ToString()) != "")
                    {
                        timeOut = true;
                    }

                }
                if (timeIn == true && timeOut == false)
                {
                    status = calcTimeOpen(calcIn);
                }
                if (timeIn == false && timeOut == false)
                {
                    status = "Order does not exist";
                }
                if (timeIn == true && timeOut == true)
                {
                    status = calcTimeClosed(calcIn, calcOut);
                }

                //close Connection
                CloseConnection();

                return status;
            }
            else
            {
                return "Connection closed";
            }
        }

        public string calcTimeOpen(DateTime started)
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
            return ("Order is open for: " + differenceInDays + " Days, " + differenceInHours + " hours, and " + differenceInMinutes + " minutes");
        }

        public string calcTimeClosed(DateTime started, DateTime ended)
        {
            // Difference in days, hours, and minutes.
            TimeSpan ts = ended - started;
            // Difference in days.
            int differenceInDays = ts.Days;
            // Difference in days.
            int differenceInHours = ts.Hours;
            // Difference in Minutes.
            int differenceInMinutes = ts.Minutes;
            return ("Order was open for: " + differenceInDays + " Days, " + differenceInHours + " hours, and " + differenceInMinutes + " minutes");
        }

        public int orderToIndex(string orderNumber)
        {
            string query = "SELECT Count* FROM " + tableOrders + "WHERE OrderNumber = " + orderNumber + ";";

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Read the data and store them in the list
                using (MySqlDataReader dataReader1 = cmd.ExecuteReader())
                {
                    while (dataReader1.Read())
                    {

                    }


                    //close Connection
                    CloseConnection();
                    return 1;

                }
            }
            else
            {
                return 2;
            }
        }

        //Select statement
        public List<string>[] SelectByOrder(int orderNumber)
        {
            string query = "SELECT * FROM " + tableOrders + " WHERE OrderNumber = " + orderNumber.ToString() + ";";
            //string query = "SELECT * FROM orders WHERE OrderNumber = 99;";
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
            list[6] = new List<string>();
            //}

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                // MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["Dimensions"] + "");
                        list[1].Add(dataReader["QT"] + "");
                        list[2].Add(dataReader["OrderNumber"] + "");
                        list[3].Add(dataReader["Employee"] + "");
                        list[4].Add(dataReader["TrackingNumber"] + "");
                        list[5].Add(dataReader["TimeIn"] + "");
                        list[6].Add(dataReader["TimeOut"] + "");

                        //Console.WriteLine(dataReader["Index_ID"].ToString() + dataReader["QT"] + dataReader["OrderNumber"]
                        //+ dataReader["ID"] + dataReader["TrackingNumber"] + dataReader["TimeIn"] );
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();
                }
                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement
        public List<string>[] SelectInventory()
        {
            string query = "SELECT * FROM " + tableInventory + ";";
            //int countNum = Count();
            //Create a list to store the result
            List<string>[] list = new List<string>[2];

            list[0] = new List<string>();
            list[1] = new List<string>();
            //}
            //Open connection
            if (OpenConnectionInventory() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connectionInventory);
                //Create a data reader and Execute the command
                // MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Console.WriteLine("Datareader Succes");
                    while (dataReader.Read())
                    {
                        // Console.WriteLine((dataReader["Dimensions"] + "").ToString());
                        list[0].Add(dataReader["Dimensions"] + "");
                        list[1].Add(dataReader["QT"] + "");
                        //Console.WriteLine(dataReader["Index_ID"].ToString() + dataReader["QT"] + dataReader["OrderNumber"]
                        //+ dataReader["ID"] + dataReader["TrackingNumber"] + dataReader["TimeIn"] );
                       // Console.WriteLine(list[0][0]);
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();
                }
                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] SelectInventoryQT(string input)
        {
            string query = "SELECT * FROM " + tableInventory + " WHERE Dimensions = '" + input + "';";
            //int countNum = Count();
            //Create a list to store the result
            List<string>[] list = new List<string>[2];

            list[0] = new List<string>();
            list[1] = new List<string>();
            //}
            //Open connection
            if (OpenConnectionInventory() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connectionInventory);
                //Create a data reader and Execute the command
                // MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Console.WriteLine("Datareader Succes");
                    while (dataReader.Read())
                    {
                        // Console.WriteLine((dataReader["Dimensions"] + "").ToString());
                        list[0].Add(dataReader["Dimensions"] + "");
                        list[1].Add(dataReader["QT"] + "");
                        //Console.WriteLine(dataReader["Index_ID"].ToString() + dataReader["QT"] + dataReader["OrderNumber"]
                        //+ dataReader["ID"] + dataReader["TrackingNumber"] + dataReader["TimeIn"] );
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();
                }
                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public void closeOrder(string order)
        {
            string query = "UPDATE " + tableOrders + " SET TimeOut = now() WHERE OrderNumber = " + order + ";";

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                cmd.ExecuteScalar();

                //close Connection
                CloseConnection();
            }
            else
            {
                
            }
        }

        public void removeFromInventory(string dimensions, int qt)
        {
            string query = ("UPDATE " + tableInventory + " SET QT = QT - " + qt + " WHERE Dimensions = " + "'" + dimensions + "'" + ";");
            //string query = "UPDATE packing.inventory SET QT = QT - 1 WHERE Dimensions = '1x1x1';";
            try
            {

                //Open Connection
                if (OpenConnectionInventory() == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connectionInventory);

                    //ExecuteScalar will return one value
                    cmd.ExecuteScalar();

                    //close Connection
                    CloseConnectionInventory();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        //Count statement
        public int CountInventory()
        {
            string query = "SELECT Count(*) FROM " + tableInventory + ";";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnectionInventory();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public int CountInventoryDM(string Dimensions)
        {
            string query = "SELECT Count(*) FROM " + tableInventory + " WHERE Dimensions = " + "'" + Dimensions + "'" + ";";
            int Count = 0;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnectionInventory();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public void addInventory(string dimensions, int QT)
        {
            try
            {
                ;
            }
            catch
            {
                ;
            }
        }

        public List<string>[] checkEmployee(string ID)
        {
            string query = "SELECT * FROM " + tableEmployees + " WHERE ID = '" + ID + "';";
            //int countNum = Count();
            //Create a list to store the result
            List<string>[] list = new List<string>[6];

            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            //}
            //Open connection
            if (OpenConnectionEmployees() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connectionEmployees);
                //Create a data reader and Execute the command
                // MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["FirstName"] + "");
                        list[2].Add(dataReader["LastName"] + "");
                        list[3].Add(dataReader["Initial"] + "");
                        list[4].Add(dataReader["Department"] + "");
                        list[5].Add(dataReader["Access"] + "");
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    CloseConnection();
                }
                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        

        public void inventoryAdd(string Dimensions, string QT)
        {
            try
            {
                string query = "";
                if (CountInventoryDM(Dimensions) == 1)
                {
                    query = "UPDATE " + tableInventory + " SET QT = QT + " + QT + " WHERE Dimensions = " + "'" + Dimensions + "'" + ";";
                    //open connection
                    if (OpenConnectionInventory() == true)
                    {
                        try
                        {
                            //create command and assign the query and connection from the constructor
                            MySqlCommand cmd = new MySqlCommand(query, connectionInventory);
                            //Execute command
                            cmd.ExecuteNonQuery();

                            //close connection
                            CloseConnection();
                        }
                        catch (MySqlException s)
                        {

                        }
                    }
                }
                else if (CountInventoryDM(Dimensions) == 0)
                {
                    //Console.WriteLine("ADDING NEW LINE");
                    query = "INSERT INTO " + tableInventory + " (Dimensions, QT)" + " VALUES(" + "'" + Dimensions + "'" + ", " + QT +  ");";
                    //Console.WriteLine(query);
                    //open connection
                    if (OpenConnectionInventory() == true)
                    {
                        try
                        {
                            //create command and assign the query and connection from the constructor
                            MySqlCommand cmd = new MySqlCommand(query, connectionInventory);
                            //Execute command
                            cmd.ExecuteNonQuery();

                            //close connection
                            CloseConnection();
                        }
                        catch (MySqlException s)
                        {

                        }
                    }
                }
            }
            catch
            {
                
            }
        }













    }
}
