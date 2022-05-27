using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Metin_Yazarı_Belirleme
{

    public partial class Form1 : Form
    {
        public int benzersizkelimesayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Dosya dosya = new Dosya();
        Cumle cumle = new Cumle();

        string text = "";
        LLTypedStack cumleler = new LLTypedStack();
        LLTypedStack kelimeler = new LLTypedStack();
        string[] kelimeDizisi = new string[10000];

        public void DosyaOku()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Metin Dosyası |*.txt";

            string filePath = "";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                txtDosyaYolu.Text = filePath;
            }
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    text = sr.ReadToEnd();
                }
            }
        }
        public void CumleleriAyirveStackeAt()//cümleleri noktaya göre ayırıp stacke ekliyoruz.
        {

            string[] cumles = text.Split('.');
            for (int i = 0; i < cumles.Length; i++)
            {
                Cumle cumle2 = new Cumle();
                cumle2.OrijinalHali = cumles[i];
                dosya.CumleSayisi++;
                CumleKelimeSayisi(cumle2);
                cumleler.Push(cumle2);

            }
            cumleler.Pop();
            dosya.CumleSayisi--;
            if (dosya.CumleSayisi > 0)
                dosya.CumledekiOrtalamaKelimeSayisi = dosya.KelimeSayisi / dosya.CumleSayisi;
        }

        public void CumleKelimeSayisi(Cumle cumle2) //her cümle için kelimeleri ayırıyoruz.
        {
            MatchCollection matches = Regex.Matches(cumle2.OrijinalHali, @"[\w\d_]+", RegexOptions.Singleline);
            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].Success)
                {
                    cumle2.KelimeSayisi++;
                }
            }

        }

        public void KelimeleriAyirveStackeAt()
        {
            int frekans = 1;
            bool mevcut = false;

            MatchCollection matches = Regex.Matches(text, @"[\w\d_]+", RegexOptions.Singleline);//kelimeleri bu kütüphane yardımıyla noktalama işaretlerini de hesaba katarak ayırıyoruz.
            for (int i = 0; i < matches.Count; i++)
            {

                if (matches[i].Success)
                {
                    dosya.KelimeSayisi++;
                    for (int j = 0; j < kelimeDizisi.Length; j++)
                    {
                        if (matches[i].ToString().ToLower() == kelimeDizisi[j])//kelimenin preprocessed halinin daha önce eklenip eklenmediğini kontrol ediyoruz.
                        {
                            frekans++;
                            mevcut = true; 

                        }
                    }
                    if (mevcut == false)//kelime daha önce yoksa ekleme işlemine başla.
                    {
                        kelimeDizisi[i] = matches[i].ToString().ToLower();
                        benzersizkelimesayisi++;

                        Kelime kelime = new Kelime();


                        kelime.MetindeKacinci = dosya.KelimeSayisi;
                        kelime.Orijinal = matches[i].ToString();
                        kelime.CumledeKacinci = i;
                        kelime.Preprocessed = matches[i].ToString().ToLower();
                        for (int j = 0; j < matches.Count; j++)
                        {
                            if (matches[i].ToString().ToLower() == matches[j].ToString().ToLower())
                            {
                                kelime.Frequency++;

                            }
                        }
                        kelimeler.Push(kelime);
                    }
                    mevcut = false;
                    frekans = 1;
                }


            }

        }

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            DosyaOku();
        }

        private void btnStackeOku_Click(object sender, EventArgs e)
        {
            KelimeleriAyirveStackeAt();
            CumleleriAyirveStackeAt();
            if (dosya.KelimeSayisi > 1)
            {
                txtDosyaBilgi.Text = "Kelime Sayısı: " + dosya.KelimeSayisi.ToString() + Environment.NewLine +
                "Cümle Sayısı " + dosya.CumleSayisi.ToString() + Environment.NewLine +
                "Cümle Basına Ortalama Kelime Sayısı: " + dosya.CumledekiOrtalamaKelimeSayisi.ToString();

                lblStackBasari.ForeColor = Color.Green;
                lblStackBasari.Text = "Başarılı";
            }
            else
            {
                lblStackBasari.ForeColor = Color.Red;
                lblStackBasari.Text = "Başarısız";
                txtDosyaBilgi.Text = "Herhangi bir bilgiye ulasılamadı.";
            }
        }
        MaxHeap kelimelerHeap = new MaxHeap(153);
        private void btnTreeEkle_Click(object sender, EventArgs e)
        {
            if (dosya.KelimeSayisi > 0)
            {
                object kelime;
                for (int i = 0; i < benzersizkelimesayisi; i++)
                {
                    kelime = kelimeler.Pop();
                    kelimelerHeap.Add((Kelime)kelime);
                }
                lblTreeBasari.ForeColor = Color.Green;
                lblTreeBasari.Text = "Başarılı";
            }
            else
            {
                lblTreeBasari.ForeColor = Color.Red;
                lblTreeBasari.Text = "Başarısız";
            }
            
        }
        
        private void btnFrekans_Click(object sender, EventArgs e)
        {
            if (lblTreeBasari.ForeColor == Color.Green)
            {
                HeapSort hs = new HeapSort(kelimelerHeap, benzersizkelimesayisi);
                object[] sorted = hs.Sort();
                string ssorted = "";
                int adet = Convert.ToInt32(txtFrekansAdet.Text);
                for (int i = 0; i < adet; i++)
                {
                    ssorted += i + 1 + ")  " + ((Kelime)sorted[i]).Preprocessed + " - " + ((Kelime)sorted[i]).Frequency + " kere" + Environment.NewLine;
                }
                txtSıkKullanılanKelimeler.Text = ssorted;
                lblFrekansBasari.ForeColor = Color.Green;
                lblFrekansBasari.Text = "Başarılı";
                btnHashOlustur.Enabled = false;
                lblHashBasari.Text = "Mor butonu kullandıktan" + Environment.NewLine + "sonra bu butona" + Environment.NewLine + "erişemezsiniz";
            }
            else
            {
                txtSıkKullanılanKelimeler.Text = "Herhangi bir bilgiye ulasılamadı.";
                lblFrekansBasari.ForeColor = Color.Red;
                lblFrekansBasari.Text = "Başarısız";
            }
                

        }
        private void txtFrekansAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHashOlustur_Click(object sender, EventArgs e) //En sık kullanılan kelimeleri getir butonunu kullandığımızda bozuluyor maalesef
        {
            if (lblTreeBasari.ForeColor == Color.Green)
            {
                string preProcessed = "";
                object kelime;
                HashMap kelimelerhash = new HashMap(benzersizkelimesayisi);
                for (int i = 0; i < benzersizkelimesayisi; i++)
                {
                    kelime = kelimelerHeap.Pop();
                    preProcessed = ((Kelime)kelime).Preprocessed;
                    kelimelerhash.Add(preProcessed, kelime);
                }
                lblHashBasari.Text = "Başarılı";
                lblHashBasari.ForeColor = Color.Green;
            }
            else
            {
                lblHashBasari.Text = "Başarısız";
                lblHashBasari.ForeColor = Color.Red;
            }
        }

    }
}
