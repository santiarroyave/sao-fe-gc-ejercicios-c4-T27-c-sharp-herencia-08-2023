using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Employee : Empleat
    {
        //Employee: cobren el sou mensual aplicant una reducció del 15 %
        double percentatge = -0.15;
        const int DEF_SOU_MINIM = 0;
        public Employee() { }

        public override void AfegirSalari(double salari)
        {
            salari += (salari * percentatge);
            string estat = ValidarSalari(salari, DEF_SOU_MINIM);

            Console.WriteLine("{0}:\n- Nou salari {1} EUR (inclòs {2}%).",
                GetType().Name,
                salari,
                percentatge * 100,
                DEF_SOU_MINIM,
                estat);
        }
    }
}
