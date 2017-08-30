using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class KaffeTests
    {
        [TestMethod()]
        public void prisTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(20,pris);
        }

        [TestMethod()]
        public void styrkeTestKaffe()
        {
            //Arrange
            var kaffe = new SortKaffe();
            //Act
            string styrke = kaffe.Styrke();
            //Assert
            Assert.AreEqual("stærk",styrke);
        }

        [TestMethod()]
        public void TestKaffeListe()
        {
            //Arrange
            var kaffeListe = new List<Imælk>();

            var cortado = new Cortado();
            var latte = new Latte();
            var sortkaffe = new SortKaffe();
            kaffeListe.Add(cortado);
            kaffeListe.Add(latte);

            //Act
            int total = 0;
            foreach (var kaffeitem in kaffeListe)
            {
                total += kaffeitem.MlMælk();
                /*if (kaffeitem is Cortado)
                {
                    var localCortado = kaffeitem as Cortado;
                }
                kaffeitem.MlMælk();*/
            }
            
            //Assert
            Assert.AreEqual(145,total);
            
        }
    }
}