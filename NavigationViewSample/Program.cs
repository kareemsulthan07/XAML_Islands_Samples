using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationViewSample
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            using (new UWPSample.App())
            {
                var app = new NavigationViewSample.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
