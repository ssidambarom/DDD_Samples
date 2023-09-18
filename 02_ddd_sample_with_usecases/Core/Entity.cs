namespace 02_ddd_sample_with_usecases;
public abstract class Entity
{
    protected Entity(Guid id)
    {
        if (id == default)
            throw new ArgumentException("The ID cannot be default value.", nameof(id));

        Id = id;
    }

    public Guid Id { get; }

    public override bool Equals(object obj)
    {
        if (obj is not Entity other)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (GetType() != other.GetType())
            return false;

        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}