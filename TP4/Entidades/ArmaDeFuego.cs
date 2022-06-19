using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArmaDeFuego : Arma
    {
        double floatSkin;

        public ArmaDeFuego()
        {
        }

        public ArmaDeFuego(ETipoArma tipoArma, ECalidadArma calidadArma, string nombreSkin, double precio, double floatSkin) 
            : base(tipoArma, calidadArma, nombreSkin, precio)
        {
            this.floatSkin = floatSkin;
        }
    }
}
