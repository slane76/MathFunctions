using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Math_Functions.Tests
{
    [TestClass()]
    public class MathFunctionClassTests
    {
        [TestMethod()]
        public void CubeTest()
        {
            Assert.AreEqual(8, objectUnderTest.Cube(2));
        }






        //Instantiation
        MathFunctionClass objectUnderTest = new MathFunctionClass();


        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(36, objectUnderTest.Square(-6));
            Assert.AreEqual(0, objectUnderTest.Square(0));
            Assert.AreEqual(4, objectUnderTest.Square(2));
            //Using ShouldBe has the same function as Assert
            objectUnderTest.Square(6)
                .ShouldBe(36);
        }
    }   
}