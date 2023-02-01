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
        private readonly IUnitOfWork _unitOfWork;

        public OrdersController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrdersController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }
        [HttpGet]
        public async Task<ActionResult> GetOrders()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            var orders = await _unitOfWork.Orders.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Staff).Include(x => x.OrderItems));
            return Ok(orders);
        }


        [HttpGet("customer")]
        public async Task<IActionResult> GetOrdersByCustomer()
        {
            var username = HttpContext.Session.GetString("username");
            var customer = await _unitOfWork.Customers.Get(q => q.CusEmail == username);
            if (customer == null)
            {
                return NotFound();
            }
            var orders = await _unitOfWork.Orders.GetAll(q => q.CustomerID == customer.ID, includes: q => q.Include(x => x.Customer).Include(x => x.Staff).Include(x => x.OrderItems));
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = await _unitOfWork.Orders.Get(q => q.ID == id, includes: q => q.Include(x => x.Customer).Include(x => x.Staff).Include(x => x.OrderItems));
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPut("checkout")]
        public async Task<IActionResult> PutOrder(Order order)
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
                            existingOrder.OrderItemTotal = total;
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


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _unitOfWork.Orders.Get(q => q.ID == id, includes: q => q.Include(x => x.OrderItems));
            if (order == null)
            {
                return NotFound(new { message = $"Order with id {id} not found." });
            }

            _unitOfWork.OrderItems.DeleteRange(order.OrderItems);
            await _unitOfWork.Orders.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return Ok(new { message = $"Order with id {id} deleted successfully." });
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


