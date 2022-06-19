using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class CampoVacioException : Exception
    {
        public CampoVacioException()
        {
        }

        public CampoVacioException(string message) : base(message)
        {
        }
    }
}
