using System.Collections.Generic;
using DemirSaglik.Project.Business.Concrete.ApiEntity;
using Newtonsoft.Json;
using RestSharp;

namespace DemirSaglik.Project.Business.Concrete.ApiService
{
    public class MovieService
    {
        
        public string  JsonList(string title)
        {
            RestClient restClient = new RestClient($"http://www.omdbapi.com/?apikey=f5011fd8&s={title}");

            restClient.Timeout = -1;
        
            RestRequest request = new RestRequest(Method.GET);
        
        
            IRestResponse queryResult = restClient.Execute(request);
        
            Root apiRoote = JsonConvert.DeserializeObject<Root>(queryResult.Content);
        
            List<Search> getMovieList = apiRoote.Search;
        
            string json = JsonConvert.SerializeObject(getMovieList);
        
            return json;
              
         }

        public MovieService()
        {

        }


    }
}
