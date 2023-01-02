using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TPharmacy.Server.IRepository;
using TPharmacy.Shared.Domain;

namespace TPharamacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public PrescriptionsController(ApplicationDbContext context)
        public PrescriptionsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Prescriptions
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Prescription>>> GetPrescriptions()
        public async Task<ActionResult<IEnumerable<Prescription>>> GetPrescriptions()
        {
            //Refactored
            //return await _context.Prescriptions.ToListAsync();
            var prescriptions = await _unitOfWork.Prescriptions.GetAll();
            return Ok(prescriptions);
        }

        // GET: api/Prescriptions/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Prescription>> GetPrescription(int id)
        public async Task<IActionResult> GetPrescription(int id)
        {
            //Refactored
            //var prescription = await _context.Prescriptions.FindAsync(id);
            var prescription = await _unitOfWork.Prescriptions.Get(q => q.ID == id);

            if (prescription == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(prescription);
        }

        // PUT: api/Prescriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrescription(int id, Prescription prescription)
        {
            if (id != prescription.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(prescription).State = EntityState.Modified;
            _unitOfWork.Prescriptions.Update(prescription);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!PrescriptionExists(id))
                if (!await PrescriptionExists(id))
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

        // POST: api/Prescriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Prescription>> PostPrescription(Prescription prescription)
        {
            //Refactored
            //_context.Prescriptions.Add(prescription);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Prescriptions.Insert(prescription);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetPrescription", new { id = prescription.ID }, prescription);
        }

        // DELETE: api/Prescriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrescription(int id)
        {
            //Refactored
            //var prescription = await _context.Prescriptions.FindAsync(id);
            var prescription = await _unitOfWork.Prescriptions.Get(q => q.ID == id);
            if (prescription == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Prescriptions.Remove(prescription);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Prescriptions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool PrescriptionExists(int id)
        private async Task<bool> PrescriptionExists(int id)
        {
            //Refactored
            //return _context.Prescriptions.Any(e => e.ID == id);
            var prescription = await _unitOfWork.Prescriptions.Get(q => q.ID == id);
            return prescription != null;
        }
    }
}
