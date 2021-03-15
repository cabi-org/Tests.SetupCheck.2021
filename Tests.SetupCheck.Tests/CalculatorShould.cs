using System;
using Tests.SetupCheck.SomeFunction;
using Xunit;

namespace Tests.SetupCheck.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void AddTwoNumbers()
        {
            // arrange
            var sut = new Calculator();
            int number1 = 45;
            int number2 = 18;

            // act
            int result = sut.AddTwoNumbers(number1, number2);

            // assert
            Assert.Equal(63, result);
        }
    }
}
