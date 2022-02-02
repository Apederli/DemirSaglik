using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DemirSaglik.Project.Entities;
using Newtonsoft.Json;

namespace DemirSaglik.Project.Business.Concrete.ApiService
{
    public class UserApiService
    {

        private HttpClient _httpClient;


        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(User user)
        {
            StringContent stringSerialize = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");


            HttpResponseMessage response = await _httpClient.PostAsync("login", stringSerialize);

            if (response.IsSuccessStatusCode)
            {

                return true;


            }


            return false;


        }

        public UserApiService()
        {
        }
    }
}
