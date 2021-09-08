using System;
using System.IO;
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

        [Fact]
        public void evaluateInput_returns_yay()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader("1600");
            Console.SetIn(reader);

            //Act
            Program.evaluateInput();

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);

            var isLeapYear = Program.isLeapYear(1600);
            Assert.True(isLeapYear);

        }

        [Fact]
        public void evaluateInput_returns_nay()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader("1900");
            Console.SetIn(reader);

            //Act
            Program.evaluateInput();

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);

            var isLeapYear = Program.isLeapYear(1600);
            Assert.True(isLeapYear);

        }

        [Fact]
        public void evaluateInput_less_than_1582()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader("1581");
            Console.SetIn(reader);

            //Act
            Program.evaluateInput();

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Input year has to be 1582 or greater.", output);
        }

        [Theory]
        [InlineData("ABCD")]
        [InlineData("12A4")]
        [InlineData("3.14")]
        [InlineData("1900.0")]
        public void evaluateInput_input_not_convertible(string input) 
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader(input);
            Console.SetIn(reader);

            //Act
            Program.evaluateInput();

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Invalid input: Input must be an integer greater than 1582.", output);
        }
    }
}
