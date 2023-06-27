using Cloud.ViewModel.Helpers;
using Newtonsoft.Json;
using pogoda.Model;
using pogoda.View;
using pogoda.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cloud.ViewModel
{
    internal class SecondViewModel : BindingHelpers
    {
        private WeatherData dataCollection;
        private PogodaPage p;
        private SettingsPage s;
        public PogodaPage FramePogodaPage { get { return p; } set { p = value; OnPropertyChanged(); } }
        public SettingsPage FrameSettingsPage { get { return s; } set { s = value; OnPropertyChanged(); } }
        public BindableCommand SettingsC { get; set; }
        public BindableCommand WeatherC { get; set; }
        public ContentControl frame;
        public WeatherData DataCollection
        {
            get { return dataCollection; }
            set
            {
                dataCollection = value;
                OnPropertyChanged(); // Вызывает событие PropertyChanged
            }
        }

        public SecondViewModel()
        {
            LoadWeatherDataAsync();
            FramePogodaPage = new PogodaPage(DataCollection);
            //FrameSettingsPage = new SettingsPage();
            SettingsC = new BindableCommand(_ => Settings_Open());
            WeatherC = new BindableCommand(_ => Weather_Open());
        }
        private void Settings_Open()
        {
            frame.Content = FrameSettingsPage;
        }
        private void Weather_Open()
        {
            frame.Content = FramePogodaPage;
        }

        private async Task LoadWeatherDataAsync()
        {
            DataCollection = await ApiHelper.GetWeatherDataAsync();
        }
    }
}