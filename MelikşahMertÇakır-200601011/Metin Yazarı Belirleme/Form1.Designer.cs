
namespace Metin_Yazarı_Belirleme
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.txtDosyaBilgi = new System.Windows.Forms.TextBox();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnTreeEkle = new System.Windows.Forms.Button();
            this.lblStackBasari = new System.Windows.Forms.Label();
            this.btnFrekans = new System.Windows.Forms.Button();
            this.txtFrekansAdet = new System.Windows.Forms.TextBox();
            this.lblFrekansAdet = new System.Windows.Forms.Label();
            this.txtSıkKullanılanKelimeler = new System.Windows.Forms.TextBox();
            this.lblTreeBasari = new System.Windows.Forms.Label();
            this.lblFrekansBasari = new System.Windows.Forms.Label();
            this.btnHashOlustur = new System.Windows.Forms.Button();
            this.lblHashBasari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.BackColor = System.Drawing.Color.LightCoral;
            this.btnMetinYukle.Font = new System.Drawing.Font("Nirmala UI Semilight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetinYukle.Location = new System.Drawing.Point(66, 12);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(268, 59);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = false;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.BackColor = System.Drawing.Color.White;
            this.txtDosyaYolu.Enabled = false;
            this.txtDosyaYolu.Font = new System.Drawing.Font("Nirmala UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosyaYolu.Location = new System.Drawing.Point(66, 94);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(268, 25);
            this.txtDosyaYolu.TabIndex = 1;
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStackeOku.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStackeOku.Location = new System.Drawing.Point(144, 141);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(97, 59);
            this.btnStackeOku.TabIndex = 2;
            this.btnStackeOku.Text = "Stack\' e Oku";
            this.btnStackeOku.UseVisualStyleBackColor = false;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackeOku_Click);
            // 
            // txtDosyaBilgi
            // 
            this.txtDosyaBilgi.BackColor = System.Drawing.Color.White;
            this.txtDosyaBilgi.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosyaBilgi.Location = new System.Drawing.Point(66, 224);
            this.txtDosyaBilgi.Multiline = true;
            this.txtDosyaBilgi.Name = "txtDosyaBilgi";
            this.txtDosyaBilgi.Size = new System.Drawing.Size(277, 106);
            this.txtDosyaBilgi.TabIndex = 3;
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(63, 74);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(80, 17);
            this.lblDosyaYolu.TabIndex = 4;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // btnTreeEkle
            // 
            this.btnTreeEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTreeEkle.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeEkle.Location = new System.Drawing.Point(144, 352);
            this.btnTreeEkle.Name = "btnTreeEkle";
            this.btnTreeEkle.Size = new System.Drawing.Size(97, 59);
            this.btnTreeEkle.TabIndex = 5;
            this.btnTreeEkle.Text = "Agaca Aktar";
            this.btnTreeEkle.UseVisualStyleBackColor = false;
            this.btnTreeEkle.Click += new System.EventHandler(this.btnTreeEkle_Click);
            // 
            // lblStackBasari
            // 
            this.lblStackBasari.AutoSize = true;
            this.lblStackBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStackBasari.ForeColor = System.Drawing.Color.Black;
            this.lblStackBasari.Location = new System.Drawing.Point(140, 201);
            this.lblStackBasari.Name = "lblStackBasari";
            this.lblStackBasari.Size = new System.Drawing.Size(194, 20);
            this.lblStackBasari.TabIndex = 6;
            this.lblStackBasari.Text = "(Bu işlem biraz sürebilir)";
            this.lblStackBasari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFrekans
            // 
            this.btnFrekans.BackColor = System.Drawing.Color.Violet;
            this.btnFrekans.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrekans.Location = new System.Drawing.Point(472, 12);
            this.btnFrekans.Name = "btnFrekans";
            this.btnFrekans.Size = new System.Drawing.Size(157, 59);
            this.btnFrekans.TabIndex = 7;
            this.btnFrekans.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnFrekans.UseVisualStyleBackColor = false;
            this.btnFrekans.Click += new System.EventHandler(this.btnFrekans_Click);
            // 
            // txtFrekansAdet
            // 
            this.txtFrekansAdet.BackColor = System.Drawing.Color.LightGray;
            this.txtFrekansAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFrekansAdet.Location = new System.Drawing.Point(413, 12);
            this.txtFrekansAdet.Multiline = true;
            this.txtFrekansAdet.Name = "txtFrekansAdet";
            this.txtFrekansAdet.Size = new System.Drawing.Size(62, 59);
            this.txtFrekansAdet.TabIndex = 8;
            this.txtFrekansAdet.Text = "1";
            this.txtFrekansAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrekansAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrekansAdet_KeyPress);
            // 
            // lblFrekansAdet
            // 
            this.lblFrekansAdet.AutoSize = true;
            this.lblFrekansAdet.Location = new System.Drawing.Point(422, 74);
            this.lblFrekansAdet.Name = "lblFrekansAdet";
            this.lblFrekansAdet.Size = new System.Drawing.Size(37, 17);
            this.lblFrekansAdet.TabIndex = 9;
            this.lblFrekansAdet.Text = "Adet";
            // 
            // txtSıkKullanılanKelimeler
            // 
            this.txtSıkKullanılanKelimeler.Location = new System.Drawing.Point(413, 97);
            this.txtSıkKullanılanKelimeler.Multiline = true;
            this.txtSıkKullanılanKelimeler.Name = "txtSıkKullanılanKelimeler";
            this.txtSıkKullanılanKelimeler.Size = new System.Drawing.Size(216, 103);
            this.txtSıkKullanılanKelimeler.TabIndex = 10;
            // 
            // lblTreeBasari
            // 
            this.lblTreeBasari.AutoSize = true;
            this.lblTreeBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTreeBasari.ForeColor = System.Drawing.Color.Black;
            this.lblTreeBasari.Location = new System.Drawing.Point(143, 414);
            this.lblTreeBasari.Name = "lblTreeBasari";
            this.lblTreeBasari.Size = new System.Drawing.Size(0, 20);
            this.lblTreeBasari.TabIndex = 11;
            this.lblTreeBasari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrekansBasari
            // 
            this.lblFrekansBasari.AutoSize = true;
            this.lblFrekansBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrekansBasari.ForeColor = System.Drawing.Color.Black;
            this.lblFrekansBasari.Location = new System.Drawing.Point(486, 71);
            this.lblFrekansBasari.Name = "lblFrekansBasari";
            this.lblFrekansBasari.Size = new System.Drawing.Size(0, 20);
            this.lblFrekansBasari.TabIndex = 12;
            this.lblFrekansBasari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHashOlustur
            // 
            this.btnHashOlustur.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnHashOlustur.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashOlustur.Location = new System.Drawing.Point(462, 224);
            this.btnHashOlustur.Name = "btnHashOlustur";
            this.btnHashOlustur.Size = new System.Drawing.Size(116, 59);
            this.btnHashOlustur.TabIndex = 13;
            this.btnHashOlustur.Text = "Hash Tablo Olustur";
            this.btnHashOlustur.UseVisualStyleBackColor = false;
            this.btnHashOlustur.Click += new System.EventHandler(this.btnHashOlustur_Click);
            // 
            // lblHashBasari
            // 
            this.lblHashBasari.AutoSize = true;
            this.lblHashBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHashBasari.ForeColor = System.Drawing.Color.Black;
            this.lblHashBasari.Location = new System.Drawing.Point(458, 286);
            this.lblHashBasari.Name = "lblHashBasari";
            this.lblHashBasari.Size = new System.Drawing.Size(0, 20);
            this.lblHashBasari.TabIndex = 14;
            this.lblHashBasari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(702, 443);
            this.Controls.Add(this.lblHashBasari);
            this.Controls.Add(this.btnHashOlustur);
            this.Controls.Add(this.lblFrekansBasari);
            this.Controls.Add(this.lblTreeBasari);
            this.Controls.Add(this.txtSıkKullanılanKelimeler);
            this.Controls.Add(this.lblFrekansAdet);
            this.Controls.Add(this.txtFrekansAdet);
            this.Controls.Add(this.btnFrekans);
            this.Controls.Add(this.lblStackBasari);
            this.Controls.Add(this.btnTreeEkle);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.txtDosyaBilgi);
            this.Controls.Add(this.btnStackeOku);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Metin Yazarını Belirle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Button btnStackeOku;
        private System.Windows.Forms.TextBox txtDosyaBilgi;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Button btnTreeEkle;
        private System.Windows.Forms.Label lblStackBasari;
        private System.Windows.Forms.Button btnFrekans;
        private System.Windows.Forms.TextBox txtFrekansAdet;
        private System.Windows.Forms.Label lblFrekansAdet;
        private System.Windows.Forms.TextBox txtSıkKullanılanKelimeler;
        private System.Windows.Forms.Label lblTreeBasari;
        private System.Windows.Forms.Label lblFrekansBasari;
        private System.Windows.Forms.Button btnHashOlustur;
        private System.Windows.Forms.Label lblHashBasari;
    }
}

