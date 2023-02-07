using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace simpleApp.Models
{
    public class APIResponse
    {
        public bool Success { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }

        public HttpHeaders Headers { get; set; }

        public T MapToObject<T>()
        {
            if (!string.IsNullOrWhiteSpace(Message))
            {
                return JsonConvert.DeserializeObject<T>(Message);
            }

            return JsonConvert.DeserializeObject<T>("{}");
        }
    }
}
