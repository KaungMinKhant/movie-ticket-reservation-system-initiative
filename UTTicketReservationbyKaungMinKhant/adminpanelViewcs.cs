using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UTTicketReservationbyKaungMinKhant
{
    public partial class adminpanelViewcs : Form
    {
        public adminpanelViewcs()
        {
            InitializeComponent();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String connString ="Data Source=127.0.0.1;" +"Initial Catalog=movie_ticket_reservation_system;" +"User id=root;" +"Password='';";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT test_name FROM test";
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["test_name"].ToString());
            }
            Console.ReadLine();
        }
    }
}
