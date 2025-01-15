using geometric.Services.Contracts;

namespace geometric.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IGeometricService _geometricService;

        public ServiceManager(IGeometricService geometricService)
        {
            _geometricService = geometricService;
        }

        public IGeometricService geometricService => _geometricService;
    }
}
