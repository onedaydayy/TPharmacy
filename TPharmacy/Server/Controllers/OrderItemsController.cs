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

namespace TPharamacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<OrderItemsController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public OrderItemsController(ApplicationDbContext context)

        public OrderItemsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrderItemsController> logger)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
        }

        // GET: api/OrderItems
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.OrderItems.ToListAsync();
            var orderItems = await _unitOfWork.OrderItems.GetAll();
            return Ok(orderItems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        public async Task<IActionResult> GetOrderItem(int id)
        {
            //Refactored
            //var orderItem = await _context.OrderItems.FindAsync(id);
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.ID == id);

            if (orderItem == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(orderItem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderItem)
        {
            if (id != orderItem.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(orderItem).State = EntityState.Modified;
            _unitOfWork.OrderItems.Update(orderItem);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!OrderItemExists(id))
                if (!await OrderItemExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderItem)
        {
            //Refactored
            //_context.OrderItems.Add(orderItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Insert(orderItem);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOrderItem", new { id = orderItem.ID }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            //Refactored
            //var orderItem = await _context.OrderItems.FindAsync(id);
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.OrderItems.Remove(orderItem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool OrderItemExists(int id)
        private async Task<bool> OrderItemExists(int id)
        {
            //Refactored
            //return _context.OrderItems.Any(e => e.ID == id);
            var orderItem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            return orderItem != null;
        }
    }
}
