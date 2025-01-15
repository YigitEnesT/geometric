using geometric.Models.Dto;

namespace geometric.Services.Contracts
{
    public interface IGeometricService
    {
        public Task<IEnumerable<GeometricDto>> GetAllRecordsAsync();
        public Task<GeometricDto> GetOneRecord(int id);
        public Task<GeometricDtoForInsertion> CreateOneRecord(GeometricDtoForInsertion geometricDto);
        public Task<GeometricDtoForInsertion> UpdateOneRecord(int id, GeometricDtoForInsertion geometricDto);
        public Task DeleteOneRecord(int id);
    }
}
