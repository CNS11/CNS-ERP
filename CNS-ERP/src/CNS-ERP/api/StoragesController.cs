using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CNSS_ERP.DAL.Models.Storage;
using CNS_ERP.Repos.Storage;
using CNS_ERP.Interfaces;
using CNSS_ERP.DAL;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CNS_ERP.api
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StoragesController : Controller
    {
        public StoragesController(IRepository<Storages> repo)
        {
            this._repo = repo;
        }
        public IRepository<Storages> _repo = new StoragesRepository();
        // GET: api/values
        [HttpGet]
        public IEnumerable<Storages> Get()
        { 
        
            return (_repo.SelectAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var storage = _repo.SelectByID(id);
            if (storage != null)
            {
                return new ObjectResult(storage);
            }
            else
            {
                return new NotFoundResult();
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Storages storage)
        {
            if (ModelState.IsValid)
            {
                if (storage.StorageId == 0)
                {
                    _repo.Insert(storage);
                    _repo.Save();
                    return new ObjectResult(storage);
                }
                else
                {
                    Storages original = _repo.SelectByID(storage.StorageId);
                    original.Postal_code = storage.Postal_code;
                    original.City = storage.City;
                    original.Street = storage.Street;
                    original.Street_address = storage.Street_address;
                    original.Suite = storage.Suite;
                    _repo.Save();
                    return new ObjectResult(original);

                }
            }
            return new BadRequestObjectResult(ModelState);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, Storages storage)
        {
            _repo.Update(storage);
            _repo.Save();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {

                if(_repo.Delete(id))
            {
                _repo.Save();
                return new ObjectResult(null);
                

            }else
            {
                return new BadRequestObjectResult(ModelState);

            }




        }
    }
}
