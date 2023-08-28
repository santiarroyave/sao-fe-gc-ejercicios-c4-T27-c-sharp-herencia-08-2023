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
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM);
        }
    }
}
