namespace ddd_sample_04_with_domain_event;
public interface IQuery<T> where T : Entity
{
    Task<T[]> GetAll();
}