using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Armas
{
    [XmlInclude(typeof(ArmaDeFuego))]
    [XmlInclude(typeof(Cuchillo))]
    public class Arma
    {
        public enum ETipoArma
        {
            Desert_Eagle = 0,
            Ak_47 = 1,
            Karambit = 2,
            Bayoneta = 3
        }

        public enum ECalidadArma
        {
            Azul = 0,
            Violeta = 1,
            Rosa = 2,
            Roja = 3,
            Amarilla = 4
        }

        public static List<Arma> armas;
        ETipoArma nombreArma;
        ECalidadArma calidadArma;
        string nombreSkin;
        double precio;

        public Arma()
        {
        }

        public Arma(ETipoArma nombreArma, ECalidadArma calidadArma, string nombreSkin, double precio) : this()
        {
            this.nombreArma = nombreArma;
            this.calidadArma = calidadArma;
            this.nombreSkin = nombreSkin;
            this.precio = precio;
        }

        public static void AgregarArma(Arma arma)
        {
            armas = new List<Arma>();
            armas.Add(arma);
        }

        public ECalidadArma TipoCalidad
        {
            get
            {
                return calidadArma;
            }
            set
            {
                this.calidadArma = value;
            }
        }

        public ETipoArma TipoArma
        {
            get
            {
                return nombreArma;
            }
            set
            {
                this.nombreArma = value;
            }
        }

        public string NombreSkin
        {
            get { return nombreSkin; }
            set { nombreSkin = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public override string ToString()
        {
            return  this.nombreArma + " | " + this.nombreSkin + " | " + this.calidadArma + " - " + this.precio;
        }
    }
}
