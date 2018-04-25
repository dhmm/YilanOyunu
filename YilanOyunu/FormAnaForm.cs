using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YilanOyunu.Kutuphane;
using System.Diagnostics;

namespace YilanOyunu
{
    public partial class FormAnaForm : Form
    {
        //Arena Arena { set; get; }

        Oyun Oyun { set; get; }

        public FormAnaForm()
        {
            InitializeComponent();
        }
        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            this.Oyun = new Oyun(lblSkor,lblSeviye,pnlArena,pnlTemplate,timer);
        }      
        private void timer_Tick(object sender, EventArgs e)
        {
            Oyun.Ilerle();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    Oyun.YeniOyun();
                    break;
                case Keys.Up:
                    Oyun.YonDegistir(Yonler.YUKARI);
                    break;
                case Keys.Down:
                    Oyun.YonDegistir(Yonler.ASAGI);
                    break;
                case Keys.Right:
                    Oyun.YonDegistir(Yonler.SAGA);
                    break;
                case Keys.Left:
                    Oyun.YonDegistir(Yonler.SOLA);
                    break;
                case Keys.Pause:
                    Oyun.DuraklatDevamEttir();
                    break;                  
            }
            
        }

        
    }
}
