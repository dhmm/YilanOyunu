using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace YilanOyunu.Kutuphane
{
    public class Yem
    {
        internal int X { set; get; }
        internal int Y { set; get; }
        internal Panel panel = new Panel();

        public Yem()
        {
            panel = new Panel();
        }
        internal void ArenadaGoster(Arena arena)
        {
            this.panel.Width = arena.PnlTemplate.Width;
            this.panel.Height = arena.PnlTemplate.Height;
            this.panel.BackColor = Color.Yellow;
            this.panel.Left = this.X * arena.KutuGenislik;
            this.panel.Top = this.Y * arena.KutuYukseklik;
            arena.Tablo[this.X, this.Y] = 2;
            arena.PnlArena.Controls.Add(this.panel);
        }
    }
}
