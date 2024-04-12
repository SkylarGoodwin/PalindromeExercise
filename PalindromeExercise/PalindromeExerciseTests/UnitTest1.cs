using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //acttual
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
