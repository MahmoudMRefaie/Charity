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
    public partial class Mini_Form : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Mini_Form(string username, string userType)
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;uid=root;database=Charity";
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            InitializeComponent();
        }
    }
}
