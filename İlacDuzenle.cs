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
            dataGridView1.Columns.Add("ilac_id", "ilaç id");
            dataGridView1.Columns.Add("ilac_ad", "ilaç adı");
            dataGridView1.Columns.Add("ilac_mg", "ilaç mg");
            dataGridView1.Columns.Add("ilac_adet", "ilaç adet");
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\proje1\\gorsel-programlama-donem-projesi-117-eczane-otomasyonu\\proje.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ilac",con);
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
    }
}
