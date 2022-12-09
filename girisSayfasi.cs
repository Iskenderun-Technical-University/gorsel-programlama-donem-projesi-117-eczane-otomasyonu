using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Giris_Sayfasi
{
    public partial class girisSayfasi : Form
    {
        public girisSayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.Show();
            Hide();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string user = UserLogTxtBox.Text;
            string pass = PsswrdTxtBox.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from signup where user_name='" + UserLogTxtBox.Text + "'And user_pass='" + PsswrdTxtBox.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa frm = new AnaSayfa();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void UserLogTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
