namespace 02_ddd_sample_with_usecases;
public class AddOrderItemsUseCase
{
    private readonly IRepository<Order> repository;

    public AddOrderItemsUseCase(IRepository<Order> repository)
    {
        this.repository = repository;
    }

    public async Task Execute(Guid orderId, params OrderItem[] newOrderItems)
    {
        var order = await repository.GetbyId(orderId);

        if (order is null) throw new NotOrderFoundException($"No order found with id:{orderId}");

        foreach (var item in newOrderItems)
        {

            order.AddItem(item.ProductId, item.Quantity);
        }
    }
}
