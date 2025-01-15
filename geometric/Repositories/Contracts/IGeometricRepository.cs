using geometric.Models;

namespace geometric.Repositories.Contracts
{
    public interface IGeometricRepository : IRepositoryBase<Geometric>
    {
        public Task<IEnumerable<Geometric>> GetAllRecordsAsync();
        public Task<Geometric> GetOneRecord(int id);
        public void CreateOneRecord(Geometric geometric);
        public void UpdateOneRecord(Geometric geometric);
        public void DeleteOneRecord(Geometric geometric);
    }
}
