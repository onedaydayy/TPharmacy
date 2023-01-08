using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TPharmacy.Server.Data;
using TPharmacy.Server.IRepository;
using TPharmacy.Server.Models;
using TPharmacy.Shared.Domain;

namespace TPharmacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<CustomersController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public CustomersController(ApplicationDbContext context)
        public CustomersController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<CustomersController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }
        // GET: api/Customers
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        public async Task<ActionResult> GetCustomers()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Customers.ToListAsync();
            var customers = await _unitOfWork.Customers.GetAll();
            return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Customer>> GetCustomer(int id)
        public async Task<IActionResult> GetCustomer(int id)
        {
            //Refactored
            //var customer = await _context.Customers.FindAsync(id);
            var customer = await _unitOfWork.Customers.Get(q => q.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(customer).State = EntityState.Modified;
            _unitOfWork.Customers.Update(customer);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!CustomerExists(id))
                if (!await CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            //Refactored
            //_context.Customers.Add(customer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Insert(customer);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetCustomer", new { id = customer.ID }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            //Refactored
            //var customer = await _context.Customers.FindAsync(id);
            var customer = await _unitOfWork.Customers.Get(q => q.ID == id);
            if (customer == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Customers.Remove(customer);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool CustomerExists(int id)
        private async Task<bool> CustomerExists(int id)
        {
            //Refactored
            //return _context.Customers.Any(e => e.ID == id);
            var customer = await _unitOfWork.Customers.Get(q => q.ID == id);
            return customer != null;
        }
    }
}


