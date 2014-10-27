namespace TextProcessor
{
    public interface IWordFrequency
    {
        /// <summary>
        /// Get the Word value
        /// </summary>
        string Word { get;}
        /// <summary>
        /// Get the Frequency value
        /// </summary>
        int Frequency { get; }
    }
}
