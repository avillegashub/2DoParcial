using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class MyUnitTests
    {
        [TestMethod]
        public void InstanciarPedido()
        {
            Pedido pPrueba;

            Assert.IsNotNull(pPrueba = new Pedido(Comercio.clientes[0], null));

        } 
        [TestMethod]
        public void ConexionBaseDatos()
        {
            try
            {
                DataBase.TraerClientes();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.

        }
    }
}
