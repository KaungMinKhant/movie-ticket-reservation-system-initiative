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
    public partial class insertAuditoriumView : Form
    {
        public insertAuditoriumView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String connString = "Data Source=127.0.0.1;" + "Initial Catalog=movie_ticket_reservation_system;" + "User id=root;" + "Password='';";

                String CommandText = "INSERT INTO auditorium VALUES('', '" + this.textBox1.Text+ "', '" + this.textBox2.Text +"')";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = new MySqlCommand(CommandText, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Data Saved");
                while (reader.Read())
                {
                    
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
