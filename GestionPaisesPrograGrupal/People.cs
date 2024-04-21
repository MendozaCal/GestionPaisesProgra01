using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class People
    {
        public int Population { get; set; }
        public virtual int GetPeople()
        {
            return Population;
        }
        public void AffectPopulation(int gastoSalud)
        {
            if (gastoSalud < 20)
            {
                Population -= (int)(Population * 0.1);
            }
            else if (gastoSalud > 80)
            {
                Population += (int)(Population * 0.1);
            }
        }
    }
}
