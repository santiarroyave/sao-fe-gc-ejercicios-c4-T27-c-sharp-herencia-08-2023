using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Mid : Empleat
    {
        //Aquest empleat te una reducció del: 10%.
        double percentatge = -0.1;
        const int DEF_SOU_MINIM = 1800;
        const int DEF_SOU_MAXIM = 2500;
        public Mid() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM, DEF_SOU_MAXIM);
        }
        public void ValidarSou(int souMinim = DEF_SOU_MINIM, int souMaxim = DEF_SOU_MAXIM)
        {
            //  • Mid: Ha de cobrar més de 1800 pero menys de 2500€
            base.ValidarSou(souMinim, souMaxim);
        }
    }
}
