using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNUnit
{
    public class TestAlterno
    {
        //Otro mensaje :D
        [Test]
        public void TestFibonacciValorInicial()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(1, sut.Fibonacci(1), "Error 0");
        }
    }
}
