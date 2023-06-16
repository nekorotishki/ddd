using Cloud.ViewModel;
using pogoda.View;
using System.Windows;

namespace pogoda
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow sc = new SecondWindow();
            sc.Show();
            Close();
        }
    }
}
