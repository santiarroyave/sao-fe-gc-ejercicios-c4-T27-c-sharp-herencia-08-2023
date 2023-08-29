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

        private double VerificarDiametre()
        {
            //2) Un diametre de la roda ha de ser superior a 0.4 i inferior a 4
            double diametre;
            string diametreText;
            Console.Write("Indica el diàmetre: ");

            while (true)
            {
                try
                {
                    diametreText = Console.ReadLine();

                    // Convierte puntos a comas
                    diametreText = diametreText.Replace('.', ',');

                    // Convierte texto a double
                    diametre = double.Parse(diametreText);


                    if (diametre >= 0.4 && diametre <= 4)
                    {
                        return diametre;
                    }

                    Console.WriteLine("Diàmetre incorrecte: ha de ser superior a 0.4 i inferior a 4");
                }
                catch
                {
                    Console.WriteLine("Valor incorrecte: ha de ser superior a 0.4 i inferior a 4");
                }

                Console.Write("Torna-ho a intentar: ");
            }
        }
    }
}
