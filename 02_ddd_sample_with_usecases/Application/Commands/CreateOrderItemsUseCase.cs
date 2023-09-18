namespace 02_ddd_sample_with_usecases;
public class CreateOrderItemsUseCase
{
    private readonly IRepository<Order> repository;

    public CreateOrderItemsUseCase(IRepository<Order> repository)
    {
        this.repository = repository;
    }

    public Task<Order> Execute(DateTime orderDate, DateTime? deliveryDate = null)
    {
        var order = new Order(Guid.NewGuid(), orderDate, deliveryDate);

        repository.Save(order);

        return Task.FromResult(order);
    }
}