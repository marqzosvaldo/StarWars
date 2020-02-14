using System;

using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace StarWars.Helpers {
    public static class RequestsHelper<T> {
        private const string URLAPI = "https://private-anon-e49726cc22-starhub.apiary-mock.com/";

        public static async Task<T> Requests(string url_req, MethodsRequest method, string content = "") {
            HttpClient _client = new HttpClient();
            StringContent _content = new StringContent(content);
            _content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            _client.BaseAddress = new Uri(URLAPI);
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessLogin.UserAccessToken);

            HttpResponseMessage _result;
            string _response;
            T _contentdeserialize;

            try {
                switch (method) {
                    case MethodsRequest.GET:
                        _result = await _client.GetAsync(url_req);
                        if (_result.IsSuccessStatusCode) {
                            _response = await _result.Content.ReadAsStringAsync();
                            _contentdeserialize = JsonConvert.DeserializeObject<T>(_response);
                            return (T)Convert.ChangeType(_contentdeserialize, typeof(T));
                        }
                        return (T)Convert.ChangeType(null, typeof(T));

                    case MethodsRequest.POST:
                        _result = await _client.PostAsync(url_req, _content);
                        Debug.WriteLine(_result);
                        if (_result.IsSuccessStatusCode) {

                            _response = await _result.Content.ReadAsStringAsync();
                            _contentdeserialize = JsonConvert.DeserializeObject<T>(_response);

                            return (T)Convert.ChangeType(_contentdeserialize, typeof(T));
                        }
                        return (T)Convert.ChangeType(null, typeof(T));

                    default:
                        break;
                }
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }
        public enum MethodsRequest {
            POST, GET, PUT, PATCH
        }
    }
}
