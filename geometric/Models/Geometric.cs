using NetTopologySuite.Geometries;

namespace geometric.Models
{
    public class Geometric
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Geometry Geometry { get; set; }
    }
}
