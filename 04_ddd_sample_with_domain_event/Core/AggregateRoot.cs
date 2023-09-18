namespace ddd_sample_04_with_domain_event;
public class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id)
    {
    }
}