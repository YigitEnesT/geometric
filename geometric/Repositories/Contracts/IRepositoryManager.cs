namespace geometric.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IGeometricRepository geometricRepository { get; }
        Task SaveAsync();
    }
}
