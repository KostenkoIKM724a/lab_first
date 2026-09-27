using System;
using Xunit;
using LabWork2App;

namespace LabWork2.Tests
{
    public class UnitTest1
    {
        private readonly Variant9Service _service = new Variant9Service();

        #region Tests for CountVowels

        [Theory]
        [InlineData("hello", 2)]
        [InlineData("AEIOU", 5)]
        [InlineData("sky", 1)]
        [InlineData("rhythm", 1)]
        [InlineData("bcdfg", 0)]
        [InlineData("xUnit Testing Framework", 7)]
        public void CountVowels_ValidStrings_ReturnsCorrectCount(string text, int expected)
        {
            // Act
            int actual = _service.CountVowels(text);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CountVowels_NullOrEmpty_ReturnsZero(string? text)
        {
            // Act
            int actual = _service.CountVowels(text);

            // Assert
            Assert.Equal(0, actual);
        }

        #endregion

        #region Tests for FindSecondLargest

        [Fact]
        public void FindSecondLargest_StandardArray_ReturnsSecondMax()
        {
            // Arrange
            int[] input = { 10, 5, 20, 8, 12 };
            int expected = 12;

            // Act
            int actual = _service.FindSecondLargest(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindSecondLargest_WithDuplicates_IgnoresDuplicateMax()
        {
            // Arrange
            int[] input = { 20, 10, 20, 15, 5 };
            int expected = 15;

            // Act
            int actual = _service.FindSecondLargest(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindSecondLargest_NegativeNumbers_ReturnsCorrectElement()
        {
            // Arrange
            int[] input = { -10, -50, -2, -15 };
            int expected = -10;

            // Act
            int actual = _service.FindSecondLargest(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindSecondLargest_NullArray_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _service.FindSecondLargest(null));
        }

        [Fact]
        public void FindSecondLargest_SingleElement_ThrowsInvalidOperationException()
        {
            // Arrange
            int[] singleElement = { 5 };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _service.FindSecondLargest(singleElement));
        }

        [Fact]
        public void FindSecondLargest_AllIdenticalElements_ThrowsInvalidOperationException()
        {
            // Arrange
            int[] allSame = { 7, 7, 7 };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _service.FindSecondLargest(allSame));
        }

        #endregion
    }
}