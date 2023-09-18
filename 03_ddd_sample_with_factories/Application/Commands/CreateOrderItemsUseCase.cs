namespace ddd_sample_03_with_factories;
public class CreateOrderItemsUseCase
{
    private readonly IRepository<Order> repository;

    public CreateOrderItemsUseCase(IRepository<Order> repository)
    {
        this.repository = repository;
    }

    public Task<Order> Execute(DateTime orderDate, DateTime? deliveryDate = null)
    {
        var order = Order.Create(orderDate);

        repository.Save(order);

        return Task.FromResult(order);
    }
}