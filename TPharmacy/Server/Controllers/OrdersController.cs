using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TPharmacy.Server.IRepository;
using TPharmacy.Server.Models;
using TPharmacy.Shared.Domain;

namespace TPharamacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<OrdersController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public OrdersController(ApplicationDbContext context)
        public OrdersController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrdersController> logger)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
        }

        // GET: api/Orders
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Orders.ToListAsync();
            var orders = await _unitOfWork.Orders.GetAll();
            return Ok(orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Order>> GetOrder(int id)
        public async Task<IActionResult> GetOrder(int id)
        {
            //Refactored
            //var order = await _context.Orders.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.ID == id);

            if (order == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(order);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(order).State = EntityState.Modified;
            _unitOfWork.Orders.Update(order);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!OrderExists(id))
                if (!await OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            //Refactored
            //_context.Orders.Add(order);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Orders.Insert(order);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOrder", new { id = order.ID }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            //Refactored
            //var order = await _context.Orders.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.ID == id);
            if (order == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Orders.Remove(order);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Orders.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool OrderExists(int id)
        private async Task<bool> OrderExists(int id)
        {
            //Refactored
            //return _context.Orders.Any(e => e.ID == id);
            var order = await _unitOfWork.Orders.Get(q => q.ID == id);
            return order != null;
        }
    }
}
