using System;
using NServiceBus;

namespace Contact.Messages.Commands
{
    public class CreateUser : ICommand
    {
        public Guid UserId { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
    }
}