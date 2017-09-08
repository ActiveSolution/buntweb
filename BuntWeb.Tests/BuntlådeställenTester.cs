using System;
using System.Linq;
using BuntWeb.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuntWeb.Tests
{
    [TestClass]
    public class BuntlådeställenTester
    {
        [TestMethod]
        public void LäggTill_EttBuntlådeställe_ListaSkaInnehållaEttElement()
        {
            // Arrange
            var buntlådeställen = new Buntlådeställen();

            // Act
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);

            // Assert
            var count = buntlådeställen.Lista().Count();
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void LäggTill_TvåBuntlådeställe_ListaSkaInnehållaTvåElement()
        {
            // Arrange
            var buntlådeställen = new Buntlådeställen();

            // Act
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);
            buntlådeställen.LäggTill("Kungstensgatan 3", Typ.Lämna);

            // Assert
            var count = buntlådeställen.Lista().Count();
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void LäggTill_EttBuntlådeställeMedAdressKungstensgatan1_ListasFörstaElementsAdressSkaVaraKungstensgatan1()
        {
            // Arrange
            var buntlådeställen = new Buntlådeställen();

            // Act
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);

            // Assert
            var first = buntlådeställen.Lista().First();
            Assert.AreEqual("Kungstensgatan 1", first.Adress);
        }

        [TestMethod]
        public void LäggTill_TvåLämnaställeMedSammaAdress_BuntlådeställeExceptionSkaKastas()
        {
            // Arrange
            var buntlådeställen = new Buntlådeställen();
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);

            // Act
            var ex = Assert.ThrowsException<BuntlådeställeException>(() =>
            {
                buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);
            });

            // Assert
            Assert.AreEqual("Det får inte finnas två lämnaställen med samma adress", ex.Message);
        }

        [TestMethod]
        public void LäggTill_TvåLämnaställeMedSammaAdress_BuntlådeställeExceptionSkaInteKastas()
        {
            // Arrange
            var buntlådeställen = new Buntlådeställen();
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Lämna);

            // Act
            buntlådeställen.LäggTill("Kungstensgatan 1", Typ.Hämta);

            // Assert
            // No exception should be thrown...
        }
    }
}
