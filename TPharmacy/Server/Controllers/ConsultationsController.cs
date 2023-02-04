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
    public class ConsultationsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<OrdersController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ConsultationsController(ApplicationDbContext context)
        public ConsultationsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrdersController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }


        // GET: api/Consultations/id
        [HttpGet("{action}/{id}")]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Consultation>>> GetConsultations()
        public async Task<ActionResult> GetMyConsultation(string id)
        {
            //Refactored
            //return await _context.Consultations.ToListAsync(); includes: q => q.Include(x => x.OrderItems).Include(x => x.Prescriptions)
            var consultations = await _unitOfWork.Consultations.GetAll(q => q.Customer.CusEmail == id, includes: q => q.Include(x => x.Customer).Include(x => x.Prescriptions));
            return Ok(consultations);
        }

        // GET: api/Consultations
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Consultation>>> GetConsultations()
        public async Task<ActionResult> GetConsultations()
        {
            //Refactored
            //return await _context.Consultations.ToListAsync(); includes: q => q.Include(x => x.OrderItems).Include(x => x.Prescriptions)
            var consultations = await _unitOfWork.Consultations.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Prescriptions));
            return Ok(consultations);
        }

        // GET: api/Consultations/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Consultation>> GetConsultation(int id)
        public async Task<IActionResult> GetConsultation(int id)
        {
            //Refactored
            //var consultation = await _context.Consultations.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ID == id);

            if (consultation == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(consultation);
        }

        // PUT: api/Consultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultation(int id, Consultation consultation)
        {
            if (id != consultation.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(consultation).State = EntityState.Modified;
            _unitOfWork.Consultations.Update(consultation);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ConsultationExists(id))
                if (!await ConsultationExists(id))
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

        // POST: api/Consultations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultation>> PostConsultation(Consultation consultation)
        {
            try
            {
                //Refactored
                //_context.Consultations.Add(consultation);
                //await _context.SaveChangesAsync();

                consultation.StaffID = 2;
                consultation.ConStatus = "Pending";
                consultation.CreatedBy = "System";
                consultation.UpdatedBy = "System";
                consultation.ConFee = 35;

                await _unitOfWork.Consultations.Insert(consultation);
                await _unitOfWork.Save(HttpContext);
            }catch (Exception ex)
            {
                var whatthe = ex.Message;
            }
            return CreatedAtAction("GetConsultation", new { id = consultation.ID }, consultation);
        }

        // DELETE: api/Consultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {
            //Refactored
            //var consultation = await _context.Consultations.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ID == id);
            if (consultation == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Consultations.Remove(consultation);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ConsultationExists(int id)
        private async Task<bool> ConsultationExists(int id)
        {
            //Refactored
            //return _context.Consultations.Any(e => e.ID == id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ID == id);
            return consultation != null;
        }
    }
}
