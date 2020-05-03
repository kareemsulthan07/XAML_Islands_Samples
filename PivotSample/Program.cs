using System;
using System.Collections.Generic;
using System.Text;

namespace PivotSample
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            using (new UWPSample.App())
            {
                var app = new PivotSample.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
