using Advanced.NET_Labb_7_XUnit_Acceptanstest;
using System.Diagnostics.Contracts;

namespace XUnit_Delen
{
    public class UnitTest1
    {
        [Fact]
        public void Addition_Test_ShouldReturnAdditionResult()
        {
            ///AAA      
            ///

            //Arrange
            CalculatorLogic calculator = new CalculatorLogic();

            int num1 = 5;
            int num2 = 5;
            int expected = 10;

            //Act
            var actual = calculator.Addition(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]
        [InlineData(40, 5, 35)]
        [InlineData(20, 5, 15)]
        public void Subtraction_shouldReturnExpectedResult(int a, int b, int expected)
        {
            ///AAA
            ///     

            //Arrange
            CalculatorLogic calculator = new CalculatorLogic();

            //Act
            int actual = calculator.Subtraction(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(15, 3, 5)]
        [InlineData(100, 2, 50)]
        public void Divide_ShouldReturnExpectedResult(int a, int b, double expected)
        {
            ///AAA
            ///

            //Arrange
            CalculatorLogic calculator = new CalculatorLogic();

            //Act
            int actual = calculator.Divide(a, b);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(20, 4, 80)]
        [InlineData(15, 3, 45)]
        [InlineData(100, 2, 200)]
        public void Multiplication(int a, int b, double expected)
        {
            ///AAA
            ///

            //Arrange
            CalculatorLogic calculator = new CalculatorLogic();

            //Act
            int actual = calculator.Multiplication(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}