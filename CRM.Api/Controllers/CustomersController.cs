using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.Api.Data;
using CRM.Api.Models;

namespace CRM.Api.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public CustomersController(CrmDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            var customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }
    }
}
