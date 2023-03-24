using AwesomeDevEvents.API.Entities;

namespace AwesomeDevEvents.API.Persistance
{
    public class DevEventsDbContext
    {
        public List<DevEvent>DevEvents { get; set; }

        public DevEventsDbContext()
        {
            DevEvents = new List<DevEvent>();
        }
    }
}
