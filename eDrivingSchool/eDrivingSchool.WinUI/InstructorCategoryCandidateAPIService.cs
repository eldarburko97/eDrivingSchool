using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDrivingSchool.Model;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI
{
   public class InstructorCategoryCandidateAPIService
    {
        private readonly string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }

        private string _apiUrl = "http://localhost:51372/api";

        public InstructorCategoryCandidateAPIService(string route)
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
                    MessageBox.Show("testtt");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object instructorId,object categoryId,object candidateId)
        {
            var url = $"{_apiUrl}/{_route}/{instructorId}/{categoryId}/{candidateId}";
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

        public async Task<T> Update<T>(object instructorId, object categoryId, object candidateId, object request)
        {
            var url = $"{_apiUrl}/{_route}/{instructorId}/{categoryId}/{candidateId}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
