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

namespace Charity
{
    public partial class Main_Page : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Main_Page(string user, string userType)
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;uid=root;database=Charity";
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void show_allData_Click(object sender, EventArgs e)
        {
            Data showAllData_page = new Data();
            showAllData_page.Show();

        }

        private void show_widower_Click(object sender, EventArgs e)
        {
            Widowers_Data widowersData_page = new Widowers_Data();
            widowersData_page.Show();
        }

        private void show_divorced_Click(object sender, EventArgs e)
        {
            Divorced divorcedData_page = new Divorced();
            divorcedData_page.Show();
        }

        private void show_orphans_Click(object sender, EventArgs e)
        {
            Orphans_Data orphansData_page = new Orphans_Data();
            orphansData_page.Show();
        }

        private void mainPage_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
