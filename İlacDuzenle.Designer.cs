﻿namespace Giris_Sayfasi
{
    partial class İlacDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReceteEklemeButonu = new System.Windows.Forms.Button();
            this.ReceteAramaProgramı = new System.Windows.Forms.Button();
            this.AnaSayfayaDonusButonu = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ilacAgirlik = new System.Windows.Forms.TextBox();
            this.ilacAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReceteSilmeButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 28;
            // 
            // ReceteEklemeButonu
            // 
            this.ReceteEklemeButonu.BackColor = System.Drawing.Color.Pink;
            this.ReceteEklemeButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteEklemeButonu.Location = new System.Drawing.Point(236, 181);
            this.ReceteEklemeButonu.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteEklemeButonu.Name = "ReceteEklemeButonu";
            this.ReceteEklemeButonu.Size = new System.Drawing.Size(210, 35);
            this.ReceteEklemeButonu.TabIndex = 24;
            this.ReceteEklemeButonu.Text = "Ekle";
            this.ReceteEklemeButonu.UseVisualStyleBackColor = false;
            this.ReceteEklemeButonu.Click += new System.EventHandler(this.ReceteEklemeButonu_Click);
            // 
            // ReceteAramaProgramı
            // 
            this.ReceteAramaProgramı.BackColor = System.Drawing.Color.Pink;
            this.ReceteAramaProgramı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteAramaProgramı.Location = new System.Drawing.Point(16, 181);
            this.ReceteAramaProgramı.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteAramaProgramı.Name = "ReceteAramaProgramı";
            this.ReceteAramaProgramı.Size = new System.Drawing.Size(210, 35);
            this.ReceteAramaProgramı.TabIndex = 23;
            this.ReceteAramaProgramı.Text = "Ara";
            this.ReceteAramaProgramı.UseVisualStyleBackColor = false;
            // 
            // AnaSayfayaDonusButonu
            // 
            this.AnaSayfayaDonusButonu.BackColor = System.Drawing.Color.Pink;
            this.AnaSayfayaDonusButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnaSayfayaDonusButonu.Location = new System.Drawing.Point(1055, 181);
            this.AnaSayfayaDonusButonu.Margin = new System.Windows.Forms.Padding(5);
            this.AnaSayfayaDonusButonu.Name = "AnaSayfayaDonusButonu";
            this.AnaSayfayaDonusButonu.Size = new System.Drawing.Size(411, 35);
            this.AnaSayfayaDonusButonu.TabIndex = 22;
            this.AnaSayfayaDonusButonu.Text = "Ana Sayfaya Dön";
            this.AnaSayfayaDonusButonu.UseVisualStyleBackColor = false;
            this.AnaSayfayaDonusButonu.Click += new System.EventHandler(this.AnaSayfayaDonusButonu_Click);
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
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(623, 74);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(572, 35);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "İlaç Adeti Gir";
            // 
            // ilacAgirlik
            // 
            this.ilacAgirlik.Location = new System.Drawing.Point(16, 74);
            this.ilacAgirlik.Margin = new System.Windows.Forms.Padding(5);
            this.ilacAgirlik.Multiline = true;
            this.ilacAgirlik.Name = "ilacAgirlik";
            this.ilacAgirlik.Size = new System.Drawing.Size(572, 35);
            this.ilacAgirlik.TabIndex = 33;
            this.ilacAgirlik.Text = "İlaç Ağırlığı Gir (mg)";
            // 
            // ilacAdi
            // 
            this.ilacAdi.Location = new System.Drawing.Point(16, 119);
            this.ilacAdi.Margin = new System.Windows.Forms.Padding(5);
            this.ilacAdi.Multiline = true;
            this.ilacAdi.Name = "ilacAdi";
            this.ilacAdi.Size = new System.Drawing.Size(572, 35);
            this.ilacAdi.TabIndex = 34;
            this.ilacAdi.Text = "İlaç Adı Gir";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(16, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.Location = new System.Drawing.Point(16, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1192, 279);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReceteSilmeButonu
            // 
            this.ReceteSilmeButonu.BackColor = System.Drawing.Color.Pink;
            this.ReceteSilmeButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceteSilmeButonu.Location = new System.Drawing.Point(456, 181);
            this.ReceteSilmeButonu.Margin = new System.Windows.Forms.Padding(5);
            this.ReceteSilmeButonu.Name = "ReceteSilmeButonu";
            this.ReceteSilmeButonu.Size = new System.Drawing.Size(210, 35);
            this.ReceteSilmeButonu.TabIndex = 25;
            this.ReceteSilmeButonu.Text = "Sil";
            this.ReceteSilmeButonu.UseVisualStyleBackColor = false;
            this.ReceteSilmeButonu.Click += new System.EventHandler(this.ReceteSilmeButonu_Click);
            // 
            // İlacDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1478, 733);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ilacAdi);
            this.Controls.Add(this.ilacAgirlik);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceteSilmeButonu);
            this.Controls.Add(this.ReceteEklemeButonu);
            this.Controls.Add(this.ReceteAramaProgramı);
            this.Controls.Add(this.AnaSayfayaDonusButonu);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "İlacDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Düzenleme";
            this.Load += new System.EventHandler(this.İlacDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReceteEklemeButonu;
        private System.Windows.Forms.Button ReceteAramaProgramı;
        private System.Windows.Forms.Button AnaSayfayaDonusButonu;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ilacAgirlik;
        private System.Windows.Forms.TextBox ilacAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReceteSilmeButonu;
    }
}