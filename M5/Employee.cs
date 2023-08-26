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
        public Employee() { }

        public override void AfegirSalari(double salari)
        {
            this.salari = salari + (salari * percentatge);
        }
    }
}
