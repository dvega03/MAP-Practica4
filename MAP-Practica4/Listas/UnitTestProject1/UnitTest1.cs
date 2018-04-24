using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListasEnlazadas;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertaFinVacio()
        {
            //Arrange
            Lista lista = new Lista(0,0);
            int eltos = lista.cuentaEltos();

            //Act

            lista.insertaFin(0);
            


            //Assert
            Assert.AreEqual(1, eltos + 1, "ERROR");

        }

        [TestMethod]
        public void InsertaFinListaConElementos()
        {
            //Arrange
            Lista lista = new Lista(3, 2);
            int eltos = lista.cuentaEltos();

            //Act
            lista.insertaFin(0);
            string cadena = lista.aCadena();

            //Assert
            Assert.AreEqual(7, eltos + 1, "ERROR");
            Assert.AreEqual("1231230", cadena, "ERROR");

        }
    }
}
