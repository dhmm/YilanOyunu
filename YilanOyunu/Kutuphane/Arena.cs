using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace YilanOyunu.Kutuphane
{
    public class Arena
    {
        internal Oyun Oyun { set; get; }
        internal bool YilanCarpti { set; get; }

        int Genislik { set; get; }
        int Yukseklik { set; get; }        
        internal int SatirSayisi { set; get; }
        internal int SutunSayisi { set; get; }
        internal int KutuYukseklik { set; get; }
        internal int KutuGenislik { set; get; }

        internal Panel PnlArena {set;get;}
        internal Panel PnlTemplate { set; get; }
        internal int[,] Tablo { set; get; }        
        Yilan Yilan { set; get; }

        public Arena(Oyun oyun, Panel pnlArena, Panel pnlTemplate)
        {
            this.Oyun = oyun;
            YilanCarpti = false;
            ArenaBilgisiOku(pnlArena);
            TemplateBilgisiOku(pnlTemplate);
            SatirSutunHesapla();
            ArenaTablosuOlustur();
            this.Yilan = new Yilan(this,this.PnlTemplate);
            YilaniYerlestir();
        }
        public void YilanYemiYedi()
        {
            this.Yilan.YemYe();
            this.Oyun.YemYendi();

        }
        public void Ilerle()
        {
            if (this.YilanCarpti == false)
            {
                this.Yilan.Ilerle();                
            }           
        }
        public void YonDegistir(int yon)
        {
            this.Yilan.YonDegistir(yon);
        }       
        private void ArenaBilgisiOku(Panel pnlArena)
        {
            this.PnlArena = pnlArena;
            this.Genislik = this.PnlArena.Width;
            this.Yukseklik = this.PnlArena.Height;                        
        }
        private void TemplateBilgisiOku(Panel pnlTemplate)
        {
            this.PnlTemplate = pnlTemplate;
            this.KutuGenislik = pnlTemplate.Width;
            this.KutuYukseklik = pnlTemplate.Height;
        }
        private void SatirSutunHesapla()
        {
            this.SatirSayisi = this.Yukseklik / this.KutuYukseklik;
            this.SutunSayisi = this.Genislik / this.KutuGenislik;
        }
        private void ArenaTablosuOlustur()
        {
            Tablo = new int[this.SatirSayisi,this.SutunSayisi];            
        }
        private void YilaniYerlestir()
        {
            int X = SatirSayisi / 2;
            int Y = SutunSayisi / 2;
            Yilan.Yerles(X, Y);
        }
    }
}
