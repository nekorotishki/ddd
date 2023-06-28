using Cloud.ViewModel;
using pogoda.View;
using pogoda.ViewModel.Helpers;
using System.Windows;

namespace pogoda
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            bool check = ((MainViewModel)DataContext).CheckSettings();
            if (check)
            {
                SecondWindow sc = new SecondWindow();
                sc.Show();
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApiHelper.city = town.Text;
            ((MainViewModel)DataContext).WriteToJson(town.Text);
            SecondWindow sc = new SecondWindow();
            sc.Show();
            Close();
        }
        private void close_Click(object sender, RoutedEventArgs e) ///закрыть окна
        {
            Application app = Application.Current;
            app.Shutdown();
        }

        bool MainWindowState = false; ///развернуть окно
        private void max_Click(object sender, RoutedEventArgs e)
        {
            if (!MainWindowState)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                MainWindowState = true;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                MainWindowState = false;
            }
        }

        private void min_Click(object sender, RoutedEventArgs e) ///свернуть окно
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
