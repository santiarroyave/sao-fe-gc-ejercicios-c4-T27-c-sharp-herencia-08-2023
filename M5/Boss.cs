using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Boss : Empleat
    {
        //-Boss: cobren un 50 % més del seu salari mensual.
        double percentatge = 0.5;
        //-Boss: Ha de cobrar més de 8000€
        const int DEF_SOU_MINIM = 8000;
        public Boss() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM);
        }
    }
}
