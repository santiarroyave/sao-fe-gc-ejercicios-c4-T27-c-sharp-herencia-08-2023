using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal class Vehicles
    {
        int quntitatRodes;
    }

    internal class Moto : Vehicles
    {
        const int DEF_QUANT_RODES = 2;
        //public Motos()
        //{

        //}
    }

    internal class Cotxe : Vehicles
    {
        const int DEF_QUANT_RODES = 4;

        string matricula;
        string marca;
        string color;
        Rodes rodesDavanteres;
        Rodes rodesTraseres;

        public Cotxe(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        public void AfegirRodesDavanteres()
        {
            Console.WriteLine("\nEstàs seleccionant les rodes davanteres");
            Console.WriteLine("Indica la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Indica el diàmetre:");
            int diametre = int.Parse(Console.ReadLine());

            rodesDavanteres = new Rodes(marca, diametre);
        }

        public void AfegirRodesTraseres()
        {
            Console.WriteLine("\nEstàs seleccionant les rodes traseres");
            Console.WriteLine("Indica la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Indica el diàmetre:");
            int diametre = int.Parse(Console.ReadLine());

            rodesTraseres = new Rodes(marca, diametre);
        }

        public void ToString()
        {
            Console.WriteLine("\nInformació del cotxe:");
            Console.WriteLine("- Matricula: {0}", matricula);
            Console.WriteLine("- Marca: {0}", marca);
            Console.WriteLine("- Color: {0}", color);
            Console.WriteLine("- Rodes davanteres: {0}", rodesDavanteres.ToString());
            Console.WriteLine("- Rodes traseres: {0}", rodesTraseres.ToString());
        }

    }

    internal class Rodes
    {
        string marca;
        int diametre;

        public Rodes(string marca, int diametre)
        {
            this.marca = marca;
            this.diametre = diametre;
        }

        public string ToString()
        {
            return string.Format("Rodes {0} de diàmetre {1} cm de diàmetre.", marca, diametre);
        }
    }
}
