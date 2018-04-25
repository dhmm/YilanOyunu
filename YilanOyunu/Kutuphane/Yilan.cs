using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace YilanOyunu.Kutuphane
{
    public class Yilan
    {
        Arena Arena;
        Panel PnlTemplate { set; get; }
        internal List<Kutu> Kutular { set; get; }
        Kutu LiderKutu { set; get; }
        
        
        public bool DonebilirMi { set; get; }

        public Yilan(Arena arena , Panel pnltemplate)
        {
            this.Arena = arena;
            this.PnlTemplate = pnltemplate;
            this.YeniOlustur(arena.Tablo);
            this.DonebilirMi = true;            
        }
        public void Yerles(int x, int y)
        {            
            for(int i=0;i<this.Kutular.Count();i++)
            {
                Kutu kutu = Kutular[i];
                kutu.KutuTasi(x, y+i);
                this.Arena.PnlArena.Controls.Add(kutu.PnlKutu);
                
            }            
        }
        public void YemYe()
        {            
            Kutu kutu = new Kutu(this.PnlTemplate, this.Arena, this.Kutular.Last().HangiYon());
            if (YeniKutuYerlestir(kutu))
            {
                this.Kutular.Add(kutu);
                this.Arena.PnlArena.Controls.Add(kutu.PnlKutu);
                this.Arena.Tablo[kutu.X, kutu.Y] = 0;
            }
            else
            {
                this.Kutular.Add(kutu);                
                this.Arena.PnlArena.Controls.Add(kutu.PnlKutu);
                this.Arena.Tablo[this.Arena.Oyun.Yem.X, this.Arena.Oyun.Yem.Y] = 0;             
            }            
        }
        public void Ilerle()
        {            
            this.LiderKutu.Ilerle();
            if (this.Arena.YilanCarpti)
            {
                foreach (Kutu kutu in this.Kutular)
                {
                    kutu.PnlKutu.BackColor = Color.Red;
                }
            }
            this.DonebilirMi = true;
            
        }
        public void YonDegistir(int yon)
        {
            if (this.DonebilirMi)
            {
                this.LiderKutu.YonDegistir(yon);
                this.DonebilirMi = false;
            }
        }

        private void YeniOlustur(int[,] tablo)
        {
            this.Kutular = new List<Kutu>();
            for (int i = 0; i < 3; i++)
            {
                Kutu kutu = new Kutu(this.PnlTemplate,this.Arena);                
                if (LiderKutu == null)
                {
                    kutu.OncekiKutu = null;                   
                    LiderKutu = kutu;                    
                }
                else
                {
                    this.Kutular[i - 1].SonrakiKutu = kutu;
                    kutu.OncekiKutu = this.Kutular[i - 1];
                    kutu.SonrakiKutu = null;
                }
                this.Kutular.Add(kutu);
            }
        }
        private bool YeniKutuYerlestir(Kutu kutu)
        {
            bool yerlestirildi = true;
            this.Kutular.Last().SonrakiKutu = kutu;
            kutu.OncekiKutu = this.Kutular.Last();
            kutu.SonrakiKutu = null;
            switch (kutu.OncekiKutu.HangiYon())
            {
                case Yonler.YUKARI:
                    if (!kutu.KutuTasi(kutu.OncekiKutu.X, kutu.OncekiKutu.Y + 1))
                    {                        
                        yerlestirildi = false;
                    }
                    break;
                case Yonler.ASAGI:
                    if (!kutu.KutuTasi(kutu.OncekiKutu.X, kutu.OncekiKutu.Y - 1))
                    {                        
                        yerlestirildi = false;
                    }
                    break;
                case Yonler.SAGA:
                    if (!kutu.KutuTasi(kutu.OncekiKutu.X - 1, kutu.OncekiKutu.Y))
                    {                        
                        yerlestirildi = false;
                    }
                    break;
                case Yonler.SOLA:
                    if (!kutu.KutuTasi(kutu.OncekiKutu.X + 1, kutu.OncekiKutu.Y))
                    {                        
                        yerlestirildi = false;
                    }
                    break;

            }
            return yerlestirildi;
        }
    }
}
