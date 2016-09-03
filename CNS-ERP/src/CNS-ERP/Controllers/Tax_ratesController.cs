using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CNSS_ERP.DAL.Models.Sales;
using CNSS_ERP.DAL;
using System.Linq;

namespace CNS_ERP.Controllers
{
    [Produces("application/json")]
    [Route("api/Tax_rates")]
    public class Tax_ratesController : Controller
    {
        private ApplicationDbContext _context;

        // GET: api/Tax_rates
        public Tax_ratesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Sales_invoices
        [HttpGet]
        public IEnumerable<Sales_invoices> GetSales_invoicesDbContext()
        {
            return _context.Sales_invoicesDbSet;
        }

        // GET: api/Tax_rates/5
        [HttpGet("{id}", Name = "GetTax_rates")]
        public async Task<IActionResult> GetTax_rates([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Tax_rates tax_rates =  _context.Tax_ratesDbSet.Single(m => m.Tax_ratesId == id);

            if (tax_rates == null)
            {
                return NotFound();
            }
            return Ok(tax_rates);

        }

        // POST: api/Tax_rates
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Tax_rates/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
