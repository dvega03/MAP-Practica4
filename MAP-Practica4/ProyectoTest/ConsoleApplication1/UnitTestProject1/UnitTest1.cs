﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Primos()
        {
            Assert.AreEqual(true, Program.EsPrimo(2), "Fallo: el 2 debería ser primo");
            Assert.IsTrue(Program.EsPrimo(3), "Fallo: el 3 debería ser primo");
            Assert.IsFalse(Program.EsPrimo(10), "Fallo: el 10 NO es primo");
        }

        [TestMethod]
        public void CeroYUno()
        {
            Assert.IsFalse(Program.EsPrimo(0), "Fallo: el 0 NO es primo");
            Assert.IsFalse(Program.EsPrimo(1), "Fallo: el 1 NO es primo");
        }

        [TestMethod]
        public void PrimosNegativos()
        {
            Assert.AreEqual(false, Program.EsPrimo(-2), "Fallo: el -2 NO es primo");
            Assert.AreEqual(false, Program.EsPrimo(-3), "Fallo: el -3 NO es primo");
            Assert.AreEqual(false, Program.EsPrimo(-10), "Fallo: el -10 NO es primo");
        }
    }
}
