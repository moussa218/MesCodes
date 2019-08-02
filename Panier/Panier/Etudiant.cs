using System;

namespace Panier
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public char Sexe { get; set; }
        public bool Serieux { get; set; }

        public int Age => DateTime.Now.Subtract(DateNaissance).Days / 365;
    }
}
