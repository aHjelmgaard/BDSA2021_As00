using System;
using Xunit;

namespace As00.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void isLeapYear_not_divisible_by_4(int input)
        {
            //Arrange
            int year = input;

            //Act
            bool output = Program.isLeapYear(year);

            //Assert
            Assert.False(output);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(12)]
        [InlineData(32)]
        public void isLeapYear_divisible_by_4(int input)
        {
            //Arrange
            int year = input;

            //Act
            bool output = Program.isLeapYear(year);

            //Assert
            Assert.True(output);
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void isLeapYear_false_when_divisible_by_100(int input)
        {
            //Arrange
            int year = input;

            //Act
            bool output = Program.isLeapYear(year);

            //Assert
            Assert.False(output);
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        public void isLeapYear_true_when_divisible_by_100_and_400(int input)
        {
            //Arrange
            int year = input;

            //Act
            bool output = Program.isLeapYear(year);

            //Assert
            Assert.True(output);
        }
    }
}
