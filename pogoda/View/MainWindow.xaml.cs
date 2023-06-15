using Cloud.ViewModel;
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

        private void TextBox_TextChanged()
        {

        }
    }
}
