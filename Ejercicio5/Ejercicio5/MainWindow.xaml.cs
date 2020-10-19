using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Ejercicio5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void textoUsuarioTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoTextBlock.Text = textoUsuarioTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontWeight=FontWeight.FromOpenTypeWeight(700);
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.Foreground = Brushes.Green;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontWeight = FontWeight.FromOpenTypeWeight(400);
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
