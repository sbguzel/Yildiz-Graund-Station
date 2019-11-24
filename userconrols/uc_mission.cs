using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace YildizGroundStation.userconrols
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]

    public partial class uc_mission : UserControl
    {
        public static string[] LatLng = new string[2];
        public HtmlElement LatLngClick;
        public HtmlElement LatLngSend;
        public HtmlElement latitude;
        public HtmlElement longitude;
        public HtmlElement accuracy;
        public HtmlElement altitude;

        public uc_mission()
        {
            InitializeComponent();
        }

        private void uc_mission_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("YildizGroundStation.Map.Maps.htm"));
            webBrowser1.DocumentText = reader.ReadToEnd();
            webBrowser1.AllowWebBrowserDrop = true;
            webBrowser1.IsWebBrowserContextMenuEnabled = true;
            webBrowser1.WebBrowserShortcutsEnabled = true;
            webBrowser1.ObjectForScripting = this;
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watcher.MovementThreshold = 0.1;
            watcher.PositionChanged += GeoLocationChanged;
            watcher.Start();
            // Uncomment the following line when you are finished debugging.
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void GeoLocationChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            latitude = SubmitForm("com_lat");
            longitude = SubmitForm("com_lng");
            altitude = SubmitForm("com_alt");
            accuracy = SubmitForm("com_acc");

            latitude.SetAttribute("value", e.Position.Location.Latitude.ToString("0.00000000", CultureInfo.InvariantCulture));
            longitude.SetAttribute("value", e.Position.Location.Longitude.ToString("0.00000000", CultureInfo.InvariantCulture));
            altitude.SetAttribute("value", e.Position.Location.Altitude.ToString("0.00", CultureInfo.InvariantCulture));
            accuracy.SetAttribute("value", e.Position.Location.HorizontalAccuracy.ToString());
            webBrowser1.Document.InvokeScript("onLocationFound");
        }
        
        public void GetCoordinates()
        {

            LatLngClick = SubmitForm("LatLngClick");

            LatLng = LatLngClick.GetAttribute("value").Remove(0, 7).Split(',');
            LatLng[1] = LatLng[1].Remove(LatLng[1].Length - 1, 1).Trim();
            //textBoxLat.Text = LatLng[0];
            //textBoxLng.Text = LatLng[1];
        }

        private HtmlElement SubmitForm(String formName)
        {
            HtmlElementCollection elems = null;
            HtmlElement elem = null;

            if (webBrowser1.Document != null)
            {
                HtmlDocument doc = webBrowser1.Document;
                elems = doc.All.GetElementsByName(formName);
                if (elems != null && elems.Count > 0)
                    elem = elems[0];

            }
            return elem;
        }

        private void webBrowser1_ProgressChanged_1(object sender, WebBrowserProgressChangedEventArgs e)
        {
            LatLngClick = SubmitForm("LatLngClick");
            if (LatLngClick != null)
                // button2.Enabled = true;
                LatLng = LatLngClick.GetAttribute("value").Remove(0, 7).Split(',');
            LatLng[1] = LatLng[1].Remove(LatLng[1].Length - 1, 1).Trim();
        }
        
    }
}

