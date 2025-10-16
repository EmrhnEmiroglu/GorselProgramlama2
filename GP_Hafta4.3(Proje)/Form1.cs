using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Hafta4._3_Proje_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sure = 60;
        Random rnd = new Random();
        Label lbl = new Label();
        List<Button> oyunButonlari = new List<Button>();
        List<int> secilenSayilar = new List<int>();
        List<int> dogruSira = new List<int>();
        Timer timerHareket = new Timer();
        bool oyunDevam = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(lbl);
            lbl.Location = new Point(517, 150);
            lbl.Width = 100;
            lbl.Height = 100;
            lbl.Text = "SÜRE\n60 sn";

            
            timerHareket.Interval = 1000;
            timerHareket.Tick += TimerHareket_Tick;
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            
            foreach (var btn in oyunButonlari)
            {
                groupBox1.Controls.Remove(btn);
            }
            oyunButonlari.Clear();
            secilenSayilar.Clear();
            listBox1.Items.Clear();
            dogruSira.Clear();

            
            sure = 60;
            lbl.Text = "SÜRE\n60 sn";
            oyunDevam = true;

            
            List<int> sayilar = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                sayilar.Add(rnd.Next(1, 101));
            }

            
            dogruSira = sayilar.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                groupBox1.Controls.Add(btn);
                btn.Width = 40;
                btn.Height = 40;
                btn.Name = "btn" + (i + 1);
                btn.Text = sayilar[i].ToString();
                btn.Tag = sayilar[i];
                btn.Click += OyunButonu_Click;

                oyunButonlari.Add(btn);
            }

            
            ButonlariYerlestir();

            
            timer1.Start();
            timerHareket.Start();
        }

        private void ButonlariYerlestir()
        {
            List<Rectangle> kullanilanAlanlar = new List<Rectangle>();

            foreach (var btn in oyunButonlari)
            {
                bool uygunYerBulundu = false;
                int deneme = 0;

                while (!uygunYerBulundu && deneme < 100)
                {
                    int x = rnd.Next(5, groupBox1.Width - btn.Width - 5);
                    int y = rnd.Next(20, groupBox1.Height - btn.Height - 5);

                    Rectangle yeniAlan = new Rectangle(x, y, btn.Width, btn.Height);

                    bool cakisiyor = false;
                    foreach (var alan in kullanilanAlanlar)
                    {
                        Rectangle genisletilmisAlan = new Rectangle(
                            alan.X - 5,
                            alan.Y - 5,
                            alan.Width + 10,
                            alan.Height + 10
                        );

                        if (genisletilmisAlan.IntersectsWith(yeniAlan))
                        {
                            cakisiyor = true;
                            break;
                        }
                    }

                    if (!cakisiyor)
                    {
                        btn.Location = new Point(x, y);
                        kullanilanAlanlar.Add(yeniAlan);
                        uygunYerBulundu = true;
                    }

                    deneme++;
                }

                if (!uygunYerBulundu)
                {
                    int x = rnd.Next(5, groupBox1.Width - btn.Width - 5);
                    int y = rnd.Next(20, groupBox1.Height - btn.Height - 5);
                    btn.Location = new Point(x, y);
                }
            }
        }

        private void TimerHareket_Tick(object sender, EventArgs e)
        {
            if (oyunDevam)
            {
                ButonlariYerlestir();
            }
        }

        private void OyunButonu_Click(object sender, EventArgs e)
        {
            if (!oyunDevam) return;

            Button btn = (Button)sender;
            int sayi = (int)btn.Tag;

            secilenSayilar.Add(sayi);
            listBox1.Items.Add(sayi);

            btn.Enabled = false;
            btn.BackColor = Color.LightGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sure--;

            if (sure == 0)
            {
                OyunBitti(false, "Süreniz doldu!\nBaşarısız oldunuz. Tekrar deneyin.");
                lbl.Text = "SÜRE\n0 sn";
            }
            else
            {
                lbl.Text = "SÜRE\n" + sure + " sn";
            }
        }


        private void OyunBitti(bool kazandi, string mesaj)
        {
            timer1.Stop();
            timerHareket.Stop();
            oyunDevam = false;

            foreach (var btn in oyunButonlari)
            {
                btn.Enabled = false;
            }

            MessageBox.Show(mesaj, kazandi ? "Başarılı!" : "Başarısız!",
                MessageBoxButtons.OK,
                kazandi ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnbitir_Click_1(object sender, EventArgs e)
        {
            if (!oyunDevam)
            {
                MessageBox.Show("Önce oyunu başlatmalısınız!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var secilenCiftler = secilenSayilar.Where(x => x % 2 == 0).ToList();

            if (secilenCiftler.Count == 0)
            {
                OyunBitti(false, "Hiç çift sayı seçmediniz!\nBaşarısız oldunuz. Tekrar deneyin.");
                return;
            }

            var secilenTekler = secilenSayilar.Where(x => x % 2 != 0).ToList();
            if (secilenTekler.Count > 0)
            {
                OyunBitti(false, "Tek sayı seçtiniz! Sadece çift sayıları seçmelisiniz.\nBaşarısız oldunuz. Tekrar deneyin.");
                return;
            }

            if (secilenCiftler.Count != dogruSira.Count)
            {
                OyunBitti(false, $"Tüm çift sayıları seçmediniz!\nSeçilen: {secilenCiftler.Count}, Olması gereken: {dogruSira.Count}\nBaşarısız oldunuz. Tekrar deneyin.");
                return;
            }

            bool dogruMu = true;
            for (int i = 0; i < dogruSira.Count; i++)
            {
                if (secilenCiftler[i] != dogruSira[i])
                {
                    dogruMu = false;
                    break;
                }
            }

            if (dogruMu)
            {
                OyunBitti(true, $"Tebrikler!\n{secilenCiftler.Count} sayıyı doğru sırayla seçtiniz.\n{60 - sure} saniyede tamamladınız.\nOyunu kazandınız!");
            }
            else
            {
                OyunBitti(false, "Yanlış sıralama! Çift sayıları küçükten büyüğe seçmelisiniz.\nBaşarısız oldunuz. Tekrar deneyin.");
            }
        }
    }
}