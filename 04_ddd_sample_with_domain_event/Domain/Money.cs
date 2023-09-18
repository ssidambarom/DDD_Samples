namespace ddd_sample_04_with_domain_event;
public class Money : ValueObject<Money>
{
    private const decimal MinimalValueAllowed = 0m;

    public Money()
        : this(MinimalValueAllowed, new EuroCurrency())
    {
    }

    public Money(decimal value, Currency currency)
    {
        if (value < MinimalValueAllowed)
            throw new NegativeValueException($"Value cannot be lower than {MinimalValueAllowed}.");

        Value = value;
        Currency = currency;
    }

    public decimal Value { get; }
    public Currency Currency { get; }

    public Money Add(Money moneyToAdd)
    {
        EnsureSameCurrency(moneyToAdd);

        return new Money(Value + moneyToAdd.Value, Currency);
    }

    private void EnsureSameCurrency(Money moneyToAdd)
    {
        if (!Currency.Equals(moneyToAdd.Currency))
            throw new NonMatchingCurrencyException("You cannot add money with different currencies.");
    }

    public Money Minus(Money toDiscount)
    {
        EnsureSameCurrency(toDiscount);

        EnsureValueIsPositive(toDiscount);

        return new Money(Value - toDiscount.Value, Currency);
    }

    private void EnsureValueIsPositive(Money moneyToSubstract)
    {
        if (Value < moneyToSubstract.Value)
            throw new NegativeValueException($"You cannot substract money with higher value than {Value}.");
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