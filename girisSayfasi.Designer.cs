namespace Giris_Sayfasi
{
    partial class girisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.signButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.nameLog = new System.Windows.Forms.Label();
            this.UserLogTxtBox = new System.Windows.Forms.TextBox();
            this.psswrdLog = new System.Windows.Forms.Label();
            this.PsswrdTxtBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.Pink;
            this.signButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signButton.Location = new System.Drawing.Point(12, 685);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(220, 36);
            this.signButton.TabIndex = 0;
            this.signButton.Text = "Sign Up";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.Pink;
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logButton.Location = new System.Drawing.Point(1245, 685);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(220, 36);
            this.logButton.TabIndex = 1;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // nameLog
            // 
            this.nameLog.AutoSize = true;
            this.nameLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLog.Location = new System.Drawing.Point(475, 346);
            this.nameLog.Name = "nameLog";
            this.nameLog.Size = new System.Drawing.Size(98, 26);
            this.nameLog.TabIndex = 2;
            this.nameLog.Text = "User Name:";
            this.nameLog.UseCompatibleTextRendering = true;
            this.nameLog.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserLogTxtBox
            // 
            this.UserLogTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UserLogTxtBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserLogTxtBox.Location = new System.Drawing.Point(594, 346);
            this.UserLogTxtBox.Multiline = true;
            this.UserLogTxtBox.Name = "UserLogTxtBox";
            this.UserLogTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserLogTxtBox.Size = new System.Drawing.Size(338, 27);
            this.UserLogTxtBox.TabIndex = 3;
            this.UserLogTxtBox.UseSystemPasswordChar = true;
            // 
            // psswrdLog
            // 
            this.psswrdLog.AutoSize = true;
            this.psswrdLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.psswrdLog.Location = new System.Drawing.Point(488, 385);
            this.psswrdLog.Name = "psswrdLog";
            this.psswrdLog.Size = new System.Drawing.Size(85, 26);
            this.psswrdLog.TabIndex = 4;
            this.psswrdLog.Text = "Password:";
            this.psswrdLog.UseCompatibleTextRendering = true;
            this.psswrdLog.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PsswrdTxtBox
            // 
            this.PsswrdTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PsswrdTxtBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PsswrdTxtBox.Location = new System.Drawing.Point(594, 384);
            this.PsswrdTxtBox.Multiline = true;
            this.PsswrdTxtBox.Name = "PsswrdTxtBox";
            this.PsswrdTxtBox.PasswordChar = '*';
            this.PsswrdTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PsswrdTxtBox.Size = new System.Drawing.Size(338, 27);
            this.PsswrdTxtBox.TabIndex = 3;
            this.PsswrdTxtBox.UseSystemPasswordChar = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(1433, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // girisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1478, 733);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.PsswrdTxtBox);
            this.Controls.Add(this.psswrdLog);
            this.Controls.Add(this.UserLogTxtBox);
            this.Controls.Add(this.nameLog);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.signButton);
            this.Name = "girisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label nameLog;
        private System.Windows.Forms.TextBox UserLogTxtBox;
        private System.Windows.Forms.Label psswrdLog;
        private System.Windows.Forms.TextBox PsswrdTxtBox;
        private System.Windows.Forms.Button closeButton;
    }
}

