using System;

namespace Entidades
{
    public class Venta
    {
        //Hora y Fecha
        //Datos del cliente (dni, nombre y apellido)
        //Datos de la skin (tipo/nombreArma, calidadArma, nombreSkin, precio)

        int dni;
        string nombre;
        string apellido;
        string nombreTipoArma;
        string calidadArma;
        string nombreSkin;
        double precio;
        DateTime fechaYHora;

        public Venta()
        {

        }

        public Venta(int dni, string nombre, string apellido, string nombreTipoArma, string calidadArma, string nombreSkin, double precio, DateTime fechaYHora)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreTipoArma = nombreTipoArma;
            this.calidadArma = calidadArma;
            this.nombreSkin = nombreSkin;
            this.precio = precio;
            this.fechaYHora = fechaYHora;
        }

        public DateTime FechaYHora
        {
            get
            {
                return fechaYHora;
            }
            set
            {
                fechaYHora = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string NombreTipoArma
        {
            get
            {
                return nombreTipoArma;
            }
            set
            {
                nombreTipoArma = value;
            }
        }

        public string CalidarArma
        {
            get
            {
                return calidadArma;
            }
            set
            {
                calidadArma = value;
            }
        }

        public string NombreSkin
        {
            get
            {
                return nombreSkin;
            }
            set
            {
                nombreSkin = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

    }
}
