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
    public class PaymentsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<PaymentsController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public PaymentsController(ApplicationDbContext context)
        public PaymentsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<PaymentsController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }
        // GET: api/Payments
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        public async Task<ActionResult> GetPayments()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Payments.ToListAsync();
            var payments = await _unitOfWork.Payments.GetAll(includes: q => q.Include(x => x.Order));
            return Ok(payments);
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Payment>> GetPayment(int id)
        public async Task<IActionResult> GetPayment(int id)
        {
            //Refactored
            //var payment = await _context.Payments.FindAsync(id);
            var payment = await _unitOfWork.Payments.Get(q => q.ID == id);

            if (payment == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(payment);
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment payment)
        {
            if (id != payment.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(payment).State = EntityState.Modified;
            _unitOfWork.Payments.Update(payment);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!PaymentExists(id))
                if (!await PaymentExists(id))
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

        // POST: api/Payments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            //Refactored
            //_context.Payments.Add(payment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Payments.Insert(payment);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetPayment", new { id = payment.ID }, payment);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            //Refactored
            //var payment = await _context.Payments.FindAsync(id);
            var payment = await _unitOfWork.Payments.Get(q => q.ID == id);
            if (payment == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Payments.Remove(payment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Payments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool PaymentExists(int id)
        private async Task<bool> PaymentExists(int id)
        {
            //Refactored
            //return _context.Payments.Any(e => e.ID == id);
            var payment = await _unitOfWork.Payments.Get(q => q.ID == id);
            return payment != null;
        }
    }
}


