using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Giris_Sayfasi
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            con.Open();
            string sql = "insert into signup(user_name,user_pass) values('"+UserLogTxtBox.Text+"','"+textBox1.Text+"')";
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("basarili");
        }

        private void UserLogTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
