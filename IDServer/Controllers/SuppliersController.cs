using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDCommon;
using IDServer.DbLayer;
using IDServer.Mappers;
using IDServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IDServer.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IDDbContext appDbContext;

        public SuppliersController(IDDbContext dbContext)
        {
            appDbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<SupplierDTO>> Get()
        {
            List<Supplier> suppliers = await appDbContext.Suppliers.ToListAsync();
            List<SupplierDTO> supplierDTOs = new List<SupplierDTO>();
            for(int cnt = 0; cnt < suppliers.Count; cnt++)
            {
                supplierDTOs.Add(SupplierMapper.SupplierToDTO(suppliers[cnt]));
            }

            return supplierDTOs;
        }


        // POST: api/Suppliers
        [HttpPost]
        public async Task<IActionResult> PostSupplier([FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            appDbContext.Suppliers.Add(supplier);
            await appDbContext.SaveChangesAsync();

            return CreatedAtAction("PostSupplier", new { id = supplier.Id }, supplier);
        }

        // PUT: api/Suppliers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier([FromRoute] int id, [FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supplier.Id)
            {
                return BadRequest();
            }

            appDbContext.Entry(supplier).State = EntityState.Modified;

            try
            {
                await appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
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

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = await appDbContext.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            appDbContext.Suppliers.Remove(supplier);
            await appDbContext.SaveChangesAsync();

            return Ok(supplier);
        }

        private bool SupplierExists(int id)
        {
            return appDbContext.Suppliers.Any(e => e.Id == id);
        }


    }
}
