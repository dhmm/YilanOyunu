using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YilanOyunu.Kutuphane
{
    public interface IKutu
    {
        int X { set; get; }
        int Y { set; get; }
        IKutu OncekiKutu { set; get; }
        IKutu SonrakiKutu { set; get; }
        bool Yerlestirildi { set; get; }

        void Ilerle();
        void YonDegistir(int yon);        
        int HangiYon();
    }
}
