using simpleApp.Models;

namespace simpleApp.Interface
{
    public interface IIntegration
    {
        APIResponse ResponseFromAPIPost<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate) where T : class;
        APIResponse ResponseFromAPIPost<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate, string Customtoken) where T : class;
        APIResponse ResponseFromAPIGet(string serviceName, string method, string apiUrl, string authHeader);
        APIResponse ResponseFromAPIPut<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate) where T : class;
        APIResponse ResponseFromAPIPut<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate, string customToken) where T : class;


    }
}
