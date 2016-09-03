using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CNSS_ERP.DAL;
using CNSS_ERP.DAL.Models.Sales;
using Microsoft.EntityFrameworkCore;

namespace CNS_ERP.Controllers
{
    [Produces("application/json")]
    [Route("api/Sales_invoices")]
    public class Sales_invoicesController : Controller
    {
        private ApplicationDbContext _context;

        public Sales_invoicesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Sales_invoices
        [HttpGet]
        public IEnumerable<Sales_invoices> GetSales_invoicesDbContext()
        {
            return _context.Sales_invoicesDbSet;
        }

        // GET: api/Sales_invoices/5
        [HttpGet("{id}", Name = "GetSales_invoices")]
        public async Task<IActionResult> GetSales_invoices([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Sales_invoices sales_invoices =  _context.Sales_invoicesDbSet.Single(m => m.Sales_invoiceId == id);

            if (sales_invoices==null)
            {
                return NotFound();
            }
            return Ok(sales_invoices);

        }
        
        // POST: api/Sales_invoices
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Sales_invoices/5
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
