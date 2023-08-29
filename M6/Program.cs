using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
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


            //FASE 2:
            //Millorar el codi anterior comprovant la informació necesaria alhora de crear els objectes. S’ha de tenir en compte:
            //1) Una matrícula ha de tenir 4 números i dues o tres lletres.
            //2) Un diametre de la roda ha de ser superior a 0.4 i inferior a 4


            //FASE 3:
            //Modifica el projecte anterior afegint els mètodes necessaris a Bike, de manera que es pugui afegir rodes davanteres i traseres.

            //Modificar el Main anterior, afegint la opció de Bike o Car:
            //  0) Preguntar a l’usuari si vol crear un cotxe o una moto.
            //  1) Demanar a l’usuari la matrícula, la marca i el seu color.
            //  2) Crear el vehícle amb les dades anteriors.
            //  3) Afegir - li les rodes traseres corresponents, demanant a l’usuari la marca i el diametre.
            //  4) Afegir - li les rodes davanteres corresponents, demanant a l’usuari la marca i el diametre.

            IniciarPrograma();
        }

        public static void IniciarPrograma()
        {
            while (true)
            {
                Console.WriteLine("Indica quin vehicle vols crear:");
                Console.WriteLine("1. Cotxe");
                Console.WriteLine("2. Moto");

                try
                {
                    int num = int.Parse(Console.ReadLine());

                    switch (num) {
                        case 1:
                            Console.Clear();
                            CrearCotxe();
                            break;
                        case 2:
                            Console.Clear();
                            CrearMoto();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Número no vàlid. Torna-ho a intentar.\n");
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Has de escriure un número vàlid!\n");
                }
            }
        }

        public static void CrearCotxe()
        {
            var (matricula, marca, color) = DemanarDadesBasiques();
            Cotxe cotxe1 = new Cotxe(matricula, marca, color);

            cotxe1.AfegirRodesDavanteres();
            cotxe1.AfegirRodesTraseres();

            cotxe1.ToString();

            Console.ReadLine();
            Console.Clear();
        }

        public static void CrearMoto()
        {
            var (matricula, marca, color) = DemanarDadesBasiques();
            Moto moto1 = new Moto(matricula, marca, color);

            moto1.AfegirRodesDavanteres();
            moto1.AfegirRodesTraseres();

            moto1.ToString();

            Console.ReadLine();
            Console.Clear();
        }

        public static (string Matricula, string Marca, string Color) DemanarDadesBasiques()
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

            Console.Write("Ingressa la matrícula: ");

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