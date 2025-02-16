using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 3, 9)]
        [InlineData(5, 5, 5, 15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculatortest = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculatortest.Add(num1,num2,num3);

            //Assert
            Assert.Equal(expected, actual);
        }
        

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(5, 10, -5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculatortest = new Calculator();

            //Act
            var actual = calculatortest.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        [InlineData(5, 5, 25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculatortest = new Calculator();

            //Act
            var actual = calculatortest.MultiplyTest(num1,num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(30,6,5)]//Add test data <-------
        [InlineData(10,5,2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculatortest = new Calculator();

            //Act
            var actual = calculatortest.DivideTest( num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
