namespace Contact.Domain
{
    public abstract class DomainEvent
    {
        public int Version { get; set; }
    }
}