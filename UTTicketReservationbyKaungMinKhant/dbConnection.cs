using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UTTicketReservationbyKaungMinKhant
{
    class dbConnection
    {
       
       
       public void selection(String entity_name, String database_name)
        {
            
            try
            {
                String connString = "Data Source=127.0.0.1;" + "Initial Catalog=movie_ticket_reservation_system;" + "User id=root;" + "Password='';";
                MySqlConnection connc = new MySqlConnection(connString);
                String CommandText = "SELECT " + entity_name + " FROM " + database_name;

                MySqlCommand command = new MySqlCommand(CommandText, connc);
                connc.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader["test_name"].ToString());
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertion(String database_name, String data_one, String data_two)
        {
            try
            {
                String connString = "Data Source=127.0.0.1;" + "Initial Catalog=movie_ticket_reservation_system;" + "User id=root;" + "Password='';";

                String commandText = "INSERT INTO " + database_name + " VALUES('', " + "'" + data_one + "'" + ", " + "'" + data_two + "'" + ")";
               
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = new MySqlCommand(commandText, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Data Saved");
                while (reader.Read())
                {

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public dbConnection()
        {
           
          
        }
    }
}
