using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(2, 3, 4, 9)]
        [InlineData(10, 10, 15, 35)]

        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            Calculator calc = new Calculator();



            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            int actual = calc.Add(num1, num2, num3);



            //Assert
           
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator sub = new Calculator();

            //Act
            int actual = sub.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 9, 45)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator multiply = new Calculator();

            //Act
            int actual = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(9, 3, 3)]
        [InlineData(5, 5, 1)]
        // test data above
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator divi = new Calculator();
            //Act
            int actual = divi.divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
