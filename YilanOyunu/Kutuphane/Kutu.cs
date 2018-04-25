using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace YilanOyunu.Kutuphane
{
    class Kutu : IKutu
    {
        Arena Arena { set; get; }        

        int Genislik { set; get; }
        int Yukseklik { set; get; }
        Color Renk { set; get; }
        BorderStyle BorderStili { set; get; }
        int Yon { set; get; }

        public int[,] Tablo { set; get; }
        public int X { set; get; }
        public int Y { set; get; }               
        public IKutu OncekiKutu { set; get; }
        public IKutu SonrakiKutu { set; get; }
        public bool Yerlestirildi { set; get; }

        internal Panel PnlKutu { set; get; }

        public Kutu(Panel pnlTemplate, Arena arena, int yon = Yonler.YUKARI)
        {
            this.Yon = yon;            
            this.Arena = arena;            
            this.Tablo = arena.Tablo;
            TemplateBilgisiOku(pnlTemplate);
            PanelOlustur();
            X = -1;
            Y = -1;
            this.Yerlestirildi = false;
        }
        public void Ilerle()
        {
            this.Sifirla();
            this.YeniYonDegerleriniOlustur();
            if (this.CarpmaYokMu())
            {
                if (YeminUstundeMi())
                {
                    Arena.YilanYemiYedi();

                }
                this.Tasi();
                SonrakiKutuyuIlerlet();
            }
            else
            {
                if (this.Yerlestirildi == true)
                {
                    Arena.YilanCarpti = true;
                }
            }            
        }
        public void YonDegistir(int yon)
        {
            if (TersYonMu(yon) == false)
            {
                this.Yon = yon;
            }
        }      
        public int HangiYon()
        {
            return this.Yon;
        }

        internal bool KutuTasi(int x, int y)
        {
            bool tasindi = false;
            this.X = x;
            this.Y = y;
            if (NoktaArenaninIcindeMi(x,y))
            {
                this.Sifirla();                
                this.Tasi();                
                this.Yerlestirildi = true;                     
                tasindi= true;
            }
            else
            {               
                this.PnlKutu.Visible = false;
                this.Yerlestirildi = false;
                tasindi = false;
            }            
            return tasindi;
        }

        private void TemplateBilgisiOku(Panel pnlTemplate)
        {
            this.Genislik = pnlTemplate.Width;
            this.Yukseklik = pnlTemplate.Height;
            this.Renk = pnlTemplate.BackColor;
            this.BorderStili = pnlTemplate.BorderStyle;
        }
        private void PanelOlustur()
        {
            this.PnlKutu = new Panel();
            this.PnlKutu.Width = this.Genislik;
            this.PnlKutu.Height = this.Yukseklik;
            this.PnlKutu.BackColor = this.Renk;
            this.PnlKutu.BorderStyle = this.BorderStili;
        }
        private void Tasi()
        {            
            Tablo[this.X, this.Y] = 1;
            this.PnlKutu.Left = X * this.Genislik;
            this.PnlKutu.Top = Y * this.Yukseklik;
            if (this.PnlKutu.Visible == false)
            {
                this.PnlKutu.Visible = true;
            }
            if (this.Yerlestirildi == false)
            {
                this.Yerlestirildi = true;
            }
        }
        private bool TersYonMu(int yon)
        {
            bool tersYonMu = false;
            switch (yon)
            {
                case Yonler.YUKARI:
                    tersYonMu = this.Yon == Yonler.ASAGI;
                    break;
                case Yonler.ASAGI:
                    tersYonMu = this.Yon == Yonler.YUKARI;
                    break;
                case Yonler.SAGA:
                    tersYonMu = this.Yon == Yonler.SOLA;
                    break;
                case Yonler.SOLA:
                    tersYonMu = this.Yon == Yonler.SAGA;
                    break;

            }
            return tersYonMu;
        }
        private void SonrakiKutuyuIlerlet()
        {
            if (this.SonrakiKutu != null)
            {
                this.SonrakiKutu.Ilerle();
                if (this.SonrakiKutu.HangiYon() != this.Yon)
                {
                    this.SonrakiKutu.YonDegistir(this.Yon);
                }
            }
        }
        private void Sifirla()
        {
            if (this.X > -1 && this.Y > -1 && Yerlestirildi)
            {
                Tablo[this.X, this.Y] = 0;
            }
        }
        private void YeniYonDegerleriniOlustur()
        {
            switch (this.Yon)
            {
                case Yonler.YUKARI:
                    this.Y--;
                    break;
                case Yonler.ASAGI:
                    this.Y++;
                    break;
                case Yonler.SAGA:
                    this.X++;
                    break;
                case Yonler.SOLA:
                    this.X--;
                    break;
            }
        }
        private bool CarpmaYokMu()
        {
            return
                this.X > -1 &&
                this.Y > -1 &&
                this.X < this.Arena.SatirSayisi &&
                this.Y < this.Arena.SutunSayisi &&
                Tablo[this.X, this.Y] != 1;
        }
        private bool NoktaArenaninIcindeMi(int x, int y)
        {
            return x > -1 && y > -1 && x < this.Arena.SatirSayisi && y < this.Arena.SutunSayisi;
        }
        private bool YeminUstundeMi()
        {
            return Tablo[this.X, this.Y] == 2;
        }
    }
}
