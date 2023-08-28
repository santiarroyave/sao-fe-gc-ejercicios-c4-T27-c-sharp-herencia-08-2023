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

        protected double souBrutMensual;
        protected double souNetMensual;
        protected double souBrutAnual;
        protected double souNetAnual;

        public Empleat()
        {
            salari = DEF_SALARI;
        }

        public abstract void AfegirSalari(double salari);

        public void MostrarSalari()
        {
            Console.WriteLine("El salari del {0} es de {1} euros.", GetType().Name, salari);
        }

        protected string ValidarSalari(double salari, int minim, int? maxim = null)
        {
            bool valid = false;
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

                    throw new Exception("El salari Mínim es superior al salari Máxim");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR ({0}) : {1}: ", GetType().Name, ex.Message);
            }

            // Devuelve boleano
            if (valid)
            {
                return "Sou vàlid.";
            }
            else
            {
                return "El sou no es vàlid.";
            }
        }

        public void Bonus()
        {
            double bonusPercent = 0.1;
            double bonusAnual = souBrutAnual * bonusPercent;
            salari += bonusAnual / 12 ;


            Console.WriteLine("{0}: Bonus del {1} % anual afegit. Total: {2} EUR anuals.", GetType().Name, bonusPercent * 100, bonusAnual);
        }
    }
}
