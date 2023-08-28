using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5
{
    internal class Manager : Empleat
    {
        //- Manager: cobren un 10 % més del seu salari mensual.
        double percentatge = 0.1;
        const int DEF_SOU_MINIM = 3000;
        const int DEF_SOU_MAXIM = 5000;

        double irpf = 0.26;

        int souMaxim = 20;
        public Manager() { }

        public override void AfegirSalari(double salari)
        {
            salari += (salari * percentatge);
            string estat = ValidarSalari(salari, DEF_SOU_MINIM, DEF_SOU_MAXIM);

            Console.WriteLine("{0}:\n- Nou salari {1} EUR (inclòs {2}%). Mínim: {3} EUR. Màxim: {4} EUR. Estat: {5}", 
                GetType().Name, 
                salari, percentatge * 100, 
                DEF_SOU_MINIM, 
                DEF_SOU_MAXIM, 
                estat);

            souBrutMensual = salari;
            souNetMensual = salari - (salari * irpf);
            souBrutAnual = souBrutMensual * 12;
            souNetAnual = souNetMensual * 12;
            Console.WriteLine("- Sou anual: [Brut: {0} EUR], [Net: {1} EUR]\n- Sou mensual: [Brut: {2} EUR], [Net: {3} EUR]\n- IRPF: {4} %", 
                souBrutAnual, 
                souNetAnual, 
                souBrutMensual,
                souNetMensual, 
                irpf * 100);

            Console.WriteLine();
        }
    }
}
