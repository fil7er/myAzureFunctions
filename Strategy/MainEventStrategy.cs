using azureFunctions.DTO;

namespace azureFunctions.Strategy
{  
    public class MainEventStrategy
    {
        public EventResponseDTO Run(MainEventDTO eventDTO)
        {
            return new EventResponseDTO();
        }
    }

}