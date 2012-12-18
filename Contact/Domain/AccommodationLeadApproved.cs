using System;

namespace Contact.Domain
{
    public class AccommodationLeadApproved : DomainEvent
    {
        public AccommodationLeadApproved(Guid id)
        {
            ID = id;
        }

        public Guid ID { get; private set; }
    }
}