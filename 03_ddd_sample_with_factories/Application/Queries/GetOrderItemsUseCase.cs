namespace ddd_sample_03_with_factories;
public class GetOrderItemsUseCase
{
    private readonly IRepository<Order> repository;

    public GetOrderItemsUseCase(IRepository<Order> repository)
    {
        this.repository = repository;
    }

    public async Task<OrderItem[]> Execute(Guid orderId)
    {
        var order = await repository.GetbyId(orderId);

        if (order is null) throw new NotOrderFoundException($"No order found with id:{orderId}");

        return order.Items.ToArray();
    }
}
