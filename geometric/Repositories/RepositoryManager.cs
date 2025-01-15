using geometric.Repositories.Contracts;

namespace geometric.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly IGeometricRepository _geometricRepository;

        public RepositoryManager(AppDbContext context, IGeometricRepository geometricRepository)
        {
            _context = context;
            _geometricRepository = geometricRepository;
        }

        public IGeometricRepository geometricRepository => _geometricRepository;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
