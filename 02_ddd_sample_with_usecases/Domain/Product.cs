namespace 02_ddd_sample_with_usecases;
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