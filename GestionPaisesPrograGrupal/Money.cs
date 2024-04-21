using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class Money : StateBase
    {
        public int Moneyy { get; set; }
        public int VariantMoneyy { get; set; }

        public virtual int GetMoney()
        {
            return Moneyy;
        }
        public virtual int GetVariationMoney()
        {
            return VariantMoneyy;
        }
    }
}
