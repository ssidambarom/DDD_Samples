namespace 02_ddd_sample_with_usecases;
public interface IQuery<T> where T : Entity
{
    Task<T[]> GetAll();
}