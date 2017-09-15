using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzKataTests
    {
        [Test]
        public void FizzBuzzChecker_GivenIntegerOf1_ShouldReturnStringOf1()
        {
            //Arrange
            int input = 1;
            var sut = new FizzBuzzKata();
            string expected = "1";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf2_ShouldReturnStringOf2()
        {
            //Arrange
            int input = 2;
            var sut = new FizzBuzzKata();
            string expected = "2";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf3_ShouldReturnStringOfFizz()
        {
            //Arrange
            int input = 3;
            var sut = new FizzBuzzKata();
            string expected = "Fizz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf4_ShouldReturnStringOf4()
        {
            //Arrange
            int input = 4;
            var sut = new FizzBuzzKata();
            string expected = "4";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf5_ShouldReturnStringOfBuzz()
        {
            //Arrange
            int input = 5;
            var sut = new FizzBuzzKata();
            string expected = "Buzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf6_ShouldReturnStringOfFizz()
        {
            //Arrange
            int input = 6;
            var sut = new FizzBuzzKata();
            string expected = "Fizz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf9_ShouldReturnStringOfFizz()
        {
            //Arrange
            int input = 9;
            var sut = new FizzBuzzKata();
            string expected = "Fizz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf10_ShouldReturnStringOfBuzz()
        {
            //Arrange
            int input = 10;
            var sut = new FizzBuzzKata();
            string expected = "Buzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf15_ShouldReturnStringOfFizzBuzz()
        {
            //Arrange
            int input = 15;
            var sut = new FizzBuzzKata();
            string expected = "FizzBuzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf20_ShouldReturnStringOfBuzz()
        {
            //Arrange
            int input = 20;
            var sut = new FizzBuzzKata();
            string expected = "Buzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf30_ShouldReturnStringOfFizzBuzz()
        {
            //Arrange
            int input = 30;
            var sut = new FizzBuzzKata();
            string expected = "FizzBuzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzzChecker_GivenIntegerOf75_ShouldReturnStringOfFizzBuzz()
        {
            //Arrange
            int input = 75;
            var sut = new FizzBuzzKata();
            string expected = "FizzBuzz";
            //Act
            var result = sut.FizzBuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
