using Newtonsoft.Json;
using simpleApp.Interface;
using simpleApp.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace simpleApp.DAL
{
    public class Integration : IIntegration
    {
        public Integration()
        {

        }
        public APIResponse ResponseFromAPIGet(string serviceName, string method, string apiUrl, string authHeader)
        {
            //   var token = GenerateToken(serviceName);
            var message = "";
            var handler = new HttpClientHandler();

            using (var client = new HttpClient(handler)
            {
                BaseAddress = new Uri(apiUrl)
            })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //   client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                if (!string.IsNullOrEmpty(authHeader))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);
                try
                {


                    var response = client.GetAsync(method).GetAwaiter().GetResult();
                    message = response.Content.ReadAsStringAsync().Result;

                    return response.IsSuccessStatusCode ? new APIResponse
                    {
                        Success = true,
                        Message = message,
                        StatusCode = response.StatusCode
                    } : new APIResponse
                    {
                        Success = false,
                        Message = message,
                        StatusCode = response.StatusCode
                    };
                }
                catch (Exception e)
                {
                    return new APIResponse
                    {
                        Success = false,
                        Message = e.Message,
                        StatusCode = HttpStatusCode.InternalServerError
                    };
                }
            }
        }
        public APIResponse ResponseFromAPIPost<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate) where T : class
        {
            return ResponseFromAPIPost(serviceName, method, passedObject, apiUrl, authenticate, string.Empty);
        }

        public APIResponse ResponseFromAPIPost<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate, string Customtoken) where T : class
        {
            var token = string.Empty;
            if (string.IsNullOrEmpty(Customtoken))
            {
                //  token = authenticate ? GenerateToken(serviceName) : serviceName;
            }
            else
            {
                token = Customtoken;
            }

            var message = "";

            var handler = new HttpClientHandler();

            using (var client = new HttpClient(handler)
            {
                BaseAddress = new Uri(apiUrl)
            })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var stringContent = JsonConvert.SerializeObject(passedObject);
                var httpContent = new StringContent(stringContent, Encoding.UTF8, "application/json");


                var response = client.PostAsync(method, httpContent).GetAwaiter().GetResult();
                message = response.Content.ReadAsStringAsync().Result;

                var mesTemp = message;


                return response.IsSuccessStatusCode ? new APIResponse
                {
                    Success = true,
                    Message = message,
                    StatusCode = response.StatusCode
                } : new APIResponse
                {
                    Success = false,
                    Message = message,
                    StatusCode = response.StatusCode
                };
            }
        }


        public APIResponse ResponseFromAPIPut<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate) where T : class
        {
            return ResponseFromAPIPut(serviceName, method, passedObject, apiUrl, authenticate, string.Empty);
        }

        public APIResponse ResponseFromAPIPut<T>(string serviceName, string method, T passedObject, string apiUrl, bool authenticate, string customToken) where T : class
        {
            var token = string.Empty;
            if (string.IsNullOrEmpty(customToken))
            {
                // token = authenticate ? GenerateToken(serviceName) : serviceName;
            }
            else
            {
                token = customToken;
            }

            var message = "";

            var handler = new HttpClientHandler();

            using (var client = new HttpClient(handler)
            {
                BaseAddress = new Uri(apiUrl)
            })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var stringContent = JsonConvert.SerializeObject(passedObject);
                var httpContent = new StringContent(stringContent, Encoding.UTF8, "application/json");


                var response = client.PutAsync(method, httpContent).GetAwaiter().GetResult();
                message = response.Content.ReadAsStringAsync().Result;

                var mesTemp = message;


                return response.IsSuccessStatusCode ? new APIResponse
                {
                    Success = true,
                    Message = message,
                    StatusCode = response.StatusCode
                } : new APIResponse
                {
                    Success = false,
                    Message = message,
                    StatusCode = response.StatusCode
                };
            }
        }

    }
}
