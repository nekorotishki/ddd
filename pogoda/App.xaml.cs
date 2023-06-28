using pogoda.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace pogoda
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Town Town { get; set; }
        public static string Presentation { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            DateTime currentTime = DateTime.Now;

            string theme = GetThemeByTime(currentTime);

            ResourceDictionary themeDictionary = new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/Themes1;component/Themes/{theme}.xaml")
            };

            Resources.MergedDictionaries.Add(themeDictionary);
        }

        private string GetThemeByTime(DateTime currentTime)
        {
            int hour = currentTime.Hour;

            if (hour >= 0 && hour <= 3)
            {
                return "Night";
            }
            else if (hour >= 4 && hour <= 11)
            {
                return "Morning";
            }
            else if (hour >= 12 && hour <= 16)
            {
                return "Day";
            }
            else
            {
                return "Morning";
            }
        }
    }
}
