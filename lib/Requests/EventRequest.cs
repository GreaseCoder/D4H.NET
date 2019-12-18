using D4H.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D4H.NET.Requests
{
    public class EventRequest
    {
        private readonly IAPIClient client;

        public EventRequest(IAPIClient client) => this.client = client;

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            var request = new Dictionary<string, object>();
            var result = await client.GETRequest<Event>(Constants.EventsPath, request);
            return result.Data;
        }
    }
}
