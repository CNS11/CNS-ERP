using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GetCountriesService;
using Newtonsoft.Json;

namespace CNS_ERP.api
{
    [Produces("application/json")]
    [Route("api/Cities")]
    
    public class CitiesController : Controller
    {
        public async Task<GetCountriesResponse> GetCities()
        {
            countrySoapClient client = new countrySoapClient(new countrySoapClient.EndpointConfiguration());
            var list = await client.GetCountriesAsync(new GetCountriesRequest());
            //   string cities = JsonConvert.SerializeObject(list);
         //   JsonResult result = new JsonResult(cities);
            return list;

        }
    }
}