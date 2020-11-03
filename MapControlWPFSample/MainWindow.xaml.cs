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

namespace MapControlWPFSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mControl = new MapControl();
            mControl.MapServiceToken = "YyCLZ0tUWEVR5LhmOxU2~N5_DKq3BO09wuiDyyYk7cA~AnIe2DUX0rrV-lMgFs_kXLA5gEViyUs6v0AiM0La8hkXgQ2ydTUYo5mi8VO7koIu";
            mControl.Loaded += mapControl_Loaded;
            mainGrid.Children.Add(mControl);
        }

        private async void mapControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Specify a known location.
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 47.604, Longitude = -122.329 };
            var cityCenter = new Geopoint(cityPosition);

            // Set the map location.
            await(sender as MapControl).TrySetViewAsync(cityCenter, 12);
        }
    }
}
