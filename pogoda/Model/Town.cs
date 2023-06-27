using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogoda.Model
{
    public class Town
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public string Name { get; set; }
        public Town(double lon, double lat, string name)
        {
            Lon = lon;
            Lat = lat;
            Name = name;
        }
    }
}
