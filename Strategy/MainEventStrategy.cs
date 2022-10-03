using azureFunctions.DTO;
using Demo.DTO;

namespace Demo.Strategy
{  
    public class MainEventStrategy
    {
        public EventResponseDTO Run(MainEventDTO eventDTO)
        {
            return new EventResponseDTO();
        }
    }

}