using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace UTTicketReservationbyKaungMinKhant
{
    public partial class auditoriumView : Form
    {
        public auditoriumView()
        {
            InitializeComponent();
            table_load();
            
        }

        public void table_load()
        {
            dbConnection dbc = new dbConnection();
            dbc.selection("auditorium", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input_data = Interaction.InputBox("Enter the id of the auditorium", "Delete", "", 0, 0);
            dbConnection DBC = new dbConnection();
            DBC.deletion("auditorium", input_data);
            table_load();
        }
    }
}
