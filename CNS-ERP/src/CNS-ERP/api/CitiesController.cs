using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GetCountriesService;
using Newtonsoft.Json;
using System.Xml;

namespace CNS_ERP.api
{
    [Produces("application/json")]
    [Route("api/Cities")]
    
    public class CitiesController : Controller
    {
        public async Task<List<String>> GetCities()
        {
            List<string> lista = new List<string>();
            countrySoapClient client = new countrySoapClient(new countrySoapClient.EndpointConfiguration());
            var list = await client.GetCountriesAsync(new GetCountriesRequest());
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(list.Body.GetCountriesResult.ToString());
            XmlNodeList xnList = xmlDoc.SelectNodes("/NewDataSet/Table/Name");
            foreach (XmlNode xn in xnList)
            {
                lista.Add(xn.InnerText.ToString());

            }
            return lista;

        }
    }
}