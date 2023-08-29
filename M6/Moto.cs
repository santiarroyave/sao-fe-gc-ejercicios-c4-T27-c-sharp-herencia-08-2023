using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal class Moto : Vehicles
    {
        Rodes rodaDavantera;
        Rodes rodaTrasera;

        public Moto(string matricula, string marca, string color) :base(matricula, marca, color) { }

        public void AfegirRodesDavanteres()
        {
            Console.WriteLine("\nEstàs seleccionant la roda davantera");
            Console.Write("Indica la marca: ");
            string marca = Console.ReadLine();

            double diametre = VerificarDiametre();

            rodaDavantera = new Rodes(marca, diametre);
        }

        public void AfegirRodesTraseres()
        {
            Console.WriteLine("\nEstàs seleccionant la roda trasera");
            Console.Write("Indica la marca: ");
            string marca = Console.ReadLine();

            double diametre = VerificarDiametre();

            rodaTrasera = new Rodes(marca, diametre);
        }

        public void ToString()
        {
            Console.WriteLine("\nInformació de la moto:");
            Console.WriteLine("- Matricula: {0}", matricula);
            Console.WriteLine("- Marca: {0}", marca);
            Console.WriteLine("- Color: {0}", color);
            Console.WriteLine("- Roda davantera: {0}", rodaDavantera.ToStringMoto());
            Console.WriteLine("- Roda trasera: {0}", rodaTrasera.ToStringMoto());
        }
    }
}
