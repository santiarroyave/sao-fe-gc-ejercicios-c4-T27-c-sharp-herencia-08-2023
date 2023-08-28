﻿using System;
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

        int souMaxim = 20;
        public Manager() { }

        public override void AfegirSalari(double salari)
        {
            double salariAmbPercent = salari + (salari * percentatge);
            ValidarPerAfegir(salariAmbPercent, DEF_SOU_MINIM, DEF_SOU_MAXIM);
        }

        public void ValidarSou(int souMinim = DEF_SOU_MINIM, int souMaxim = DEF_SOU_MAXIM)
        {
            //  • Manager: Ha de cobrar més de 3000 però menys de 5000€
            base.ValidarSou(souMinim, souMaxim);
        }
    }
}
