using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace M6
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //FASE 2:
            //Millorar el codi anterior comprovant la informació necesaria alhora de crear els objectes. S’ha de tenir en compte:
            //1) Una matrícula ha de tenir 4 números i dues o tres lletres.
            //2) Un diametre de la roda ha de ser superior a 0.4 i inferior a 4
        }

        public static (string Matricula, string Marca, string Color) DemanarDadesCotxe()
        {
            string matricula = IngresarMatricula();

            Console.Write("Ingressa la marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingressa el color: ");
            string color = Console.ReadLine();

            return (matricula, marca, color);
        }

        // Esta funcion se encarga de filtrar de que la matricula introducida sea válida
        public static string IngresarMatricula()
        {
            string matricula = "";
            bool matriculaValida = false;

            Console.Write("Ingressa la matrícula del cotxe: ");

            while (matriculaValida == false)
            {
                matricula = Console.ReadLine();

                if (VerificarMatricula(matricula) == true)
                {
                    return matricula;
                }
                else
                {
                    Console.WriteLine("Matricula invàlida, ha de tenir 4 números i 2 o 3 lletres:");
                    Console.Write("Torna-ho a intentar: ");
                }
            }

            return matricula;
        }

        public static bool VerificarMatricula(string matricula)
        {
            //1) Una matrícula ha de tenir 4 números i dues o tres lletres.
            int contadorNumeros = 0;
            int contadorLetras = 0;

            foreach (char digit in matricula)
            {
                if (char.IsDigit(digit))
                {
                    contadorNumeros++;
                }
                else if (char.IsLetter(digit))
                {
                    contadorLetras++;
                }
            }
            
            if (contadorNumeros == 4 && (contadorLetras == 2 || contadorLetras == 3))
            {
                return true;
            }

            return false;
        }
    }
}