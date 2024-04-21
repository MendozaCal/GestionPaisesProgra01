using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class StateBase
    {
        public string Name { get; set; }
        public virtual int GetPeople()
        {
            return 0;
        }
        public virtual float GetMoney()
        {
            return 0;
        }
        public virtual int GetHappy()
        {
            return 0;
        }
        public virtual int GetVariationFelecidad()
        {
            return 0;
        }
        public virtual int GetVariationMoney()
        {
            return 0;
        }
    }
}
