namespace Armas
{
    public class Cuchillo : Arma
    {
        public Cuchillo()
        {
        }

        public Cuchillo(ETipoArma nombreArma, string nombreSkin, double precio) : base(nombreArma,ECalidadArma.Amarilla, nombreSkin, precio)
        {
        }
    }
}
