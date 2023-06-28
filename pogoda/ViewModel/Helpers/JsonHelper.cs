using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace pogoda.ViewModel.Helpers
{
    class JsonHelper
    {
        public static void ToJson<T>(T list, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(list));
        }
        public static T FromJson<T>(string path)
        {
            
            
            var file = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(file);
            
        }
    }
}
