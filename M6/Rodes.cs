using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal class Rodes
    {
        string marca;
        double diametre;

        public Rodes(string marca, double diametre)
        {
            this.marca = marca;
            this.diametre = diametre;
        }

        public string ToString()
        {
            return string.Format("Rodes {0} de {1} cm de diàmetre.", marca, diametre);
        }

        public string ToStringMoto()
        {
            return string.Format("Roda {0} de {1} cm de diàmetre.", marca, diametre);
        }
    }
}
