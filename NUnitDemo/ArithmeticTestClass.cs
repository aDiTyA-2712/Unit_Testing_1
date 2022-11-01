using ArithmeticOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;
using Moq;

namespace NUnitDemo
{
    
    [TestFixture]
    public class ArithmeticTestClass
    {
        public int i = 10, j = 25;
        public bool result;
        [SetUp]//this means that the below method will always execute before the rest methods
        public void CheckNonNegative()
        {
            if(i>0 && j>0)
            {
                result = true;
            }
            else
            {
                result = false; 
            }
        }
        [TearDown]
        public void SetupDefaultValues()
        {
            result = false;
        }
        [Test]
        public void TestSum()
        {
            if(result)
            {
                Arithmetic ar = new Arithmetic();
                Assert.AreEqual(35, ar.Sum(i, j));
            }
            else
            {
                Assert.Fail();
            }
            
        }
        [Test]
        [TestCase(10,5,5)]
        [TestCase(100,3,970)]
        public void TestSub(int a,int b,int expected)
        {
            Arithmetic ar = new Arithmetic();
            Assert.AreEqual(expected, ar.Sub(a, b));
        }
        [Test]
        [Ignore("Not implemented yet")]
        public void TestMul()
        {

        }
        [Test]
        [TestCase(64,4,16)]
        public void TestDiv(int x,int y,int z)
        {
            Arithmetic ar=new Arithmetic();
            Assert.AreEqual(z, ar.Div(x, y));
        }
        [Test]
        public void CheckValues()
        {
            Mock<Arithmetic> mock = new Mock<Arithmetic>();
            mock.Setup(x=>x.CheckDigitsOnly()).Returns(true);//by passing true value even if it is false
            Assert.AreEqual(true,mock.Object.CheckDigitsOnly());
        }
    }
}
