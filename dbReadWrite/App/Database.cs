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
            server = "localhost";
            database = "test";
            uid = "root";
            password = "test";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            Console.WriteLine("mySQL Database initiated");
        }



        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
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
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Insert statement
        public void Insert(int QT, string OrderNumber, string ID, string TrackingNumber)
        {
            //"INSERT INTO packing (QT, OrderNumber, ID, TrackingNumber, TimeIn) VALUES('QT','OrderNumber','ID,'TrackingNumber',now());
            string query = "INSERT INTO packing (QT, OrderNumber, ID, TrackingNumber, TimeIn)" +
                " VALUES(" + "'" + QT + "'" + "," + "'" + OrderNumber + "'" + "," + "'" + ID  + "'" + "," + "'" + TrackingNumber + "'" + "," + "now());";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM packing";
            //int countNum = Count();
            //Create a list to store the result
            List<string>[] list = new List<string>[6];
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
                    list[0].Add(dataReader["Index_ID"] + "");
                    list[1].Add(dataReader["QT"] + "");
                    list[2].Add(dataReader["OrderNumber"] + "");
                    list[3].Add(dataReader["ID"] + "");
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
            string query = "SELECT Count(*) FROM packing";
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
            string query = ("SELECT * FROM packing WHERE OrderNumber = " + order +  ";");
            string status = null;
            string timeIn = null;
            string timeOut = null;


            //Open Connection
            if (this.OpenConnection() == true)
            {
                
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    timeIn = (dataReader["TimeIn"] + "");
                    timeOut = dataReader["TimeOut"] + "";
                }
                
                if (timeIn != null && timeOut == null)
                {
                    status = "Order Open";
                }
                if(timeIn == null && timeOut == null)
                {
                    status = "Order does not exist";
                }
                if (timeIn != null && timeOut != null)
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

    }
}
