using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CNSS_ERP.DAL;
using CNSS_ERP.DAL.Models.Storage;

namespace CNS_ERP.Controllers
{
    [Produces("application/json")]
    [Route("api/Product_categories")]
    public class Product_categoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Product_categoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Product_categories
        [HttpGet]
        public IEnumerable<Product_categories> GetProduct_categoriesDbSet()
        {
            return _context.Product_categoriesDbSet;
        }

        // GET: api/Product_categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct_categories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Product_categories product_categories = await _context.Product_categoriesDbSet.SingleOrDefaultAsync(m => m.Product_categoriesId == id);

            if (product_categories == null)
            {
                return NotFound();
            }

            return Ok(product_categories);
        }

        // PUT: api/Product_categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_categories([FromRoute] int id, [FromBody] Product_categories product_categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product_categories.Product_categoriesId)
            {
                return BadRequest();
            }

            _context.Entry(product_categories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_categoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Product_categories
        [HttpPost]
        public async Task<IActionResult> PostProduct_categories([FromBody] Product_categories product_categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Product_categoriesDbSet.Add(product_categories);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Product_categoriesExists(product_categories.Product_categoriesId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProduct_categories", new { id = product_categories.Product_categoriesId }, product_categories);
        }

        // DELETE: api/Product_categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_categories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Product_categories product_categories = await _context.Product_categoriesDbSet.SingleOrDefaultAsync(m => m.Product_categoriesId == id);
            if (product_categories == null)
            {
                return NotFound();
            }

            _context.Product_categoriesDbSet.Remove(product_categories);
            await _context.SaveChangesAsync();

            return Ok(product_categories);
        }

        private bool Product_categoriesExists(int id)
        {
            return _context.Product_categoriesDbSet.Any(e => e.Product_categoriesId == id);
        }
    }
}