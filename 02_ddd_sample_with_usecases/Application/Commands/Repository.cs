namespace 02_ddd_sample_with_usecases;

public class Repository<T> : IRepository<T>, IQuery<T>
    where T : Entity
{
    private readonly Dictionary<Guid, T> _items = new();

    public Repository()
    {
    }

    public IReadOnlyCollection<T> Items => _items.Values;

    public Task<T[]> GetAll()
    {
        return Task.FromResult(_items.Values.ToArray());
    }

    public Task<T> GetbyId(Guid orderId)
    {
        return _items.TryGetValue(orderId, out T? value) && value is T entity ?
            Task.FromResult(entity) :
            Task.FromResult(value!);
    }

    public Task Save(T entityToSave)
    {
        if (!_items.TryAdd(entityToSave.Id, entityToSave))
            throw new ArgumentException("No duplicate allowed");

        return Task.CompletedTask;
    }
}