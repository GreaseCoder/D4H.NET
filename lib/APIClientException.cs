using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace D4H.NET
{
    public class APIClientException : Exception
    {
        public APIClientException(HttpResponseMessage response)
            : base(response.ReasonPhrase)
        {
        }
    }
}
