using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armas
{
    public class ArmaDeFuego : Arma
    {
        double floatSkin;
        public ArmaDeFuego()
        {
        }

        public ArmaDeFuego(ETipoArma tipoArma, ECalidadArma calidadArma, string nombreSkin, double floatSkin, double precio) 
            : base(tipoArma, calidadArma, nombreSkin, precio)
        {
            this.floatSkin = floatSkin;
        }
    }
}
