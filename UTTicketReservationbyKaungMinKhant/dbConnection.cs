using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UTTicketReservationbyKaungMinKhant
{
    class dbConnection
    {
        public dbConnection()
        {
            String connString = "Data Source=127.0.0.1;" + "Initial Catalog=movie_ticket_reservation_system;" + "User id=root;" + "Password='';";
            MySqlConnection conn = new MySqlConnection(connString);
        }
    }
}
