﻿namespace TextProcessor
{
    public class WordFrequency:IWordFrequency
    {
        /// <summary>
        /// Initiliaze the WordFrequency class and set the 'Word' and 'Frequency' properties.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="frequency"></param>
        public WordFrequency(string word, int frequency)
        {
            Frequency = frequency;
            Word = word;
        }
       /// <summary>
       /// Gets the Word. 
       /// </summary>
        public string Word { get; private set; }
        /// <summary>
        /// Gets the Frequency.
        /// </summary>
        public int Frequency { get; private set; }
    }

}
