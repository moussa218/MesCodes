using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compte_Bancaire
{
    class CompteCredit : CompteEpargne
    {
        public int duree { get; set; }
        public DateTime dateTerme { get; set; }
    }
}
