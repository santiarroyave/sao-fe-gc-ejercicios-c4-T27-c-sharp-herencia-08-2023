using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Senior : Empleat
    {
        //Aquest empleat te una reducció del: 5%.
        double percentatge = -0.05;
        const int DEF_SOU_MINIM = 2700;
        const int DEF_SOU_MAXIM = 4000;
        public Senior() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM, DEF_SOU_MAXIM);
        }

        public void ValidarSou(int souMinim = DEF_SOU_MINIM, int souMaxim = DEF_SOU_MAXIM)
        {
            //  • Senior: Ha de cobrar més de 2700 pero menys de 4000€
            base.ValidarSou(souMinim, souMaxim);
        }
    }
}
