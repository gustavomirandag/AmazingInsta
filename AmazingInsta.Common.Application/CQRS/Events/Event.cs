using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Common.Application.CQRS.Events
{
    public abstract class Event
    {
        public abstract string QueueName { get; }
        public DateTime Timestamp { get; set; }

        public Event()
        {
            Timestamp = new DateTime();
        }
    }
}
