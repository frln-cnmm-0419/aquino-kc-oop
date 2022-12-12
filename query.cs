using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace records_database
{
    class query
    {
        public DataSet dtst = new DataSet(); // creating the dataset instance
        public void dispRec(String strings)
        {
            MySqlConnection myconnection = new MySqlConnection(Global.stringCon); // creatin an instance of connection
            MySqlCommand mycommand = myconnection.CreateCommand(); //creating my command variable
            MySqlDataAdapter myadapter = new MySqlDataAdapter(mycommand); //passing the mycomman to my adapter instance
            mycommand.CommandText = strings; // passing the strings as command
            MySqlCommandBuilder mybuilder = new MySqlCommandBuilder(myadapter); //passing the adapter to the command builder instance

            myconnection.Open(); // opening the connection
            myadapter.Fill(dtst); // filling the dataset
            myconnection.Close(); // closing the connection
        }


        public void maintRec(String str) //maintain record function
        {
            MySqlConnection myconnection = new MySqlConnection(Global.stringCon); // creating the connection instance
            MySqlCommand mycomm = myconnection.CreateCommand(); // creating the command
            mycomm.CommandText = str; // creating the commannd string

            myconnection.Open(); // opening the connection
            mycomm.ExecuteNonQuery();
            myconnection.Close(); // closing the connection

        }
    }
}
