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

        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=phone_messages;Password=Ei1CW10ncoCHsaUp");

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
    }
}
