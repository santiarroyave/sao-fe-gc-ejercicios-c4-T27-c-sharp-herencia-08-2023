using System.Drawing;
using System.Text.RegularExpressions;

namespace M6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Volem fer un software per un taller de vehicles, que en aquest moment té motos i cotxes. Els cotxes sempre tindran quatre rodes i les motos dues.

            //MILESTONE 1
            //FASE 1:
            //S’ha de crear un projecte, C# de consola, amb les funcionalitats demanades per tal que el software funcione correctament.

            //Ens demanen crear un metode Main que realitzi els següents passos:
            //  1) Demanar a l’usuari la matrícula del cotxe, la marca i el seu color.
            //  2) Crear el cotxe amb les dades anteriors.
            //  3) Afegir-li dues rodes traseres demanant a l’usuari la marca i el diametre.
            //  4) Afegir-li dues rodes davanteres demanant a l’usuari la marca i el diametre.

            var (matricula, marca, color) = DemanarDadesCotxe();
            Cotxe cotxe1 = new Cotxe(matricula, marca, color);
            cotxe1.AfegirRodesDavanteres();
            cotxe1.AfegirRodesTraseres();

            cotxe1.ToString();
        }

        public static (string Matricula, string Marca, string Color) DemanarDadesCotxe()
        {
            Console.WriteLine("Ingressa la matrícula del cotxe:");
            string matricula = Console.ReadLine();

            Console.WriteLine("Ingressa la marca:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingressa el color:");
            string color = Console.ReadLine();

            return (matricula, marca, color);
        }
    }
}