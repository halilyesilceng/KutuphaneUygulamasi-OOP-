namespace quiz2
{
    partial class Form1
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
            this.lblISBNNo = new System.Windows.Forms.Label();
            this.txtISBNNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtAlisTarihi = new System.Windows.Forms.TextBox();
            this.lblAlisTarihi = new System.Windows.Forms.Label();
            this.txtIadeTarihi = new System.Windows.Forms.TextBox();
            this.lblIadeTarihi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtGoster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblISBNNo
            // 
            this.lblISBNNo.AutoSize = true;
            this.lblISBNNo.Location = new System.Drawing.Point(117, 62);
            this.lblISBNNo.Name = "lblISBNNo";
            this.lblISBNNo.Size = new System.Drawing.Size(69, 17);
            this.lblISBNNo.TabIndex = 0;
            this.lblISBNNo.Text = "ISBN No: ";
            // 
            // txtISBNNo
            // 
            this.txtISBNNo.Location = new System.Drawing.Point(199, 62);
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.Size = new System.Drawing.Size(165, 22);
            this.txtISBNNo.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(199, 99);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(165, 22);
            this.txtKitapAdi.TabIndex = 3;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(117, 99);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(68, 17);
            this.lblKitapAdi.TabIndex = 2;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(199, 136);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(165, 22);
            this.txtYazar.TabIndex = 5;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(117, 136);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(53, 17);
            this.lblYazar.TabIndex = 4;
            this.lblYazar.Text = "Yazar :";
            // 
            // txtAlisTarihi
            // 
            this.txtAlisTarihi.Location = new System.Drawing.Point(199, 178);
            this.txtAlisTarihi.Name = "txtAlisTarihi";
            this.txtAlisTarihi.Size = new System.Drawing.Size(165, 22);
            this.txtAlisTarihi.TabIndex = 7;
            // 
            // lblAlisTarihi
            // 
            this.lblAlisTarihi.AutoSize = true;
            this.lblAlisTarihi.Location = new System.Drawing.Point(117, 178);
            this.lblAlisTarihi.Name = "lblAlisTarihi";
            this.lblAlisTarihi.Size = new System.Drawing.Size(78, 17);
            this.lblAlisTarihi.TabIndex = 6;
            this.lblAlisTarihi.Text = "Alış Tarihi :";
            // 
            // txtIadeTarihi
            // 
            this.txtIadeTarihi.Location = new System.Drawing.Point(199, 216);
            this.txtIadeTarihi.Name = "txtIadeTarihi";
            this.txtIadeTarihi.Size = new System.Drawing.Size(165, 22);
            this.txtIadeTarihi.TabIndex = 9;
            // 
            // lblIadeTarihi
            // 
            this.lblIadeTarihi.AutoSize = true;
            this.lblIadeTarihi.Location = new System.Drawing.Point(117, 216);
            this.lblIadeTarihi.Name = "lblIadeTarihi";
            this.lblIadeTarihi.Size = new System.Drawing.Size(83, 17);
            this.lblIadeTarihi.TabIndex = 8;
            this.lblIadeTarihi.Text = "İade Tarihi :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(120, 260);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(224, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(394, 45);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(371, 23);
            this.btnGoster.TabIndex = 12;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtGoster
            // 
            this.txtGoster.Location = new System.Drawing.Point(394, 74);
            this.txtGoster.Multiline = true;
            this.txtGoster.Name = "txtGoster";
            this.txtGoster.Size = new System.Drawing.Size(371, 209);
            this.txtGoster.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGoster);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIadeTarihi);
            this.Controls.Add(this.lblIadeTarihi);
            this.Controls.Add(this.txtAlisTarihi);
            this.Controls.Add(this.lblAlisTarihi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.txtISBNNo);
            this.Controls.Add(this.lblISBNNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISBNNo;
        private System.Windows.Forms.TextBox txtISBNNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox txtAlisTarihi;
        private System.Windows.Forms.Label lblAlisTarihi;
        private System.Windows.Forms.TextBox txtIadeTarihi;
        private System.Windows.Forms.Label lblIadeTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtGoster;
    }
}

