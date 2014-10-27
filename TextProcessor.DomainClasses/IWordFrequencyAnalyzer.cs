using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    public interface IWordFrequencyAnalyzer
    {
        /// <summary>
        /// Alalyze Frequency For Word
        /// </summary>
        /// <param name="text"></param>
        /// <returns>A distinct list of words in the input text</returns>
        IEnumerable<WordFrequency> AlalyzeFrequencyForWord(string text);

    }

}
