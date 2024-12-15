using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnelsteAtleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] _naam = new string[10];
        private int[] _tijd = new int[10];
        int currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
           
            _naam[currentIndex] = nameTextBox.Text;
            _tijd[currentIndex] = int.Parse(timeTextBox.Text);
            currentIndex++;

            nameTextBox.Clear();
            timeTextBox.Clear();
            nameTextBox.Focus();
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            int fastestTime = _tijd[0];
            int fastestIndex = 0;
            for (int i = 1; i < currentIndex; i++)
            {
                if (_tijd[i] < fastestTime)
                {
                    fastestTime = _tijd[i];
                    fastestIndex = i;
                }
            }

            resultTextBox.Text = $"De snelste atleet is {_naam[fastestIndex]}\n" +
                                 $"totaal aantal seconden: {fastestTime}";

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            timeTextBox.Clear();
            nameTextBox.Clear();
            nameTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}