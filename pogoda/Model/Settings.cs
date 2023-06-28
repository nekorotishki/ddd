using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogoda.Model
{
    public class Settings
    {
        public Town Town { get; set; }
        public string Presentation { get; set; }
        public Settings(Town town, string presentation) 
        {
            this.Town = town;
            Presentation = presentation;
        }
    }
}
