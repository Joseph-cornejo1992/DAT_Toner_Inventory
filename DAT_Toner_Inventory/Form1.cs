using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAT_Toner_Inventory
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();
        }

        DataTable OBSdt = new DataTable();
        DataTable NonOBSdt = new DataTable();
        MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=DAT_Toner;Password=Ei1CW10ncoCHsaUp");

        private void checkInButton_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {

        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OBSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
