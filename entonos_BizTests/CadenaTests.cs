using Microsoft.VisualStudio.TestTools.UnitTesting;
using entornos_bloque3aev2;
using System;
using System.Collections.Generic;
using System.Text;

namespace entornos_bloque3aev2.Tests
{
    [TestClass()]
    public class CadenaTests
    {

        [TestMethod()]
        public void ExtraerPrimerCaracterTest()
        {
            // Arrange
            var cad = new Cadena("AdrianPerezGonzalez");
            cad.CadenaTexto = "AdrianPerezGonzalez";

            var expected = "A";

            // Act
            var actual = cad.ExtraerPrimerCaracter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ExtraerUltimoCaracterTest()
        {
            // Arrange
            var cad = new Cadena("AdrianPerezGonzalez");

            var expected = "z";

            // Act
            var actual = cad.ExtraerUltimoCaracter();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ExtraerCaracterConcretoTest()
        {
            // Arrange
            var cad = new Cadena("AdrianPerezGonzalez");

            var expected = "P";

            // Act
            var actual = cad.ExtraerCaracterConcreto(6);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}