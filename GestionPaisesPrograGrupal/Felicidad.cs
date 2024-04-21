using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class Felicidad
    {
        public int FelicidadN { get; set; }
        public int VariantFelicidad { get; set; }

        public virtual int GetHappy()
        {
            return FelicidadN;
        }

        public virtual int GetVariationFelicidad()
        {
            return VariantFelicidad;
        }

        public void AffectHappiness(int gastoSeguridad)
        {
            if (gastoSeguridad < 20)
            {
                FelicidadN -= 10;
            }
        }
    }
}
