using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Giris_Sayfasi
{
    public partial class İlacDuzenle : Form
    {
        public İlacDuzenle()
        {
            InitializeComponent();
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
        private void İlacAdiGirme_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ilac_id", "ilaç id");
            dataGridView1.Columns.Add("ilac_ad", "ilaç adı");
            dataGridView1.Columns.Add("ilac_mg", "ilaç mg");
            dataGridView1.Columns.Add("ilac_adet", "ilaç adet");
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from medicine",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
        }
        private void İlacList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReceteEklemeButonu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
            con.Open();
            string sql = "insert into medicine(med_isim,med_gr,med_ad) values('" +ilacAdi.Text+ "','" +ilacAgirlik.Text+ "','"+textBox3.Text+"')";
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("basarili");
        }

        private void ReceteSilmeButonu_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\source\\repos\\projee\\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from medicine where med_id = @med_id ", con);
                cmd.Parameters.AddWithValue("@med_id", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void İlacDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
