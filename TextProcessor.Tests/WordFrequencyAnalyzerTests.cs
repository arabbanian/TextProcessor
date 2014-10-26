using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextProcessor.Tests
{
    [TestClass]
    public class WordFrequencyAnalyzerTests
    {
        private readonly IWordFrequencyAnalyzer _wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
        [TestMethod]
        public void ShouldAnalyzeFrequencyForWord()
        {
            //Arrange
            const string inputText = "This is a statement, and so is this.";
            var wordAnalyzer = new List<WordAnalyzer>
            {
                new WordAnalyzer("this", 2),
                new WordAnalyzer("is", 2),
                new WordAnalyzer("a", 1),
                new WordAnalyzer("statement", 1),
                new WordAnalyzer("so", 1),
                new WordAnalyzer("is", 1),
            };
            
            //Act
            var result = _wordFrequencyAnalyzer.AlalyzeFrequencyForWord(inputText);

            //Assert
            Assert.AreEqual(result.Count(), wordAnalyzer.Count());
        }
    }
}
