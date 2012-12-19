using System;
using System.Collections.Generic;
using Contact.Domain;

namespace Contact.UnitTests.TestClasses
{
    public class EmptyDomainObject : AggregateRoot
    {
        public EmptyDomainObject(IEnumerable<DomainEvent> domainEvents )
            : base(domainEvents)
        {
            
        }

        public EmptyDomainObject(Guid id)
        {
            this.ApplyChange(new EmptyDomainEvent(id));
        }

        private void Apply(EmptyDomainEvent emptyDomainEvent)
        {
            this.ID = emptyDomainEvent.ID;
        }
    }
}
