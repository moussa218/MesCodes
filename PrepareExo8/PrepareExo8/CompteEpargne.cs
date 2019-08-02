using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareExo8
{
    class CompteEpargne
    {
        public int numero { get; set; }
        public double solde { get; set; }
        public DateTime dateOuverture { get; set; }
        public string nomcomplet { get; set; }

        public void deposer(double mnt)
        {
            if (mnt > 0)
            {
                this.solde += mnt;
            }
            
        }
        public void retirer(double mnt)
        {
            if (mnt > 0)
            {
                this.solde -= mnt;
            }

        }
    }
 
}
