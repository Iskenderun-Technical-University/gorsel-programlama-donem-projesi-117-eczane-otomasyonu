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

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\proje1\\gorsel-programlama-donem-projesi-117-eczane-otomasyonu\\proje.mdf;Integrated Security=True");
            con.Open(); 
            SqlCommand cmd = new SqlCommand("Insert into login (kullanici_adi,kullanici_sifre) values ('"+UserLogTxtBox+"','"+textBox1+"')",con);
            con.Close();
            girisSayfasi frm = new girisSayfasi();
            frm.Show();
            this.Close();
        }
    }
}
