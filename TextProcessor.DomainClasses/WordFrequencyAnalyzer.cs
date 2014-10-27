using System.Collections.Generic;
using System.Linq;

namespace TextProcessor
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        /// <summary>
        /// Alalyze Frequency For Word
        /// </summary>
        /// <param name="text"></param>
        /// <returns>A distinct list of words in the input text</returns>
        public IEnumerable<WordFrequency> AlalyzeFrequencyForWord(string text)
        {
            var wordAnalyzerList = text.ToLower().Split(new[] {' ', ',', '.', ':', '\t'})
                .Select(t => t.Trim()).Where(t => t.Trim() != string.Empty)
                .GroupBy(g => g)
                .Select(x => new WordFrequency(x.Key, x.Count())).Distinct();
            return wordAnalyzerList;
        }
    }
}
