using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi.UserControls
{
    public partial class StationMap : UserControl
    {
        public StationMap()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            StationMapPanel.Controls.Clear();
            StationMapPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void TurnBackBtn_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            AddUserControl(st);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void StationMap_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 41.025742;
            lon = 28.974201;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 13;
            GMapOverlay o = new GMapOverlay("o");
            GMapMarker m = new GMarkerGoogle(new PointLatLng(lat, lon), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);

            gMapControl1.Overlays.Add(o);
            o.Markers.Add(m);
            gMapControl1.Invalidate();
            gMapControl1.Update();
        }
    }
}
