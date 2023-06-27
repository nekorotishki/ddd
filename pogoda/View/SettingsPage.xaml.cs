using pogoda.Model;
using pogoda.ViewModel.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static pogoda.ViewModel.Helpers.JsonHelper;
namespace pogoda.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public List<TownCard> townCards;
        List<Town> towns;
        private WeatherData dataCollection;
        public SecondWindow secondWindow;
        public SettingsPage(SecondWindow sc)
        {
            InitializeComponent();
            secondWindow = sc;
            towns = FromJson<List<Town>>("..\\..\\..\\Json\\towns.json");
            townCards = new List<TownCard>();
            if (towns == null)
            {
                towns = new List<Town>();
            }
            Town town = new Town(37.22, 35.02, "Владивосток");
            towns.Add(town);
            Clear();
        }
        private async Task LoadWeatherDataAsync()
        {
            ApiHelper.city = CityInput.Text;
            dataCollection = await ApiHelper.GetWeatherDataAsync();
            if (dataCollection == null)
            {
                MessageBox.Show("Такой город не найден. Проверьте написание города.");
            }
            else
            {
                Town town = new Town(dataCollection.coord.lon, dataCollection.coord.lat, dataCollection.name);
                towns.Add(town);
                Clear();
            }
        }
        public void Clear()
        {
            townCards.Clear();
            wp.Children.Clear();
            foreach (var item in towns)
            {
                TownCard townc = new TownCard(item.Name, item.Lon, item.Lat, this, item);
                townCards.Add(townc);
                wp.Children.Add(townc);
            }
            ToJson(towns, "..\\..\\..\\Json\\towns.json");
        }
        public void DeleteCity(Town t)
        {
            towns.Remove(t);
            Clear();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ConstructorTask();
        }
        private async Task ConstructorTask()
        {
            await LoadWeatherDataAsync();
        }
    }
}
