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
        // GET: api/OrderItems
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        public async Task<ActionResult> GetOrderItems()
        {
            var user = await userManager.GetUserAsync(User);
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
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        public async Task<IActionResult> GetOrderItem(int id)
        {
            //Refactored
            //var orderitem = await _context.OrderItems.FindAsync(id);
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(orderitem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderitem)
        {
            if (id != orderitem.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(orderitem).State = EntityState.Modified;
            _unitOfWork.OrderItems.Update(orderitem);

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
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderitem)
        {
            //Refactored
            //_context.OrderItems.Add(orderitem);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Insert(orderitem);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOrderItem", new { id = orderitem.ID }, orderitem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            //Refactored
            //var orderitem = await _context.OrderItems.FindAsync(id);
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            if (orderitem == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.OrderItems.Remove(orderitem);
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
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.ID == id);
            return orderitem != null;
        }
    }
}


