namespace 02_ddd_sample_with_usecases;
public interface IRepository<T> where T : Entity
{
    Task<T?> GetbyId(Guid orderId);
    Task Save(T entityToSave);
}
