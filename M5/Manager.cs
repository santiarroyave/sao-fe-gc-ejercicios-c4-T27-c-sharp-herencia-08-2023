using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Manager : Empleat
    {
        //- Manager: cobren un 10 % més del seu salari mensual.
        double percentatge = 0.1;
        public Manager() { }

        public override void AfegirSalari(double salari)
        {
            this.salari = salari + (salari * percentatge);
        }
    }
}
