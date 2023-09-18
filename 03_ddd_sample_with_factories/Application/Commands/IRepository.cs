namespace ddd_sample_03_with_factories;
public interface IRepository<T> where T : Entity
{
    Task<T?> GetbyId(Guid orderId);
    Task Save(T entityToSave);
}
