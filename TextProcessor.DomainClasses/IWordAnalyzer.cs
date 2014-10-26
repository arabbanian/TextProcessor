using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    public interface IWordAnalyzer
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
