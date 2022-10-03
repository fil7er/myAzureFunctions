using System.Collections.Generic;

namespace Demo.DTO
{
    

    public class MainEventDTO
    {
        private readonly long eventTypeId;
        private readonly string eventName;
        private readonly string eventDescription;
        private readonly EventType eventType;

        private class EventType
        {
            private readonly long eventTypeId;
            private readonly IReadOnlyDictionary<long, long> eventFlags;
            private readonly IReadOnlyDictionary<string, string> eventDetails;

        }

    }
}