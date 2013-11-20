using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicatonDemo.Tests
{
    [TestClass]
    public class PruebaMates
    {
        [TestMethod]
        public void TestFibonacciValorInicial()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(1, sut.Fibonacci(1), "Error 0");
        }
        [TestMethod]
        public void TestFibonacciValor2()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(1, sut.Fibonacci(2), "Error 2");
        }
        [TestMethod]
        public void TestFibonacciValor3()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(2, sut.Fibonacci(3), "Error 3");
        }
        [TestMethod]
        public void TestFibonacciValor4()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(3, sut.Fibonacci(4), "Error 4");
        }

        [TestMethod]
        public void TestFibonacciValor5()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(5, sut.Fibonacci(5), "Error 5");
        }

        [TestMethod]
        public void TestFibonacciValor6()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(8, sut.Fibonacci(6), "Error 5");
        }

        //Agregando Tests...
    }
}
