using Microsoft.VisualStudio.TestTools.UnitTesting;
using Armas;
using Clientes;
using System;

namespace UnitTesting
{
    [TestClass]
    public class Testeos
    {
        [TestMethod]
        public void TestAgregarArma_Success()
        {
            Cuchillo arma = new();
            arma.TipoArma = Arma.ETipoArma.Ak_47;
            arma.TipoCalidad = Arma.ECalidadArma.Roja;
            arma.NombreSkin = "Contacto Sangriento";
            arma.Precio = 4000;

            Arma.AgregarArma(arma);

            foreach (Cuchillo item in Arma.armas)
            {
                if(item == arma)
                {
                    Assert.IsTrue(true);
                }
            }
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestAgregarCliente_Error()
        {
            Cliente cliente = new Cliente(0, null, null, 0);
            Cliente.AgregarCliente(cliente);
        }
    }
}
