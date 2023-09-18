namespace ddd_sample;
public class Order : AggregateRoot
{
    public DateTime OrderDate { get; protected set; }
    public DateTime? DeliveryDate { get; protected set; }
    private readonly List<OrderItem> _items = new();

    private const int MaxOrderItem = 10;

    public Order(Guid id, DateTime orderDate, DateTime? deliveryDate) : base(id)
    {
        OrderDate = orderDate;
        DeliveryDate = deliveryDate;
    }

    public IReadOnlyList<OrderItem> Items => _items;

    public void AddItem(Guid productId, int quantity)
    {
        // Validation and business logic 
        if (_items.Select(i => i.Quantity).Count() + quantity > MaxOrderItem)
            throw new TooManyOrderItemException("Cannot add Item in order. Limit of item within a order has been reached.");

        var foundOrderItemIndex = _items.FindIndex(i => i.ProductId == productId);

        if (foundOrderItemIndex is not -1)
        {
            _items[foundOrderItemIndex] = _items[foundOrderItemIndex].Add(quantity);
            return;
        }

        _items.Add(new OrderItem(productId, quantity));
    }
}