using Microsoft.Toolkit.Forms.UI.Controls;
using Microsoft.Toolkit.Forms.UI.XamlHost;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_MapControl
{
    public partial class Form1 : Form
    {
        double lat = 20.5937, longt = 78.9629;
        MapControl mapControl = null;

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;

            mapControl = new MapControl();
            mapControl.MapServiceToken = Program.token;
            BasicGeoposition position = new BasicGeoposition()
            {
                Latitude = lat,
                Longitude = longt,
            };
            Geopoint point = new Geopoint(position);
            mapControl.Center = point;
            mapControl.ZoomLevel = 4.5;
            mapControl.Dock = DockStyle.Fill;
            mapControl.Parent = this;
            this.Controls.Add(mapControl);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Controls.Clear();
                mapControl?.Dispose();
                mapControl = null;
            }
            catch (Exception)
            {
            }
        }
    }
}
