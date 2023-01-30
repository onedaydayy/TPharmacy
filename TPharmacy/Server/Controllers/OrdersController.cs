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
    public class OrdersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<OrdersController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public OrdersController(ApplicationDbContext context)
        public OrdersController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrdersController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }
        // GET: api/Orders
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        public async Task<ActionResult> GetOrders()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Orders.ToListAsync();
            var orders = await _unitOfWork.Orders.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Staff));
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("checkout")]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                var customer = await _unitOfWork.Customers.Get(c => c.CusEmail == username);
                if (customer != null)
                {
                    int? orderId = HttpContext.Session.GetInt32("orderId");
                    if (orderId.HasValue)
                    {
                        var existingOrder = await _unitOfWork.Orders.Get(o => o.ID == orderId);
                        if (existingOrder != null)
                        {
                            decimal total = 0;
                            var orderItems = await _unitOfWork.OrderItems.GetAll(o => o.OrderID == existingOrder.ID);
                            foreach (var item in orderItems)
                            {
                                total += item.OrderItemTotal;
                            }
                            existingOrder.OrderTotal = total;
                            existingOrder.OrderDateTime = order.OrderDateTime;
                            existingOrder.OrderStatus = Order.Status.Completed; // Update the status to "Completed"
                            _unitOfWork.Orders.Update(existingOrder);
                            await _unitOfWork.Save(HttpContext);
                            HttpContext.Session.Remove("orderId");
                            return CreatedAtAction("GetOrder", new { id = existingOrder.ID }, existingOrder);
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
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

        [HttpPut("checkout/{id}")]
        public async Task<IActionResult> CheckoutOrder(int id)
        {
            var order = await _unitOfWork.Orders.Get(q => q.ID == id);
            if (order == null)
            {
                return NotFound();
            }
            order.OrderStatus = Order.Status.Completed;
            _unitOfWork.Orders.Update(order);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        [HttpGet("checkout")]
        public async Task<ActionResult<int>> GetCheckoutOrderId()
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                var customer = await _unitOfWork.Customers.Get(c => c.CusEmail == username);
                if (customer != null)
                {
                    int? orderId = HttpContext.Session.GetInt32("orderId");
                    if (orderId.HasValue)
                    {
                        var existingOrder = await _unitOfWork.Orders.Get(o => o.ID == orderId);
                        if (existingOrder != null && existingOrder.OrderStatus != Order.Status.Completed)
                        {
                            return Ok(orderId);
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}


