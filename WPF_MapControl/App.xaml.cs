using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_MapControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string token => 
            "Paste_Your_Bing_Map_Service_Token";
    }
}
