﻿using System;
using Contact.Infrastructure.NServiceBus.DomainEventMappers;
using Contact.Messages.Events;
using NUnit.Framework;

namespace Contact.UnitTests.DomainEventMappersTests
{
    [TestFixture]
    public class TestAccommodationLeadCreatedMapper
    {
        [Test]
        public void ShouldReturnABusEventForAccommodationLeadCreated()
        {
            var id = Guid.NewGuid();
            var mapper = new AccommodationLeadCreatedMapper();
            var domainEvent = new Domain.AccommodationLeadCreated(id, "Joe", "test@test.com");
            Assert.That(mapper.Map(domainEvent), Is.TypeOf<AccommodationLeadCreated>());
        }
    }
}