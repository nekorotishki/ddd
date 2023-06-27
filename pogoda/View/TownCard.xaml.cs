using pogoda.Model;
using pogoda.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pogoda.View
{
    /// <summary>
    /// Логика взаимодействия для TownCard.xaml
    /// </summary>
    public partial class TownCard : UserControl
    {
        public string TownName;
        public double Lat;
        public double Lon;
        public SettingsPage settingsPage;
        Town TownSource;
        public TownCard(string town, double lat, double lon, SettingsPage sp, Town townSource)
        {
            InitializeComponent();
            settingsPage = sp;
            Lon = lon;
            Lat = lat;
            TownName = town;
            Town.Text = town;
            TownSource = townSource;
            Coords.Text = $"{lat} с.ш. {lon} в.д";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            settingsPage.DeleteCity(TownSource);
        }

        private void Element_Click(object sender, RoutedEventArgs e)
        {
            ApiHelper.city = Town.Text;
            settingsPage.secondWindow.ConstructorTask(false);
            settingsPage.secondWindow.fr.Content = settingsPage.secondWindow.p;
        }
    }
}
