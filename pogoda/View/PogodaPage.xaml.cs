using LiveCharts;
using LiveCharts.Wpf;
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
    /// Логика взаимодействия для PogodaPage.xaml
    /// </summary>
    public partial class PogodaPage : Page
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public List<ViewCard> viewCards = new List<ViewCard>();
        public PogodaPage()
        {
            InitializeComponent();
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            viewCards.Add(new ViewCard("/Images/Sunny.png", 15, 14, 17, "16:00"));//Тут типо карточки сюда засовываем
            lv.ItemsSource = viewCards;
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Градусов: ",
                    Values = new ChartValues<double> { 5, 3, 2, 4, 3, 2,13, 21, 42, 1 },
                    LineSmoothness = 0.7, //0: straight lines, 1: really smooth lines
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 5,
                    PointForeground = Brushes.BlanchedAlmond
                }
            };

            Labels = new[] { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            //YFormatter = new[] { "10°", "20°", "30°", "40°", "50°" };
            YFormatter = value => value.ToString("N0");
            //modifying the series collection will animate and update the chart
            //modifying any series values will also animate and update the chart
            DataContext = this;
        }
    }
}
