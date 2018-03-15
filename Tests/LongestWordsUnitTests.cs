using System;
using Xunit;

namespace Assessment.Tests
{
    public class LongestWordsUnitTests
    {

        [Theory]
        [InlineData("I am Spartacus!")]
        [InlineData("Size is same")]
        [InlineData("Potato potato Potato")]
        public void ReturnAtleastOneStringGivenSentence(string sentence)
        {
            var result = Assessment.LongestWords.FindLongestWords(sentence);

            Assert.True(result.Count > 0);
        }
    }
}
