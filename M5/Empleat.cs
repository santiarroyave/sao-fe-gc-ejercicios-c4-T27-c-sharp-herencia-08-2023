using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal abstract class Empleat
    {
        protected double salari;
        protected int souMinim;

        private const int DEF_SALARI = 0;

        public Empleat()
        {
            salari = DEF_SALARI;
        }

        public abstract void AfegirSalari(double salari);

        public void MostrarSalari()
        {
            Console.WriteLine("El salari del {0} es de {1} euros.", GetType().Name, salari);
        }


        // Este metodo lo utilizan las clases derivadas para verificar si el sueldo es correcto y en ese caso guardarlo.
        protected void ValidarPerAfegir(double salariAmbPercent, int minim, int? maxim = null)
        {
            try
            {
                // Valida salari abans d'afegir
                if (SalariEsValid(salariAmbPercent, minim, maxim))
                {
                    salari = salariAmbPercent;
                    Console.WriteLine("El salari del ({0}) s'ha afegit correctament.", GetType().Name);
                    Console.WriteLine("- Amb el percentatge s'ha modificat a {0} euros.", salariAmbPercent);
                }
                else
                {
                    throw new Exception(string.Format("El ({0}) no pot tenir aquest salari.", GetType().Name));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }
            Console.WriteLine();
        }

        protected bool SalariEsValid(double salariAmbPercent, int minim, int? maxim = null)
        {
            bool valid = false;
            try
            {
                // Valida entre Minim i Maxim
                if (salariAmbPercent > minim && salariAmbPercent < maxim)
                {
                    valid = true;
                }

                // Valida superior a Minim
                if (salariAmbPercent > minim && maxim == null)
                {
                    valid = true;
                }

                // Valida que no cobra res
                if (minim == 0 && maxim == 0)
                {
                    if (salariAmbPercent == 0)
                    {
                        valid = true;
                    }
                }

                // Error en el limits de sou
                if (minim > maxim)
                {
                    throw new Exception("El Mínim es superior al Máxim");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("|- ERROR: {0}", ex.Message);
            }

            // Devuelve boleano
            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validar sueldo: Muestra por pantalla / No devuelve valor
        protected void ValidarSou(int minim, int? maxim = null)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Validant {0}", GetType().Name);

            bool valid = false;

            // Missatges
            string missatgeSouActual = string.Format("|- Sou actual: {0} euros.", salari);
            string missatgeSouMinim = string.Format("|- Sou mínim: {0} euros.", minim);
            string missatgeSouMaxim = string.Format("|- Sou màxim: {0} euros.", maxim);
            string missatgeNoTeMaxim = "|- No té limitació màxima.";
            string missatgeCorrecte = "|- Sou correcte.";
            string missatgeIncorrecte = "|- ATENCIÓ: Aquest empleat no cobra el que hauria de cobrar.";

            // Mostrar missatges informatius de sou (sou, sou minim, sou maxim)
            Console.WriteLine(missatgeSouActual);
            Console.WriteLine(missatgeSouMinim);
            Console.WriteLine((maxim == null) ? missatgeNoTeMaxim : missatgeSouMaxim);

            try
            {
                // Valida entre Minim i Maxim
                if (salari > minim && salari < maxim)
                {
                    valid = true;
                }

                // Valida superior a Minim
                if (salari > minim && maxim == null)
                {
                    valid = true;
                }

                // Valida que no cobra res
                if (minim == 0 && maxim == 0)
                {
                    if (salari == 0)
                    {
                        valid = true;
                    }
                }

                // Error en el limits de sou
                if (minim > maxim)
                {
                    throw new Exception("El Mínim es superior al Máxim");
                }

                Console.WriteLine((valid == true) ? missatgeCorrecte : missatgeIncorrecte);
            }
            catch(Exception ex)
            {
                Console.WriteLine("|- ERROR: {0}", ex.Message);
            }
        }
    }
}
