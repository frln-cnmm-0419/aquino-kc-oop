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
        public DataSet dtst = new DataSet();
        public void dispRec(String strings)
        {
            MySqlConnection myconnection = new MySqlConnection(Global.stringCon); // creatin an instance of connection
            MySqlCommand mycommand = myconnection.CreateCommand(); //creating my command variable
            MySqlDataAdapter myadapter = new MySqlDataAdapter(mycommand); //passing the mycomman to my adapter instance
            mycommand.CommandText = strings; // passing the strings as command
            MySqlCommandBuilder mybuilder = new MySqlCommandBuilder(myadapter); //passing the adapter to the command builder instance

            myconnection.Open();
            myadapter.Fill(dtst);
            myconnection.Close();
        }


        public void maintRec(String str)
        {
            MySqlConnection myconnection = new MySqlConnection(Global.stringCon);
            MySqlCommand mycomm = myconnection.CreateCommand();
            mycomm.CommandText = str;

            myconnection.Open();
            mycomm.ExecuteNonQuery();
            myconnection.Close();

        }
    }
}
