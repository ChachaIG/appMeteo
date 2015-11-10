using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using DAL;

namespace TestAccesDonnees
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //1 Arrange => instancie
            AccesDonnees acces = new AccesDonnees();

            //2 Act => utiliser le système
            CityForecast[] tab = acces.GetForeCastFromDatabase();
            //3 Assert => on compare résultat obtenu et attendu
            Assert.IsTrue(tab.Length>0);
        }
    }
}
