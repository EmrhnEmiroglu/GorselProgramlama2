using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp51
{
    public partial class MainForm : Form
    {
        int salise, saniye, dakika, saat = 0;
        string anlikSaat, timerSaati;
        public MainForm()
        {
            InitializeComponent();
        }


        void Sifirla()
        {
            foreach (Control item in pnlSure.Controls)
            {
                if (item is Label)
                {
                    item.Text = "0";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            //anlikSaat = $"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}:{DateTime.Now.Second.ToString()}:{DateTime.Now.Millisecond.ToString()}";
            anlikSaat = "0:0:2:39";
            if (btnBasla.BackColor == Color.Green)
            {
                if (btnBasla.Text == "Başlat")
                {
                    btnBasla.Text = "Durdur";
                    timerGeriSayim.Enabled = true;
                }
                else
                {
                    btnBasla.Text = "Başlat";
                    timerGeriSayim.Enabled = false;
                }
            }
            else
            {
                if (btnBasla.Text == "Başlat")
                {
                    btnBasla.Text = "Durdur";
                    timer1.Enabled = true;
                }
                else
                {
                    btnBasla.Text = "Başlat";
                    timer1.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            lblSalise.Text = salise.ToString();
            if (salise == 99)
            {
                saniye++;
                lblSaniye.Text = saniye.ToString();
                salise = 0;
            }
            if (saniye == 60)
            {
                dakika++;
                lblDakika.Text = dakika.ToString();
                saniye = 0;
            }
            if (dakika == 60)
            {
                saat++;
                lblSaat.Text = saat.ToString();
                dakika = 0;
            }
            if (saat == 24)
            {
                saat = 0;
            }
            timerSaati = $"{saat.ToString()}:{dakika.ToString()}:{saniye.ToString()}:{salise.ToString()}";
            if (timerSaati == anlikSaat)
            {
                timer1.Enabled = false;
                btnBasla.Text = "Başlat";
                btnBasla.BackColor = Color.Green;

                lblSaatAnlik.Text = saat.ToString();
                lblDakikaAnlik.Text = dakika.ToString();
                lblSaniyeAnlik.Text = saniye.ToString();
                lblSaliseAnlik.Text = salise.ToString();

            }
        }
        private void timerGeriSayim_Tick(object sender, EventArgs e)
        {
        
            if (saat == 0 && dakika == 0 && saniye == 0 && salise == 0)
            {
                timerGeriSayim.Enabled = false;
                btnBasla.Text = "Başlat";
                btnBasla.BackColor = Color.Green;
                return;
            }

            salise--;
            if (salise < 0)
            {
                salise = 99;
                saniye--;
            }

            if (saniye < 0)
            {
                saniye = 59;
                dakika--;
            }

            if (dakika < 0)
            {
                dakika = 59;
                saat--;
            }

            
            lblSaliseAnlik.Text = salise.ToString();
            lblSaniyeAnlik.Text = saniye.ToString();
            lblDakikaAnlik.Text = dakika.ToString();
            lblSaatAnlik.Text = saat.ToString();
        }

    }
}
