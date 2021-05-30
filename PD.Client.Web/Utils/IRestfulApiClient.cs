using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Utils
{
    public interface IRestfulApiClient
    {
        Task Post<T>(string url, T contentValue);
        Task Put<T>(string url, T stringValue);
        Task<T> Get<T>(string url);
        Task Delete(string url,int id);
    }
}
