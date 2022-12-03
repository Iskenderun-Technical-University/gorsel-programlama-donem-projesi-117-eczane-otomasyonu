namespace Giris_Sayfasi
{
    partial class AnaSayfa
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
            this.closeButton = new System.Windows.Forms.Button();
            this.ReceteButon = new System.Windows.Forms.Button();
            this.İlacButon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ReceteButon
            // 
            this.ReceteButon.BackColor = System.Drawing.Color.Pink;
            this.ReceteButon.Location = new System.Drawing.Point(29, 25);
            this.ReceteButon.Name = "ReceteButon";
            this.ReceteButon.Size = new System.Drawing.Size(256, 32);
            this.ReceteButon.TabIndex = 15;
            this.ReceteButon.Text = "Reçete Düzenle";
            this.ReceteButon.UseVisualStyleBackColor = false;
            this.ReceteButon.Click += new System.EventHandler(this.button4_Click);
            // 
            // İlacButon
            // 
            this.İlacButon.BackColor = System.Drawing.Color.Pink;
            this.İlacButon.Location = new System.Drawing.Point(291, 25);
            this.İlacButon.Name = "İlacButon";
            this.İlacButon.Size = new System.Drawing.Size(256, 32);
            this.İlacButon.TabIndex = 20;
            this.İlacButon.Text = "İlaç Düzenle";
            this.İlacButon.UseVisualStyleBackColor = false;
            this.İlacButon.Click += new System.EventHandler(this.İlacButon_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1453, 304);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(13, 413);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1453, 299);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1478, 733);
            this.ControlBox = false;
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.İlacButon);
            this.Controls.Add(this.ReceteButon);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button ReceteButon;
        private System.Windows.Forms.Button İlacButon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}