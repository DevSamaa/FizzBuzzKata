using System;
using Xunit;
using FizzBuzzKata;

namespace FizzBuzzKataTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string firstResult = ActualApp.CheckingNumbers(1);
            Assert.Equal("1",firstResult);

            string firstResultB = ActualApp.CheckingNumbers(2);
            Assert.Equal("2", firstResultB);

            string SecondResult = ActualApp.CheckingNumbers(3);
            Assert.Equal("Fizz", SecondResult);

            string ThirdResult = ActualApp.CheckingNumbers(5);
            Assert.Equal("Buzz", ThirdResult);

            string FourthResult = ActualApp.CheckingNumbers(30);
            Assert.Equal("FizzBuzz", FourthResult);
        }
    }
}
