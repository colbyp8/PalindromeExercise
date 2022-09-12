using PalindromeExercise;
using System;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineDataAttribute("racecar", true)]
        [InlineDataAttribute("kayak", true)]
        [InlineDataAttribute("Racecar", true)]
        [InlineDataAttribute("Cactus", false)]
        [InlineDataAttribute("programming", false)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
