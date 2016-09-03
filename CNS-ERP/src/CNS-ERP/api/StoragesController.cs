using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CNSS_ERP.DAL.Models.Storage;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CNS_ERP.api
{
    [Route("api/[controller]")]
    public class StoragesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Storages> Get()
        {
            return new List<Storages>
            {
                new Storages {StorageId=1, City="Mielec", Postal_code="39-310", Street="Wojska Polskiego", Street_address="17a", Suite="11" },
                new Storages {StorageId=1, City="Dębica", Postal_code="39-300", Street="Mickiewicza", Street_address="14a", Suite="11" },
                new Storages {StorageId=1, City="Ruda", Postal_code="39-340", Street="Słowackiego", Street_address="17a", Suite="11" }

            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
