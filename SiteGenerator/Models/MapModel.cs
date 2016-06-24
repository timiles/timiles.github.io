namespace SiteGenerator.Models
{
    public class MapModel
    {
        public MapModel(double latitude, double longitude, int zoom, int radius)
        {
            Latitude = latitude;
            Longitude = longitude;
            Zoom = zoom;
            Radius = radius;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Zoom { get; set; }
        public int Radius { get; set; }
    }
}