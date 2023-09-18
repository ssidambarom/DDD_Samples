namespace ddd_sample_04_with_domain_event;
public interface IRepository<T> where T : Entity
{
    Task<T?> GetbyId(Guid orderId);
    Task Save(T entityToSave);
}
