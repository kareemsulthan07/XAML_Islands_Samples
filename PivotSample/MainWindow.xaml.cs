using Microsoft.Toolkit.Wpf.UI.XamlHost;
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
using Windows.UI.Xaml.Controls;

namespace PivotSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void host_ChildChanged(object sender, EventArgs e)
        {
            try
            {
                var host = (WindowsXamlHost)sender;
                if (host.Child is Pivot pivot)
                {
                    var redColorItem = new PivotItem()
                    {
                        Header = "Red",
                        Content = new Windows.UI.Xaml.Controls.Grid()
                        {
                            Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Red),
                        }
                    };

                    var greenColorItem = new PivotItem()
                    {
                        Header = "Green",
                        Content = new Windows.UI.Xaml.Controls.Grid()
                        {
                            Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green),
                        }
                    };

                    var blueColorItem = new PivotItem()
                    {
                        Header = "Blue",
                        Content = new Windows.UI.Xaml.Controls.Grid()
                        {
                            Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue),
                        }
                    };

                    pivot.Title = "RGB";
                    pivot.Items.Add(redColorItem);
                    pivot.Items.Add(greenColorItem);
                    pivot.Items.Add(blueColorItem);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
