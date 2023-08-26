using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal abstract class Empleat
    {
        protected double salari;
        private const int DEF_SALARI = 0;

        public Empleat()
        {
            salari = DEF_SALARI;
        }

        public abstract void AfegirSalari(double salari);

        public void MostrarSalari()
        {
            Console.WriteLine("El salari del {0} es de {1} euros", GetType().Name, salari);
        }
    }
}
