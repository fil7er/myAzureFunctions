using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azureFunctions.DTO
{
    public class EventResponseDTO
    {
        public readonly long eventResponseId;
        public readonly long eventStatus;
        public readonly string eventResponseMessage;
        public readonly IReadOnlyDictionary<long, long> eventResponseFlags;
        public readonly IReadOnlyDictionary<string, string> eventResponseDetails;
    }
}
