using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6
{
    internal class Persona
    {
        //Crea dos classes: Titular de Vehicle i Conductor (també fes una classe Persona com a herència).
        //El conductor ha de tenir, nom, cognoms, data de naixement i llicencia de conduir. Aquest ultima també serà una classe a part que tindrà: ID, tipus de llicència, nom complet i data de caducitat. El Titular ha de tenir els mateixos valors que el conductor, però també s'ha de registrar si té assegurança i garatge propi

        protected string nom;
        protected string cognoms;
        protected DateTime dataNaixement;

        protected Persona(string nom, string cognom, DateTime datNaixement)
        {
            this.nom = nom;
            this.cognoms = cognom;
            this.dataNaixement = datNaixement;
        }
    }

    internal class Conductor : Persona
    {
        public Conductor(string nom, string cognom, DateTime datNaixement) :base(nom, cognom, datNaixement) { } 
    } 

    internal class Titular : Persona
    {
        bool asseguranca;
        bool garatgePropi;

        public Titular(string nom, string cognom, DateTime datNaixement, bool asseguranca, bool garatgePropi) : base(nom, cognom, datNaixement) { }

    }

    internal class Llicencia
    {
        int id;
        string tipus;
        string nomComplet;
        DateTime dataCaducitat;
    }
}
