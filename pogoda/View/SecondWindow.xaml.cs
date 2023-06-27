using Cloud.ViewModel;
using LiveCharts;
using LiveCharts.Wpf;
using pogoda.Model;
using pogoda.ViewModel.Helpers;
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
        public PogodaPage p;
        public SettingsPage s;
        private WeatherData dataCollection;
        private Image bitmap;
        public SecondWindow()
        {
            ConstructorTask(true);
        }
        public void CaseWeather(string name)
        {
            BitmapImage image = new BitmapImage();
            switch (name)
            {
                case "Снег":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Snow.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Гроза":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Thunderstorm.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Дождь":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Rainy.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Ясно":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Sunny.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Пасмурно":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Cloudy.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Ветрено":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Wind.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Град":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Blizzard.png", UriKind.Relative);
                    image.EndInit();
                    break;
                case "Облачно с прояснениями":
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Cloudy.png", UriKind.Relative);
                    image.EndInit();
                    break;
                default:
                    image.BeginInit();
                    image.UriSource = new Uri("/Images/Rainy.png", UriKind.Relative);
                    image.EndInit();
                    break;
            }
            bitmap.Source = image;
        }
        public async Task ConstructorTask(bool IsInitialize)
        {
            await LoadWeatherDataAsync();
            if (IsInitialize) { InitializeComponent(); }
            string name = dataCollection.weather[0].description;
            name = char.ToUpper(name[0]) + name.Substring(1);
            NowData.Text = $"{name}. {(int)dataCollection.main.temp}°\nОщущается как {(int)dataCollection.main.feels_like}°";
            SelectedCity.Text = dataCollection.name;
            bitmap = firstImage;
            CaseWeather(name);
            s = new SettingsPage(this);
            p = new PogodaPage(dataCollection);
            fr.Content = p;
        }
        private async Task LoadWeatherDataAsync()
        {
            dataCollection = await ApiHelper.GetWeatherDataAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = p;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fr.Content = s;
        }
    }
}
