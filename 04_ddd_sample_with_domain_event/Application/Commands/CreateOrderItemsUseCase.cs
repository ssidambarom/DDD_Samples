namespace ddd_sample_04_with_domain_event;
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