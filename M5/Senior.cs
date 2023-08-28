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
            salari += (salari * percentatge);
            string estat = ValidarSalari(salari, DEF_SOU_MINIM, DEF_SOU_MAXIM);

            Console.WriteLine("{0}:\n- Nou salari {1} EUR (inclòs {2}%). Mínim: {3} EUR. Màxim: {4} EUR. Estat: {5}",
                GetType().Name,
                salari, percentatge * 100,
                DEF_SOU_MINIM,
                DEF_SOU_MAXIM,
                estat);
        }
    }
}
