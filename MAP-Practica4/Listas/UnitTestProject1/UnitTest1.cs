using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListasEnlazadas;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CuentaEltosListaVacia()
        {
            //Arrange
            Lista lista = new Lista(0, 0);

            //Act
            int eltos = lista.cuentaEltos();

            //Assert
            Assert.AreEqual(0, eltos, "ERROR");
        }

        [TestMethod]
        public void CuentaEltosListaNoVacia()
        {
            //Arrange
            Lista lista = new Lista(3, 2);

            //Act
            int eltos = lista.cuentaEltos();

            //Assert 
            Assert.AreEqual(6, eltos, "ERROR");
        }
        
        [TestMethod]
        public void InsertaFinListaVacia()
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
        public void InsertaFinListaNoVacia()
        {
            //Arrange
            Lista lista = new Lista(3, 2);
            int eltos = lista.cuentaEltos();

            //Act
            lista.insertaFin(0);
            string cadena = lista.aCadena();

            //Assert
            Assert.AreEqual(7, eltos + 1, "ERROR");
            Assert.AreEqual("1231230", cadena, "ERROR"); //Comprobar que se inserta al final.

        }

        [TestMethod]
        public void BorraEltoListaVacia()
        {
            //Arrange
            Lista lista = new Lista(0,0);
            

            //Act
            bool borrado = lista.borraElto(1);
            int eltos = lista.cuentaEltos();

            //Assert
            Assert.AreEqual(0, eltos, "ERROR");
            Assert.IsFalse(borrado);
            
        }

        [TestMethod]
        public void BorraEltoListaNoVaciaElementoEnLista()
        {
            //Arrange
            Lista lista = new Lista(3, 2);
            int elto = lista.cuentaEltos();
            //Act
            bool borrado = lista.borraElto(2);
            //Assert
            Assert.IsTrue(borrado,"ERROR");
            Assert.AreEqual(elto - 1, lista.cuentaEltos(), "ERROR");
            Assert.AreEqual("13123", lista.aCadena(), "ERROR");
            

        }

        [TestMethod]
        public void BorraEltoListaNoVaciaElementoNoEstaEnLista()
        {
            //Arrange
            Lista lista = new Lista(3, 2);
            int elto = lista.cuentaEltos();
            //Act
            bool borrado = lista.borraElto(5);
            //Assert
            Assert.IsFalse(borrado, "ERROR");
            Assert.AreEqual(elto, lista.cuentaEltos(), "ERROR");
            Assert.AreEqual("123123", lista.aCadena(), "ERROR");


        }
    }
}
