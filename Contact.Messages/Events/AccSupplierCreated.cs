using NServiceBus;

namespace Contact.Messages.Events
{
    public class AccSupplierCreated : IEvent
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}