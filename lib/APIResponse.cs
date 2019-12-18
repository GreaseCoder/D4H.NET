using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace D4H.NET.Models
{
    public class APIResponse<T>
        where T : IModel
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("data")]
        public T[] Data { get; set; }
    }

}
