using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eigene_Klassen;

namespace PersonenTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteHochzeit()
        {
            Person anja = new Person("Anja", "Schulz",
                                Person.Geschlechter.Weiblich, new DateTime(1980, 10, 3));

            anja.Ehepartner = anja;
            Assert.AreEqual(null, anja.Ehepartner);

        }
    }
}
