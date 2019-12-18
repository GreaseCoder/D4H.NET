using D4H.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D4H.NET
{
    public interface IAPIClient
    {
        //Task DeleteRequest(Uri uri);
        Task<APIResponse<T>> GETRequest<T>(string path, Dictionary<string, object> headers) where T : IModel;
        //Task POSTRequest(Uri uri);
        //Task PUTRequest(Uri uri);
    }
}
