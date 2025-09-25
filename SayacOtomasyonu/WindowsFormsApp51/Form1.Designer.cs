namespace WindowsFormsApp51
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblSaatAnlik = new System.Windows.Forms.Label();
            this.lblDakikaAnlik = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniyeAnlik = new System.Windows.Forms.Label();
            this.lblSaliseAnlik = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerGeriSayim = new System.Windows.Forms.Timer(this.components);
            this.pnlSure = new System.Windows.Forms.Panel();
            this.pnlSure.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(351, 97);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(95, 37);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblSaatAnlik
            // 
            this.lblSaatAnlik.Location = new System.Drawing.Point(8, 74);
            this.lblSaatAnlik.Name = "lblSaatAnlik";
            this.lblSaatAnlik.Size = new System.Drawing.Size(42, 35);
            this.lblSaatAnlik.TabIndex = 0;
            this.lblSaatAnlik.Text = "Saat";
            this.lblSaatAnlik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDakikaAnlik
            // 
            this.lblDakikaAnlik.Location = new System.Drawing.Point(74, 74);
            this.lblDakikaAnlik.Name = "lblDakikaAnlik";
            this.lblDakikaAnlik.Size = new System.Drawing.Size(42, 35);
            this.lblDakikaAnlik.TabIndex = 0;
            this.lblDakikaAnlik.Text = "Dakika";
            this.lblDakikaAnlik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaat
            // 
            this.lblSaat.Location = new System.Drawing.Point(8, 14);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(42, 35);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "Saat";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDakika
            // 
            this.lblDakika.Location = new System.Drawing.Point(74, 14);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(42, 35);
            this.lblDakika.TabIndex = 0;
            this.lblDakika.Text = "Dakika";
            this.lblDakika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaniyeAnlik
            // 
            this.lblSaniyeAnlik.Location = new System.Drawing.Point(136, 74);
            this.lblSaniyeAnlik.Name = "lblSaniyeAnlik";
            this.lblSaniyeAnlik.Size = new System.Drawing.Size(42, 35);
            this.lblSaniyeAnlik.TabIndex = 0;
            this.lblSaniyeAnlik.Text = "Saniye";
            this.lblSaniyeAnlik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaliseAnlik
            // 
            this.lblSaliseAnlik.Location = new System.Drawing.Point(195, 74);
            this.lblSaliseAnlik.Name = "lblSaliseAnlik";
            this.lblSaliseAnlik.Size = new System.Drawing.Size(42, 35);
            this.lblSaliseAnlik.TabIndex = 0;
            this.lblSaliseAnlik.Text = "Salise";
            this.lblSaliseAnlik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaniye
            // 
            this.lblSaniye.Location = new System.Drawing.Point(136, 14);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(42, 35);
            this.lblSaniye.TabIndex = 0;
            this.lblSaniye.Text = "Saniye";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalise
            // 
            this.lblSalise.Location = new System.Drawing.Point(195, 14);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(42, 35);
            this.lblSalise.TabIndex = 0;
            this.lblSalise.Text = "Salise";
            this.lblSalise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerGeriSayim
            // 
            this.timerGeriSayim.Interval = 1;
            this.timerGeriSayim.Tick += new System.EventHandler(this.timerGeriSayim_Tick);
            // 
            // pnlSure
            // 
            this.pnlSure.Controls.Add(this.lblSalise);
            this.pnlSure.Controls.Add(this.lblSaatAnlik);
            this.pnlSure.Controls.Add(this.lblSaniye);
            this.pnlSure.Controls.Add(this.lblDakikaAnlik);
            this.pnlSure.Controls.Add(this.lblSaliseAnlik);
            this.pnlSure.Controls.Add(this.lblSaat);
            this.pnlSure.Controls.Add(this.lblSaniyeAnlik);
            this.pnlSure.Controls.Add(this.lblDakika);
            this.pnlSure.Location = new System.Drawing.Point(74, 46);
            this.pnlSure.Name = "pnlSure";
            this.pnlSure.Size = new System.Drawing.Size(244, 128);
            this.pnlSure.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSure);
            this.Controls.Add(this.btnBasla);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSure.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblSaatAnlik;
        private System.Windows.Forms.Label lblDakikaAnlik;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniyeAnlik;
        private System.Windows.Forms.Label lblSaliseAnlik;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerGeriSayim;
        private System.Windows.Forms.Panel pnlSure;
    }
}

