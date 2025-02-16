using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new UnitTests();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.AddTest(num1,num2,num3);

            //Assert
            Assert.Equal(expected, actual);
        }
        

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new UnitTests();

            //Act
            var actual = test.SubtractTest(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            public int MultiplyTest(int num1, int num2)
            {
                return num1 * num2;
            }

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

    }
}
