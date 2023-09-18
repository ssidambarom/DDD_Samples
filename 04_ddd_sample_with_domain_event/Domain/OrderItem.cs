namespace ddd_sample_04_with_domain_event;
public class OrderItem : ValueObject<OrderItem>
{
    protected OrderItem(Guid productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }

    public Guid ProductId { get; }
    public int Quantity { get; }

    public OrderItem Add(int quantity)
    {
        EnsureQuantityAlwaysPositive(quantity);

        return new OrderItem(ProductId, Quantity + quantity);
    }

    private static void EnsureQuantityAlwaysPositive(int quantity)
    {
        if (quantity <= 0) throw new NegativeOrZeroValueException(nameof(quantity));
    }

    public OrderItem Remove(int quantity)
    {
        EnsureQuantityAlwaysPositive(quantity);

        if (quantity >= Quantity) return new(ProductId, 0);

        return new OrderItem(ProductId, Quantity + quantity);
    }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { ProductId, Quantity };
    }

    public static OrderItem Create(Guid productId, int quantity)
    {
        EnsureQuantityAlwaysPositive(quantity);

        return new OrderItem(productId, quantity);
    }
}