namespace ddd_sample_04_with_domain_event;
public class GetOrdersUseCase
{
    private readonly IQuery<Order> query;

    public GetOrdersUseCase(IQuery<Order> query)
    {
        this.query = query;
    }

    public async Task<Order[]> Execute()
    {
        var orders = await query.GetAll();

        if (orders is null or { Length: 0 }) throw new NotOrderFoundException($"No orders found.");

        return orders;
    }
}
