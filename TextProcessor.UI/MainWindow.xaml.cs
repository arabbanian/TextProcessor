using System.Collections.Generic;
using System.Windows;

namespace TextProcessor.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<IWordAnalyzer> result = new WordFrequencyAnalyzer().AlalyzeFrequencyForWord(InputTextBox.Text);
            foreach (var wordAnalyzer in result)
            {
                DestinationList.Items.Add((string.Format("Word '{0}' occurred: {1}", wordAnalyzer.Word, wordAnalyzer.Frequency)));
            }
        }
    }
}
