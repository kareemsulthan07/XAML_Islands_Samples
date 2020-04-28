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
using UIControls = Windows.UI.Xaml.Controls;
using Media = Windows.UI.Xaml.Media;
using Microsoft.Toolkit.Wpf.UI.XamlHost;

namespace NavigationViewSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UIControls.Frame frame;
        private Media.FontFamily segoeFontFamily;

        public MainWindow()
        {
            InitializeComponent();
            segoeFontFamily = new Media.FontFamily("Segoe MDL2 Assets");
        }

        private void Host_ChildChanged(object sender, EventArgs e)
        {
            try
            {
                WindowsXamlHost host = (WindowsXamlHost)sender;
                if (host.Child is UIControls.NavigationView navigationView)
                {
                    var homeItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Home",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uE80F",
                        }
                    };

                    var shopItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Shop",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uE719",
                        }
                    };

                    var paymentsItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Payments",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uE8C7",
                        }
                    };

                    var reportsItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Reports",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uE9F9",
                        }
                    };

                    var locateBranchItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Locate Branch",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uE707",
                        }
                    };

                    var profileSettingsItem = new UIControls.NavigationViewItem()
                    {
                        Content = "Profile Settings",
                        Icon = new UIControls.FontIcon()
                        {
                            FontFamily = segoeFontFamily,
                            Glyph = "\uEF58",
                        }
                    };

                    navigationView.MenuItems.Add(homeItem);
                    navigationView.MenuItems.Add(shopItem);
                    navigationView.MenuItems.Add(paymentsItem);
                    navigationView.MenuItems.Add(reportsItem);
                    navigationView.MenuItems.Add(locateBranchItem);
                    navigationView.MenuItems.Add(profileSettingsItem);

                    frame = new UIControls.Frame();
                    navigationView.Content = frame;

                    navigationView.SelectionChanged += NavigationView_SelectionChanged;
                }
            }
            catch (Exception)
            {
            }
        }

        private void NavigationView_SelectionChanged(UIControls.NavigationView sender, UIControls.NavigationViewSelectionChangedEventArgs args)
        {
            try
            {
                if (args.SelectedItem is UIControls.NavigationViewItem item)
                {
                    switch (item.Content)
                    {
                        case "Home":
                            frame.Content = new HomePage();
                            break;

                        case "Shop":
                            frame.Content = new ShopPage();
                            break;

                        case "Payments":
                            frame.Content = new PaymentsPage();
                            break;

                        case "Reports":
                            frame.Content = new ReportsPage();
                            break;

                        case "Locate Branch":
                            frame.Content = new BranchPage();
                            break;

                        case "Profile Settings":
                            frame.Content = new ProfileSettingsPage();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }

    public class HomePage : UIControls.Page
    {
        public HomePage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Home",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.MidnightBlue);
        }
    }

    public class ShopPage : UIControls.Page
    {
        public ShopPage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Shop",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.DeepSkyBlue);
        }
    }

    public class PaymentsPage : UIControls.Page
    {
        public PaymentsPage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Payments",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.ForestGreen);
        }
    }

    public class ReportsPage : UIControls.Page
    {
        public ReportsPage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Reports",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.Maroon);
        }
    }

    public class BranchPage : UIControls.Page
    {
        public BranchPage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Locate Branch",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.Navy);
        }
    }

    public class ProfileSettingsPage : UIControls.Page
    {
        public ProfileSettingsPage()
        {
            Content = new UIControls.TextBlock()
            {
                Text = "Profile Settings",
                FontSize = 100,
                Foreground = new Media.SolidColorBrush(Windows.UI.Colors.White),
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
            };

            this.Background = new Media.SolidColorBrush(Windows.UI.Colors.Fuchsia);
        }
    }
}
