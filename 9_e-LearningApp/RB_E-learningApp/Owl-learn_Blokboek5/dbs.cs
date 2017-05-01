using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace Owl_learn_Blokboek5
{
    class dbs
    {
        class DBS
        {
            #region fields
            private string conn;
            private MySqlConnection connect;
            #endregion

            //Connectie met de database
            private void db_connection()
            {
                try
                {
                    conn = "Server=localhost;Database=owl-learn;Uid=root;Pwd=;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                }

                catch (MySqlException) //Foutafhandeling
                {
                    // MessageBox.Show("Kan geen verbinding maken met de database", "Oh nee!");
                }
            }

            //Algemene functie voor het opzoeken van verschillende gegevens in de database
            public DataTable Search(string sTable, string sParameterA, string sParameterB)
            {
                DataTable retValue = new DataTable();
                db_connection();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + sTable + " WHERE " + sParameterA + "='" + sParameterB + "'"))
                {
                    cmd.Connection = connect;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    retValue.Load(reader);
                    connect.Close();
                }

                //Return result
                return retValue;
            }
        }
    }
}
