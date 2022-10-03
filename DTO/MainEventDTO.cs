using System.Collections.Generic;

namespace Demo.DTO
{
    

    public class MainEventDTO
    {
        public readonly long eventTypeId;
        public readonly string eventName;
        public readonly string eventDescription;
        public readonly EventType eventType;

        public class EventType
        {
            public readonly long eventTypeId;
            public readonly IReadOnlyDictionary<long, long> eventFlags;
            public readonly IReadOnlyDictionary<string, string> eventDetails;

        }

    }
}