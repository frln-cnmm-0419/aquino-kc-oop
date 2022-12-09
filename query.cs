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
            MySqlConnection myconnection = new MySqlConnection(Global.stringCon);
            MySqlCommand mycommand = myconnection.CreateCommand();
            MySqlDataAdapter myadapter = new MySqlDataAdapter(mycommand);
            mycommand.CommandText = strings;
            MySqlCommandBuilder mybuilder = new MySqlCommandBuilder(myadapter);

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
