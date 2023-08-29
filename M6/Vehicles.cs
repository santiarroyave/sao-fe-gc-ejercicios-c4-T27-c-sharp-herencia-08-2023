using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal abstract class Vehicles
    {
        protected string matricula;
        protected string marca;
        protected string color;

        public Vehicles(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        protected double VerificarDiametre()
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
