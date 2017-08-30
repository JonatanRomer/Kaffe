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
    public class SortKaffeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat20kr()
        {
            //Arrange
            var sortkaffe = new SortKaffe(20);
            //Act
            int pris = sortkaffe.Pris();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat21kr()
        {
            //Arrange
            var sortkaffe = new SortKaffe(21);
            //Act
            int pris = sortkaffe.Pris();
        }
        
    }
}