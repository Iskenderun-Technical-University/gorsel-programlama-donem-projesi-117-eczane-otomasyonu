using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void İlacDuzenle_Load(object sender, EventArgs e)
        {
            İlacList.Columns.Add("İlaç ID",362);
            İlacList.Columns.Add("İlaç Adı",362);
            İlacList.Columns.Add("İlaç Ağırlığı(mg)",362);
            İlacList.Columns.Add("İlaç Adedi",362);
        }
    }
}
