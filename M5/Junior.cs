using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Junior : Empleat
    {
        //Aquest empleat te una reducció del: 15%.
        double percentatge = -0.15;
        const int DEF_SOU_MINIM = 900;
        const int DEF_SOU_MAXIM = 1600;
        public Junior() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM, DEF_SOU_MAXIM);
        }
        public void ValidarSou(int souMinim = DEF_SOU_MINIM, int souMaxim = DEF_SOU_MAXIM)
        {
            //  • Junior: Ha de cobrar més de 900 pero menys de 1600€
            base.ValidarSou(souMinim, souMaxim);
        }
    }
}
