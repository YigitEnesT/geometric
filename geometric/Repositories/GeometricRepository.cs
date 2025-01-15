using geometric.Models;
using geometric.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace geometric.Repositories
{
    public class GeometricRepository : RepositoryBase<Geometric>, IGeometricRepository
    {
        public GeometricRepository(AppDbContext context) : base(context)
        {
        }

        public void CreateOneRecord(Geometric geometric) => Create(geometric);

        public void DeleteOneRecord(Geometric geometric) => Delete(geometric);

        public async Task<IEnumerable<Geometric>> GetAllRecordsAsync() => 
            await GetAll()
                .OrderBy(x => x.Id)
                .ToListAsync();
        public async Task<Geometric> GetOneRecord(int id) =>
            await FindByCondition(x => x.Id.Equals(id))
                .SingleOrDefaultAsync();
        

        public void UpdateOneRecord(Geometric geometric) => Update(geometric);
    }
}
