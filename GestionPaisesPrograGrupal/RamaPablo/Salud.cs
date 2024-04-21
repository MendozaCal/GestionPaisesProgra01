using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class Salud: Servicios
    {
        float price;
        int variation;
        public Salud(string name, float price, int variation)
        {
            this.name = name;
            this.price = price;
            this.variation = variation;
        }
        public override float GetPrice()
        {
            return price;
        }
        public override int GetVariationSalud()
        {
            return variation;
        }
    }
}
