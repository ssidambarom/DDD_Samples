namespace ddd_sample_03_with_factories;
public class Money : ValueObject<Money>
{

    public Money()
        : this(0m, new EuroCurrency())
    {
    }

    public Money(decimal value, Currency currency)
    {
        Value = value;
        Currency = currency;
    }

    public decimal Value { get; }
    public Currency Currency { get; }

    public Money Add(Money moneyToAdd)
    {
        if (!Currency.Equals(moneyToAdd.Currency))
            throw new NonMatchingCurrencyException("You cannot add money with different currencies.");

        return new Money(Value + moneyToAdd.Value, Currency);
    }

    public Money Minus(Money toDiscount)
    {
        if (!Currency.Equals(toDiscount.Currency))
            throw new NonMatchingCurrencyException("You cannot remove money with different currencies.");

        return new Money(Value - toDiscount.Value, Currency);
    }

    public override string ToString()
    {
        return $"{Currency.FormatForDisplaying(Value)}";
    }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { Value, Currency };
    }
}