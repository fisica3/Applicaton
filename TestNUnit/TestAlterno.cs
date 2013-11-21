﻿using System;
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

        [Test]
        public void TestFibonacciValor2()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(1, sut.Fibonacci(2), "Error 2");
        }
        [Test]
        public void TestFibonacciValor3()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(2, sut.Fibonacci(3), "Error 3");
        }
        [Test]
        public void TestFibonacciValor4()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(3, sut.Fibonacci(4), "Error 4");
        }

        [Test]
        public void TestFibonacciValor5()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(5, sut.Fibonacci(5), "Error 5");
        }

        [Test]
        public void TestFibonacciValor6()
        {
            var sut = new Matematicas.Basicas();
            Assert.AreEqual(8, sut.Fibonacci(6), "Error 5");
        }
    }
}
