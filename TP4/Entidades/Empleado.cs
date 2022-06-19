using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public enum EPuesto
        {
            Marketing,
            Ventas,
            Compras
        }

        int legajo;
        string nombre;
        string apellido;
        int dni;
        string puesto;
        float sueldo;

        public Empleado()
        {
                
        }

        public Empleado(int legajo, string nombre, string apellido, int dni, string puesto, float sueldo) : this(nombre, apellido, dni, puesto, sueldo)
        {
            this.legajo = legajo;
        }

        public Empleado(string nombre, string apellido, int dni, string puesto, float sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.puesto = puesto;
            this.sueldo = sueldo;
        }

        public int Legajo { 
            get => legajo; 
            set => legajo = value; 
        
        }
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }

        public string Apellido { 
            get => apellido; 
            set => apellido = value; 
        }

        public int Dni { 
            get => dni; 
            set => dni = value; 
        }

        public string Puesto { 
            get => puesto; 
            set => puesto = value;
        }

        public float Sueldo { 
            get => sueldo;
            set => sueldo = value; 
        }

        public override string ToString()
        {
            return $"{legajo} - {nombre} {apellido} - {dni} - {puesto} - ${sueldo}";
        }
    }
}
