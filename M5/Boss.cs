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
        public Boss() { }

        public override void AfegirSalari(double salari)
        {
            this.salari = salari + (salari * percentatge);
        }
    }
}
