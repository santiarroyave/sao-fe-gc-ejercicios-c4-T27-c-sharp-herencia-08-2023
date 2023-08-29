using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal class Cotxe : Vehicles
    {
        Rodes rodesDavanteres;
        Rodes rodesTraseres;

        public Cotxe(string matricula, string marca, string color) :base(matricula, marca, color) { }

        public void AfegirRodesDavanteres()
        {
            Console.WriteLine("\nEstàs seleccionant les rodes davanteres");
            Console.Write("Indica la marca: ");
            string marca = Console.ReadLine();

            double diametre = VerificarDiametre();

            rodesDavanteres = new Rodes(marca, diametre);
        }

        public void AfegirRodesTraseres()
        {
            Console.WriteLine("\nEstàs seleccionant les rodes traseres");
            Console.Write("Indica la marca: ");
            string marca = Console.ReadLine();
            
            double diametre = VerificarDiametre();

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
}
