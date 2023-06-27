using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pogoda.View
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        PogodaPage p;
        SettingsPage s;
        public SecondWindow(string town)
        {
            InitializeComponent();
            p = new PogodaPage();
            s = new SettingsPage();
            fr.Content = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = s;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fr.Content = p;
        }
    }
}
