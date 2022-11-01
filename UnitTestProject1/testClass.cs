using ArithmeticOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class testClass
    {
        public int i = 10, j = 25;
        [TestMethod]
        [Ignore("Skipped by Dev")]
        public void testSum()
        {
            Arithmetic ar= new Arithmetic();    
            Assert.AreEqual(35,ar.sum(i,j));  
        }
    }
}
