using Imo.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace Imo
{
    public partial class MainWindow : Window
    {
        readonly DataViewModel viewModel = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) => DataContext = viewModel;

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Processing.Visibility = Visibility.Visible;
            string Query = QueryText.Text;
            if (e.Key == Key.Enter && !(viewModel.ExecuteQuery(Query)))
                MessageBox.Show("Invalid Query!...");
            Processing.Visibility = Visibility.Collapsed;
        }
    }
}