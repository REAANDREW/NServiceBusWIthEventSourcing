using System;
using Contact.Domain;

namespace Contact.UnitTests.TestClasses
{
    public class EmptyDomainEvent : DomainEvent
    {
        public Guid ID { get; private set; }

        public EmptyDomainEvent(Guid id)
        {
            ID = id;
        }
    }
}