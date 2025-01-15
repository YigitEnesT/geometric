namespace geometric.Models.Dto
{
    public record GeometricDtoForInsertion
    {
        public string Name { get; init; }
        public string Wkt { get; init; }
    }
}
