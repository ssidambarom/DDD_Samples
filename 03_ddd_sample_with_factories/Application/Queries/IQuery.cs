namespace ddd_sample_03_with_factories;
public interface IQuery<T> where T : Entity
{
    Task<T[]> GetAll();
}