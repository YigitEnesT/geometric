using geometric.Models.Dto;
using geometric.Repositories.Contracts;
using geometric.Services.Contracts;

namespace geometric.Services
{
    public class GeometricManager : IGeometricService
    {
        private readonly IRepositoryManager _manager;

        public GeometricManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Task<GeometricDtoForInsertion> CreateOneRecord(GeometricDtoForInsertion geometricDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOneRecord(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GeometricDto>> GetAllRecordsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GeometricDto> GetOneRecord(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GeometricDtoForInsertion> UpdateOneRecord(int id, GeometricDtoForInsertion geometricDto)
        {
            throw new NotImplementedException();
        }
    }
}
