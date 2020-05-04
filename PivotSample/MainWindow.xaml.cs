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
        Windows.UI.Xaml.Media.FontFamily segoeFont;
        Windows.UI.Xaml.Style fontIconStyle, headerTextBlockStyle, contentTextBlockStyle;

        public MainWindow()
        {
            InitializeComponent();

            segoeFont = new Windows.UI.Xaml.Media.FontFamily("Segoe MDL2 Assets");
            fontIconStyle = new Windows.UI.Xaml.Style(typeof(FontIcon));
            fontIconStyle.Setters.Add(new Windows.UI.Xaml.Setter(FontIcon.FontSizeProperty, 16));
            fontIconStyle.Setters.Add(new Windows.UI.Xaml.Setter(FontIcon.FontFamilyProperty, segoeFont));

            headerTextBlockStyle = new Windows.UI.Xaml.Style(typeof(Windows.UI.Xaml.Controls.TextBlock));
            headerTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, 16));
            headerTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.FrameworkElement.MarginProperty, new Windows.UI.Xaml.Thickness(5, 0, 0, 0)));

            contentTextBlockStyle = new Windows.UI.Xaml.Style(typeof(Windows.UI.Xaml.Controls.TextBlock));
            contentTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, 100));
            contentTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.Controls.TextBlock.ForegroundProperty, Windows.UI.Colors.White));
            contentTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.FrameworkElement.HorizontalAlignmentProperty, Windows.UI.Xaml.HorizontalAlignment.Center));
            contentTextBlockStyle.Setters.Add(new Windows.UI.Xaml.Setter(Windows.UI.Xaml.FrameworkElement.VerticalAlignmentProperty, Windows.UI.Xaml.VerticalAlignment.Center));
        }

        private void host_ChildChanged(object sender, EventArgs e)
        {
            try
            {
                var host = (WindowsXamlHost)sender;
                if (host.Child is Pivot pivot)
                {
                    // Home
                    var homeHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    homeHeader.Children.Add(new FontIcon() { Glyph = "\uE80F", Style = fontIconStyle });
                    homeHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Home", Style = headerTextBlockStyle });

                    var homeContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.MidnightBlue),
                    };
                    homeContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Home", Style = contentTextBlockStyle });


                    // Shop
                    var shopHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    shopHeader.Children.Add(new FontIcon() { Glyph = "\uE719", Style = fontIconStyle });
                    shopHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Shop", Style = headerTextBlockStyle });

                    var shopContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.DeepSkyBlue),
                    };
                    shopContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Shop", Style = contentTextBlockStyle });


                    // Payments
                    var paymentHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    paymentHeader.Children.Add(new FontIcon() { Glyph = "\uE8C7", Style = fontIconStyle });
                    paymentHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Payment", Style = headerTextBlockStyle });

                    var paymentContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.ForestGreen),
                    };
                    paymentContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Payment", Style = contentTextBlockStyle });


                    // Reports
                    var reportsHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    reportsHeader.Children.Add(new FontIcon() { Glyph = "\uE9F9", Style = fontIconStyle });
                    reportsHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Reports", Style = headerTextBlockStyle });

                    var reportsContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Maroon),
                    };
                    reportsContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Reports", Style = contentTextBlockStyle });


                    // Locate Branch
                    var branchHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    branchHeader.Children.Add(new FontIcon() { Glyph = "\uE707", Style = fontIconStyle });
                    branchHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Locate Branch", Style = headerTextBlockStyle });

                    var branchContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Navy),
                    };
                    branchContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Locate Branch", Style = contentTextBlockStyle });


                    // Profile Settings
                    var profileSettingsHeader = new Windows.UI.Xaml.Controls.StackPanel()
                    {
                        Orientation = Windows.UI.Xaml.Controls.Orientation.Horizontal,
                    };
                    profileSettingsHeader.Children.Add(new FontIcon() { Glyph = "\uEF58", Style = fontIconStyle });
                    profileSettingsHeader.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Profile Settings", Style = headerTextBlockStyle });

                    var profileSettingsContent = new Windows.UI.Xaml.Controls.Grid()
                    {
                        Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Fuchsia),
                    };
                    profileSettingsContent.Children.Add(new Windows.UI.Xaml.Controls.TextBlock() { Text = "Profile Settings", Style = contentTextBlockStyle });


                    var homePivotItem = new PivotItem()
                    {
                        Header = homeHeader,
                        Content = homeContent,
                    };

                    var shopPivotItem = new PivotItem()
                    {
                        Header = shopHeader,
                        Content = shopContent,
                    };

                    var paymentPivotItem = new PivotItem()
                    {
                        Header = paymentHeader,
                        Content = paymentContent,
                    };

                    var reportsPivotItem = new PivotItem()
                    {
                        Header = reportsHeader,
                        Content = reportsContent,
                    };

                    var branchPivotItem = new PivotItem()
                    {
                        Header = branchHeader,
                        Content = branchContent,
                    };

                    var profileSettingsPivotItem = new PivotItem()
                    {
                        Header = profileSettingsHeader,
                        Content = profileSettingsContent,
                    };

                    pivot.Title = "Services";
                    pivot.Items.Add(homePivotItem);
                    pivot.Items.Add(shopPivotItem);
                    pivot.Items.Add(paymentPivotItem);
                    pivot.Items.Add(reportsPivotItem);
                    pivot.Items.Add(branchPivotItem);
                    pivot.Items.Add(profileSettingsPivotItem);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
