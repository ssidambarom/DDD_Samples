namespace ddd_sample_03_with_factories;
public class Product : Entity
{
    public Product(Guid id, string name, Money price)
        : base(id)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public Money Price { get; set; }
}