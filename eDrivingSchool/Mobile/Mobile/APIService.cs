using eDrivingSchool.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile
{
   public class APIService
    {
        private readonly string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }
#if DEBUG
        private string _apiUrl = "http://localhost:51372/api";
#endif
#if RELEASE
         private string _apiUrl = "http://mywebsite.com/api";
#endif
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> GetAll<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                 await Application.Current.MainPage.DisplayAlert("Authentication","Wrong username or password","OK");

                }
                throw;
            }

        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> GetByUsername<T>(object username)
        {
            var url = $"{_apiUrl}/{_route}/{username}";
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            //ovdje vjerovatno baci FlurlException neki

            /*
             * Uglavnom, gdje se poziva insert za usera (registration form ili sta vec), tu hendliras FlurlException
             * I onda kad ti se baci FlurlException, provjeris jel' HTTP status code 400 i ako jeste, ispises useru sta ne valja kroz neki alert
             */

        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }

        public async Task<T> Login<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Register<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}/register";

            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }
    }
}
