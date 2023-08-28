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
            salari += (salari * percentatge);
            string estat = ValidarSalari(salari, DEF_SOU_MINIM, DEF_SOU_MAXIM);

            Console.WriteLine("{0}:\n- Nou salari {1} EUR. Màxim: {4} EUR. Estat: {5}",
                GetType().Name,
                salari, percentatge * 100,
                DEF_SOU_MINIM,
                DEF_SOU_MAXIM,
                estat);
        }
    }
}
