using pogoda.Model;
using System.Collections.Generic;
using System.Windows.Controls;
using static pogoda.ViewModel.Helpers.JsonHelper;
namespace pogoda.View
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        List<TownCard> townCards;
        List<Town> towns;
        public SettingsPage()
        {
            InitializeComponent();
            towns = FromJson<List<Town>>("..\\..\\..\\Json\\towns.json");
            townCards = new List<TownCard>();
            if (towns == null)
            {
                towns = new List<Town>();
            }
            foreach (var item in townCards)
            {
                wp.Children.Add(item);
                towns.Add(new Town(item.Coordinates.lon, item.Coordinates.lat, item.TownName));
            }
            ToJson<List<Town>>(towns, "..\\..\\..\\Json\\towns.json");
        }
    }
}
