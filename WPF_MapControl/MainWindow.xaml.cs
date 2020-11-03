using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.Controls;
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

namespace WPF_MapControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mapControl = new MapControl();
            mapControl.Loaded += MapControl_Loaded;
            mapControl.MapServiceToken = App.token;
            mainGrid.Children.Add(mapControl);
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            //BasicGeoposition inGeoposition = new BasicGeoposition() { Latitude = 20.5937, Longitude = 78.9629 };
            BasicGeoposition chennaiGeoposition = new BasicGeoposition() { Latitude = 13.0827, Longitude = 80.2707 };
            var center = new Geopoint(chennaiGeoposition);

            await ((MapControl)sender).TrySetViewAsync(center, 12);
        }
    }
}
