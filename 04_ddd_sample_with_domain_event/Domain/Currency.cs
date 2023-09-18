namespace ddd_sample_04_with_domain_event;
public abstract class Currency : ValueObject<Currency>
{
    public Currency(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public string Name { get; }
    public string Code { get; }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new[] { Name, Code };
    }

    internal string FormatForDisplaying(decimal value)
    {
        return string.Format("{0} {1}", Code, value);
    }
}

public class EuroCurrency : Currency
{
    public EuroCurrency() : base("Euro", "€")
    {
    }
}