namespace ddd_sample_03_with_factories;
public class OrderItem : ValueObject<OrderItem>
{
    public OrderItem(Guid productId, int quantity)
    {
        if (quantity <= 0) throw new InvalidDomainException("Quantity cannot be negative or zero.");
        ProductId = productId;
        Quantity = quantity;
    }

    public Guid ProductId { get; }
    public int Quantity { get; }
    public OrderItem Add(int quantity)
    {
        if (quantity <= 0) throw new InvalidDomainException("Quantity cannot be negative or zero.");

        return new OrderItem(ProductId, Quantity + quantity);
    }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { ProductId, Quantity };
    }
}