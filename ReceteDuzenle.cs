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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Giris_Sayfasi
{
    public partial class ReceteDuzenle : Form
    {
        public ReceteDuzenle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfayaDonusButonu_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void ReceteEklemeButonu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            con.Open();
            string sql = "insert into rec(tckn,hadsoy,dyer,dyil) values('" + TCKN.Text + "','"+HastaAdSoyad.Text+"','"+DogumYeri.Text+"','"+DogumYili.Text+"')";
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("basarili");
        }

        private void BayRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("recId", "id");
            dataGridView1.Columns.Add("hadsoy", "adı ve soyadı");
            dataGridView1.Columns.Add("tckn", "tckn");
            dataGridView1.Columns.Add("dyil", "dogum yili");
            dataGridView1.Columns.Add("dyer", "doğum yeri");
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from rec", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
        }
    }
}
