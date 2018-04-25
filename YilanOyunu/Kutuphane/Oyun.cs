using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YilanOyunu.Kutuphane
{
    public class Oyun
    {
        Arena Arena { set; get; }
        Timer Timer { set; get; }
        Panel PnlArena { set; get; }
        Panel PnlTemplate { set; get; }

        internal Yem Yem { set; get; }
        Random R = new Random();

        int _skor = 0;
        public int Skor
        {
            set
            {
                this._skor = value;
                this.LblSkor.Text = this._skor.ToString();
            }
            get
            {
                return this._skor;
            }
        }
        int _seviye = 1;
        int Seviye 
        {
            set
            {
                this._seviye = value;
                this.LblSeviye.Text = this._seviye.ToString();
            }
            get
            {
                return this._seviye;
            }
        }
        Label LblSkor { set; get; }
        Label LblSeviye { set; get; }
        bool OyunBitti { set; get; }

        public Oyun(Label lblSkor,Label lblSeviye, Panel pnlArena, Panel pnlTemplate, Timer timer)
        {
            this.PnlArena = pnlArena;
            this.PnlTemplate = pnlTemplate;
            this.Timer = timer;
            this.LblSkor = lblSkor;
            this.LblSeviye = lblSeviye;
        }
        public void YeniOyun()
        {
            PnlArena.Controls.Clear();            
            Arena = new Arena(this,this.PnlArena, this.PnlTemplate);
            Timer.Interval = 500;
            Timer.Enabled = true;
            ArenayaYemAt();
            this.Skor = 0;
            OyunBitti = false;
        }
        public void Ilerle()
        {
            if (this.OyunBitti == true)
            {
                this.Timer.Stop();
                return;
            }
            else
            {
                Arena.Ilerle();
                if (Arena.YilanCarpti)
                {
                    Timer.Stop();
                    MessageBox.Show("Yilan carpti");
                }
            }
        }
        public void YonDegistir(int yon)
        {
            Arena.YonDegistir(yon);
        }      

        public void DuraklatDevamEttir()
        {
            this.Timer.Enabled = !this.Timer.Enabled;
        }
        public void YemYendi()
        {
            SkorArttir();
            this.Yem.panel.Dispose();

            if (this.OyunBitti == false)
            {            
                ArenayaYemAt();
            }
            

        }

        private void ArenayaYemAt()
        {
            Yem = new Yem();
            if (BosAlanBul(Yem))
            {
                Yem.ArenadaGoster(Arena);
            }
            else
            {
                MessageBox.Show("Arenada yer yok");            
            }
        }
        private bool BosAlanBul(Yem yem)
        {
            int deneme = 0;
            int maxDeneme = 1000;
            bool bulundu = false;

            while (!bulundu && deneme < maxDeneme)
            {
                int i = R.Next(0, Arena.SatirSayisi);
                int j = R.Next(0, Arena.SutunSayisi);
                if (Arena.Tablo[i, j] == 0)
                {
                    bulundu = true;
                    yem.X = i;
                    yem.Y = j;
                }
                deneme++;
            }
            return bulundu;
        }
        private void SkorArttir()
        {
            this.Skor+=10;                   
            if ((this.Skor % 100) == 0)
            {                
                SeviyeArttir();
            }
        }
        private void SeviyeArttir()
        {
            if (this.Seviye < 10)
            {
                this.Seviye++;
                this.Timer.Interval -= 50;
            }
            else if (this.Seviye == 10)
            {
                this.Timer.Stop();
                this.OyunBitti = true;                
                MessageBox.Show("Kazandiniz");                               
            }
        }
    }
}
