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
    public class OrderItemsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<OrderItemsController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public OrderItemsController(ApplicationDbContext context)
        public OrderItemsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrderItemsController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }

        // GET: api/OrderItems/orderid/{orderId}
        [HttpGet("customer")]
        public async Task<ActionResult> GetCustomerOrderItems()
        {
            // Get the orderId from the session
            var orderId = HttpContext.Session.GetInt32("orderId");

            if (orderId.HasValue)
            {
                // Use the orderId to retrieve all order items for the current order
                var orderitems = await _unitOfWork.OrderItems.GetAll(q => q.OrderID == orderId.Value, includes: q => q.Include(x => x.Order).Include(x => x.Product));
                return Ok(orderitems);
            }
            else
            {
                return NotFound();
            }
        }
            // GET: api/OrderItems
            [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        public async Task<ActionResult> GetOrderItems()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.OrderItems.ToListAsync();
            var orderitems = await _unitOfWork.OrderItems.GetAll(includes: q => q.Include(x => x.Order).Include(x => x.Product));
            return Ok(orderitems);
        }


        // GET: api/OrderItems/5
        //Refactored
        //public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem(int id)
        {
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            var product = await _unitOfWork.Products.Get(q => q.ID == orderitem.ProductID);
            orderitem.Product = product;

            return Ok(orderitem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderitem)
        {
            // Retrieve the order's ID from the session variable
            var orderId = HttpContext.Session.GetInt32("orderId");

            if (orderId.HasValue)
            {
                // Use the order's ID to retrieve the correct order item
                var existingOrderItem = await _unitOfWork.OrderItems.Get(q => q.ID == id && q.OrderID == orderId);

                if (existingOrderItem == null)
                {
                    return NotFound();
                }

                existingOrderItem.OrderItemQtny = orderitem.OrderItemQtny;
                _unitOfWork.OrderItems.Update(existingOrderItem);
                await _unitOfWork.Save(HttpContext);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderitem)
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                var customer = await _unitOfWork.Customers.Get(c => c.CusEmail == username);
                if (customer != null)
                {
                    int? orderId = HttpContext.Session.GetInt32("orderId");
                    if (!orderId.HasValue)
                    {
                        var order = new Order
                        {
                            CustomerID = customer.ID,
                            OrderDateTime = DateTime.Now,
                            StaffID = 3
                        };
                        await _unitOfWork.Orders.Insert(order);
                        await _unitOfWork.Save(HttpContext);
                        orderitem.OrderID = order.ID;
                        HttpContext.Session.SetInt32("orderId", order.ID);
                    }
                    else
                    {
                        var order = await _unitOfWork.Orders.Get(q => q.ID == orderId.Value);
                        if (order.OrderStatus == Order.Status.Completed)
                        {
                            return BadRequest("Cannot add more items to a checked out order");
                        }
                        orderitem.OrderID = orderId.Value;
                    }
                    await _unitOfWork.OrderItems.Insert(orderitem);
                    await _unitOfWork.Save(HttpContext);
                    return CreatedAtAction("GetOrderItem", new { id = orderitem.ID }, orderitem);
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
        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            if (orderitem == null)
            {
                return NotFound();
            }

            // Retrieve the order's ID from the session variable
            var orderId = HttpContext.Session.GetInt32("orderId");
            if (orderId.HasValue)
            {
                // Use the order's ID to retrieve the correct order item
                var existingOrderItem = await _unitOfWork.OrderItems.Get(q => q.ID == id && q.OrderID == orderId);
                if (existingOrderItem == null)
                {
                    return NotFound();
                }

                await _unitOfWork.OrderItems.Delete(existingOrderItem.ID);
                await _unitOfWork.Save(HttpContext);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        //Refactored
        //private bool OrderItemExists(int id)
        private async Task<bool> OrderItemExists(int id)
        {
            //Refactored
            //return _context.OrderItems.Any(e => e.ID == id);
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            return orderitem != null;
        }
    }
}


