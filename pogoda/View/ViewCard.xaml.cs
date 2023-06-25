using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pogoda.View
{
    /// <summary>
    /// Логика взаимодействия для ViewCard.xaml
    /// </summary>
    public partial class ViewCard : UserControl
    {
        public ViewCard(string ImgPath, int Weather, int Feelings, int Vlazhnost, string Time)
        {
            InitializeComponent();
            Img.Source = new BitmapImage(new Uri(ImgPath, UriKind.Relative));
            WeatherBl.Text = $"{Time}\n{Weather}°";
            FeelBl.Text = $"Ощущ.\n{Feelings}°";
            VlagBl.Text = $"Влаж.\n{Vlazhnost}°";
        }
    }
}
