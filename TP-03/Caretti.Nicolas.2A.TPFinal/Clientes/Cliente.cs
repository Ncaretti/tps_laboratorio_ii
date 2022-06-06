﻿using System.Collections.Generic;
using System;

namespace Clientes
{
    public class Cliente
    {
        int dni;
        string nombre;
        string apellido;
        int cantidadDeCompras;
        public static List<Cliente> lista;

        public Cliente()
        {
        }

        public Cliente(int dni, string nombre, string apellido, int cantidadDeCompras)
        {
            try
            {
                if (dni == 0 || nombre == null || apellido == null)
                {
                    throw new Exception();
                }
                else
                {
                    this.dni = dni;
                    this.nombre = nombre;
                    this.apellido = apellido;
                    this.cantidadDeCompras = cantidadDeCompras;
                }
            }
            catch(Exception)
            {
            }
        }

        public static void AgregarCliente(Cliente cliente)
        {
            lista = new List<Cliente>();
            if(cliente.apellido == null)
            {
                throw new NullReferenceException();
            }
            lista.Add(cliente);
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int CantidadDeCompras
        {
            get
            {
                return this.cantidadDeCompras;
            }
            set
            {
                this.cantidadDeCompras = value;
            }
        }
    }
}
