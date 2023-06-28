using Cloud.ViewModel.Helpers;
using pogoda.Model;
using pogoda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static pogoda.ViewModel.Helpers.JsonHelper;

namespace Cloud.ViewModel
{
    internal class MainViewModel : BindingHelpers
    {

        public MainViewModel() 
        {

        }

        public bool CheckSettings()
        {
            try
            {
                Settings settings = FromJson<Settings>("../../../Json/settings.json");
                if (settings != null)
                {
                    App.Town = settings.Town;
                    App.Presentation = settings.Presentation;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void WriteToJson(string cityName)
        {
            Town city = new Town(32, 32.5, cityName);
            Settings settings = new Settings(city, "celcius");

            App.Town = settings.Town;
            App.Presentation = settings.Presentation;

            ToJson<Settings>(settings, "../../../Json/settings.json");
        }
    }
}
