using Cloud.ViewModel.Helpers;
using Newtonsoft.Json;
using pogoda.Model;
using pogoda.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.ViewModel
{
    internal class MainViewModel : BindingHelpers
    {
        private WeatherData dataCollection;
        public WeatherData DataCollection
        {
            get { return dataCollection; }
            set
            {
                dataCollection = value;
                OnPropertyChanged(); // Вызывает событие PropertyChanged
            }
        }

        public MainViewModel() 
        {
            LoadWeatherDataAsync();
        }

        private async Task LoadWeatherDataAsync()
        {
            DataCollection = await ApiHelper.GetWeatherDataAsync();
        }
    }
}
