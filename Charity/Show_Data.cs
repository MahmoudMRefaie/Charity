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
     // الحالات الاجتماعية: مطلق - ارمل - اعزب - متزوج - ارزقى
     // بحث بـ: الاسم - الحالة الاجتماعية - العنوان 

    public partial class Data : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public object EntityFunctions { get; private set; }
        public object AnyText { get; private set; }

        public Data()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;uid=root;database=Charity";
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            InitializeComponent();
        }

        private void show_data_Click(object sender, EventArgs e)
        {

        }

        private void Data_Load(object sender, EventArgs e)
        {
            connection.Open();
            //cmd.CommandText = "SELECT state_name AS 'الاسم' ,state_SSN AS 'الرقم القومى' ,state_phone AS 'رقم الهاتف' ,state_age AS 'العمر'  ,state_address AS 'العنوان' ,state_gender AS 'النوع' ,state_social AS 'الحالة الاجتماعية' ,state_children_num AS 'عدد اطفاله' FROM State;";
            //cmd.CommandText = "SELECT state_name AS 'Name' ,state_SSN AS SSN ,state_phone AS 'Phone number' ,state_age AS 'Age'  ,state_address AS 'Address' ,state_gender AS 'Gender',state_income AS 'Income' , state_health AS 'Health Status' ,state_social AS 'Social state',wife_name AS 'Wife Name' ,wife_SSN AS 'Wife SSN' ,state_children_num AS 'Children Number' FROM State;";
            cmd.CommandText = "CALL ShowData();";
            cmd.Connection = connection;

            try
            {
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}