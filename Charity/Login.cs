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
    public partial class login_page : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public login_page()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;uid=root;database=Charity";
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            InitializeComponent();
            password_text.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;
            if (true)
            {
                cmd = new MySqlCommand("select * from Login_User where username='" + username + "'and user_password='" + password + "'", connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                if (dt.Rows.Count > 0 && dt.Rows[0]["user_type"].ToString().Equals("admin"))
                {
                    string usertype = dt.Rows[0]["user_type"].ToString();
                    Main_Page main_Page = new Main_Page(username, usertype);
                    main_Page.Show();
                    this.Hide();
                    MessageBox.Show("Welcome " + username);
                    connection.Close();
                } else if (dt.Rows.Count > 0 && dt.Rows[0]["user_type"].ToString().Equals("volunteer"))
                {
                    string usertype = dt.Rows[0]["user_type"].ToString();
                    Mini_Form mini_Form = new Mini_Form(username, usertype);
                    mini_Form.Show();
                    this.Hide();
                    MessageBox.Show("Welcome " + username);
                    connection.Close();
                } else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
