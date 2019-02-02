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

            dbConnection dbconn = new dbConnection();
            String entity_name = "test_name";
            String database_name = "test";

            dbconn.selection(entity_name, database_name);

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            insertDataView idv = new insertDataView();
            idv.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dbConnection dbconn = new dbConnection();
           
        }
    }
}
