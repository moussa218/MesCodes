using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compte_Bancaire
{
    class CompteCourant : CompteEpargne
    {
        public int decouvert { get; set; }
    }
}
