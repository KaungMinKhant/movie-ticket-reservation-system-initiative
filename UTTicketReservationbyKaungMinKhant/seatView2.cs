using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTTicketReservationbyKaungMinKhant
{
    public partial class seatView2 : Form
    {
        public seatView2()
        {
            InitializeComponent();
            Table_Load();
        }

        public void Table_Load()
        {
            dbConnection dbc = new dbConnection();
            dbc.selection("seat", dataGridView1);
        }
        
    }
}
