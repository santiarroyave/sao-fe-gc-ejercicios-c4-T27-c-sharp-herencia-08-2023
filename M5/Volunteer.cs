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
        public Volunteer() { }

        public override void AfegirSalari(double salari)
        {
            this.salari = salari + (salari * percentatge);
        }
    }
}
