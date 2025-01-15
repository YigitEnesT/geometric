namespace geometric.Models.Dto
{
    public record GeometricDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Wkt { get; init; }
    }
}
