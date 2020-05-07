using Microsoft.VisualStudio.TestTools.UnitTesting;
using entornos_bloque3aev2;
using System;
using System.Collections.Generic;
using System.Text;

namespace entornos_bloque3aev2.Tests
{
    [TestClass()]
    public class OperacionTests
    {

        [TestMethod()]
        public void RestaTest()
        {
            // Arrange
            var operacion = new Operacion();
            operacion.Num1 = 10;
            operacion.Num2 = 10;

            var expected = 0;

            // Act
            var actual = operacion.Resta();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumaTest()
        {
            // Arrange
            var operacion = new Operacion();
            operacion.Num1 = 10;
            operacion.Num2 = 10;

            var expected = 20;

            // Act
            var actual = operacion.Suma();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            // Arrange
            var operacion = new Operacion();
            operacion.Num1 = 10;
            operacion.Num2 = 10;

            var expected = 100;

            // Act
            var actual = operacion.Multiplicacion();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}