using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Volunteer : Empleat
    {
        //- Volunteer: no cobren
        double percentatge = -1;
        const int DEF_SOU_MINIM = 0;
        const int DEF_SOU_MAXIM = 0;
        public Volunteer() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM, DEF_SOU_MAXIM);
        }
        public void ValidarSou(int souMinim = DEF_SOU_MINIM, int souMaxim = DEF_SOU_MAXIM)
        {
            //  • Volunteer: S'ha de validar que no cobra.
            base.ValidarSou(souMinim, souMaxim);
        }
    }
}
