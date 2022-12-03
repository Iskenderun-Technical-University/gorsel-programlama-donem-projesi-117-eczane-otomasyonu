using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        

        private void ReceteDuzenle_Load(object sender, EventArgs e)
        {
            ReceteList.Columns.Add("Reçete ID", 150);
            ReceteList.Columns.Add("AD-SOYAD", 380);
            ReceteList.Columns.Add("TCKN", 312);
            ReceteList.Columns.Add("CİNSİYET", 150);
            ReceteList.Columns.Add("DOĞUM YILI", 150);
            ReceteList.Columns.Add("DOĞUM YERİ", 312); // hasta bilgileri girilecek
            kayitSayisiYaz();
        }
        private void kayitSayisiYaz()
        {
            int kayitliSayisi = ReceteList.Items.Count;
            kayitSayisi.Text = Convert.ToString(kayitliSayisi);
        }

        private void ReceteEklemeButonu_Click(object sender, EventArgs e)
        {
            string ID = "",
                adSoyad = "" ,
                tckn = "" ,
                cinsiyet = "" ,
                dogumYili = "",
                dogumYeri = "";
            ID = ReceteID.Text;
            adSoyad = HastaAdSoyad.Text;
            tckn = TCKN.Text;
            dogumYili = DogumYili.Text;
            dogumYeri = DogumYeri.Text;
            if (BayRadioButton.Checked == true)
                cinsiyet = BayRadioButton.Text;
            else if (Bayan.Checked == true)
                cinsiyet = Bayan.Text;
            string[] bilgiler = { ID, adSoyad, tckn, cinsiyet, dogumYili, dogumYeri };
            bool arananKayitKontrolu = false;
            for (int i = 0; i < ReceteList.Items.Count; i++) 
            {
                if (ReceteList.Items[i].SubItems[0].Text == ReceteID.Text)
                {
                    arananKayitKontrolu = true;
                    MessageBox.Show(ReceteID.Text + " - Böyle bir recete zaten mevcut.");
                }
            }   
            if (arananKayitKontrolu == false)
            {
                ListViewItem lst =new ListViewItem(bilgiler);
                if (ID != "" && adSoyad != "" && tckn != "" && dogumYili != "" && dogumYeri != "" && cinsiyet != "")
                {
                    ReceteList.Items.Add(lst);
                }
                else
                    MessageBox.Show("Kayit Bilgilerinde Eksiklik Var!!");
            }
            kayitSayisiYaz();
        }   
    }
}
