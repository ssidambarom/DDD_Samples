namespace ddd_sample_04_with_domain_event;
public class GetOrderByIdUseCase
{
    private readonly IRepository<Order> repository;

    public GetOrderByIdUseCase(IRepository<Order> repository)
    {
        this.repository = repository;
    }

    public async Task<Order> Execute(Guid orderId)
    {
        var order = await repository.GetbyId(orderId);

        if (order is null) throw new NotOrderFoundException($"No order found with id:{orderId}");

        return order;
    }
}
