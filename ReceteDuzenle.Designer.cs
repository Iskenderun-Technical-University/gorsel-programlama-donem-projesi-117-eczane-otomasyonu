namespace Giris_Sayfasi
{
    partial class ReceteDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReceteID = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.AnaSayfayaDonusButonu = new System.Windows.Forms.Button();
            this.ReceteAramaProgramı = new System.Windows.Forms.Button();
            this.ReceteEklemeButonu = new System.Windows.Forms.Button();
            this.ReceteSilmeButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.Bayan = new System.Windows.Forms.RadioButton();
            this.BayRadioButton = new System.Windows.Forms.RadioButton();
            this.Cinsiyet = new System.Windows.Forms.GroupBox();
            this.DogumYili = new System.Windows.Forms.TextBox();
            this.HastaAdSoyad = new System.Windows.Forms.TextBox();
            this.DogumYeri = new System.Windows.Forms.TextBox();
            this.TCKN = new System.Windows.Forms.TextBox();
            this.ReceteList = new System.Windows.Forms.ListView();
            this.label = new System.Windows.Forms.Label();
            this.kayitSayisi = new System.Windows.Forms.Label();
            this.Cinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceteID
            // 
            this.ReceteID.Location = new System.Drawing.Point(20, 87);
            this.ReceteID.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteID.Multiline = true;
            this.ReceteID.Name = "ReceteID";
            this.ReceteID.Size = new System.Drawing.Size(572, 35);
            this.ReceteID.TabIndex = 2;
            this.ReceteID.Text = "Reçete ID giriniz";
            this.ReceteID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1972, 116);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(472, 52);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1490, 116);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(472, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // AnaSayfayaDonusButonu
            // 
            this.AnaSayfayaDonusButonu.BackColor = System.Drawing.Color.Pink;
            this.AnaSayfayaDonusButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnaSayfayaDonusButonu.Location = new System.Drawing.Point(934, 14);
            this.AnaSayfayaDonusButonu.Margin = new System.Windows.Forms.Padding(5);
            this.AnaSayfayaDonusButonu.Name = "AnaSayfayaDonusButonu";
            this.AnaSayfayaDonusButonu.Size = new System.Drawing.Size(492, 30);
            this.AnaSayfayaDonusButonu.TabIndex = 10;
            this.AnaSayfayaDonusButonu.Text = "Ana Sayfaya Dön";
            this.AnaSayfayaDonusButonu.UseVisualStyleBackColor = false;
            this.AnaSayfayaDonusButonu.Click += new System.EventHandler(this.AnaSayfayaDonusButonu_Click);
            // 
            // ReceteAramaProgramı
            // 
            this.ReceteAramaProgramı.BackColor = System.Drawing.Color.Pink;
            this.ReceteAramaProgramı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteAramaProgramı.Location = new System.Drawing.Point(822, 303);
            this.ReceteAramaProgramı.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteAramaProgramı.Name = "ReceteAramaProgramı";
            this.ReceteAramaProgramı.Size = new System.Drawing.Size(202, 35);
            this.ReceteAramaProgramı.TabIndex = 12;
            this.ReceteAramaProgramı.Text = "Ara";
            this.ReceteAramaProgramı.UseVisualStyleBackColor = false;
            // 
            // ReceteEklemeButonu
            // 
            this.ReceteEklemeButonu.BackColor = System.Drawing.Color.Pink;
            this.ReceteEklemeButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteEklemeButonu.Location = new System.Drawing.Point(1034, 303);
            this.ReceteEklemeButonu.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteEklemeButonu.Name = "ReceteEklemeButonu";
            this.ReceteEklemeButonu.Size = new System.Drawing.Size(210, 35);
            this.ReceteEklemeButonu.TabIndex = 15;
            this.ReceteEklemeButonu.Text = "Ekle";
            this.ReceteEklemeButonu.UseVisualStyleBackColor = false;
            this.ReceteEklemeButonu.Click += new System.EventHandler(this.ReceteEklemeButonu_Click);
            // 
            // ReceteSilmeButonu
            // 
            this.ReceteSilmeButonu.BackColor = System.Drawing.Color.Pink;
            this.ReceteSilmeButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteSilmeButonu.Location = new System.Drawing.Point(1254, 303);
            this.ReceteSilmeButonu.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteSilmeButonu.Name = "ReceteSilmeButonu";
            this.ReceteSilmeButonu.Size = new System.Drawing.Size(210, 35);
            this.ReceteSilmeButonu.TabIndex = 17;
            this.ReceteSilmeButonu.Text = "Sil";
            this.ReceteSilmeButonu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 20;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(1434, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Bayan
            // 
            this.Bayan.AutoSize = true;
            this.Bayan.Location = new System.Drawing.Point(80, 27);
            this.Bayan.Name = "Bayan";
            this.Bayan.Size = new System.Drawing.Size(50, 25);
            this.Bayan.TabIndex = 22;
            this.Bayan.TabStop = true;
            this.Bayan.Text = "Kız";
            this.Bayan.UseVisualStyleBackColor = true;
            this.Bayan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BayRadioButton
            // 
            this.BayRadioButton.AutoSize = true;
            this.BayRadioButton.Location = new System.Drawing.Point(6, 27);
            this.BayRadioButton.Name = "BayRadioButton";
            this.BayRadioButton.Size = new System.Drawing.Size(70, 25);
            this.BayRadioButton.TabIndex = 23;
            this.BayRadioButton.TabStop = true;
            this.BayRadioButton.Text = "Erkek";
            this.BayRadioButton.UseVisualStyleBackColor = true;
            this.BayRadioButton.CheckedChanged += new System.EventHandler(this.BayRadioButton_CheckedChanged);
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.Bayan);
            this.Cinsiyet.Controls.Add(this.BayRadioButton);
            this.Cinsiyet.Location = new System.Drawing.Point(614, 87);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(160, 72);
            this.Cinsiyet.TabIndex = 24;
            this.Cinsiyet.TabStop = false;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // DogumYili
            // 
            this.DogumYili.Location = new System.Drawing.Point(22, 222);
            this.DogumYili.Margin = new System.Windows.Forms.Padding(5);
            this.DogumYili.Multiline = true;
            this.DogumYili.Name = "DogumYili";
            this.DogumYili.Size = new System.Drawing.Size(572, 35);
            this.DogumYili.TabIndex = 25;
            this.DogumYili.Text = "Doğum Yılı";
            // 
            // HastaAdSoyad
            // 
            this.HastaAdSoyad.Location = new System.Drawing.Point(20, 132);
            this.HastaAdSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.HastaAdSoyad.Multiline = true;
            this.HastaAdSoyad.Name = "HastaAdSoyad";
            this.HastaAdSoyad.Size = new System.Drawing.Size(572, 35);
            this.HastaAdSoyad.TabIndex = 27;
            this.HastaAdSoyad.Text = "Hasta Adı Soyadı Giriniz";
            // 
            // DogumYeri
            // 
            this.DogumYeri.Location = new System.Drawing.Point(22, 267);
            this.DogumYeri.Margin = new System.Windows.Forms.Padding(5);
            this.DogumYeri.Multiline = true;
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.Size = new System.Drawing.Size(572, 35);
            this.DogumYeri.TabIndex = 28;
            this.DogumYeri.Text = "Doğum Yeri";
            // 
            // TCKN
            // 
            this.TCKN.Location = new System.Drawing.Point(22, 177);
            this.TCKN.Margin = new System.Windows.Forms.Padding(5);
            this.TCKN.Multiline = true;
            this.TCKN.Name = "TCKN";
            this.TCKN.Size = new System.Drawing.Size(572, 35);
            this.TCKN.TabIndex = 26;
            this.TCKN.Text = "TCKN";
            // 
            // ReceteList
            // 
            this.ReceteList.BackColor = System.Drawing.Color.Pink;
            this.ReceteList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceteList.CheckBoxes = true;
            this.ReceteList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ReceteList.GridLines = true;
            this.ReceteList.HideSelection = false;
            this.ReceteList.Location = new System.Drawing.Point(12, 346);
            this.ReceteList.Name = "ReceteList";
            this.ReceteList.Size = new System.Drawing.Size(1450, 375);
            this.ReceteList.TabIndex = 29;
            this.ReceteList.UseCompatibleStateImageBehavior = false;
            this.ReceteList.View = System.Windows.Forms.View.Details;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 317);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(179, 21);
            this.label.TabIndex = 30;
            this.label.Text = "Kayıtlı Reçete Sayısı = ";
            // 
            // kayitSayisi
            // 
            this.kayitSayisi.AutoSize = true;
            this.kayitSayisi.Location = new System.Drawing.Point(197, 317);
            this.kayitSayisi.Name = "kayitSayisi";
            this.kayitSayisi.Size = new System.Drawing.Size(45, 21);
            this.kayitSayisi.TabIndex = 31;
            this.kayitSayisi.Text = "_____";
            // 
            // ReceteDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1478, 733);
            this.ControlBox = false;
            this.Controls.Add(this.kayitSayisi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ReceteList);
            this.Controls.Add(this.DogumYeri);
            this.Controls.Add(this.HastaAdSoyad);
            this.Controls.Add(this.TCKN);
            this.Controls.Add(this.DogumYili);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceteSilmeButonu);
            this.Controls.Add(this.ReceteEklemeButonu);
            this.Controls.Add(this.ReceteAramaProgramı);
            this.Controls.Add(this.AnaSayfayaDonusButonu);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ReceteID);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReceteDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Düzenleme";
            this.Load += new System.EventHandler(this.ReceteDuzenle_Load);
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ReceteID;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button AnaSayfayaDonusButonu;
        private System.Windows.Forms.Button ReceteAramaProgramı;
        private System.Windows.Forms.Button ReceteEklemeButonu;
        private System.Windows.Forms.Button ReceteSilmeButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton Bayan;
        private System.Windows.Forms.RadioButton BayRadioButton;
        private System.Windows.Forms.GroupBox Cinsiyet;
        private System.Windows.Forms.TextBox DogumYili;
        private System.Windows.Forms.TextBox HastaAdSoyad;
        private System.Windows.Forms.TextBox DogumYeri;
        private System.Windows.Forms.TextBox TCKN;
        private System.Windows.Forms.ListView ReceteList;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label kayitSayisi;
    }
}