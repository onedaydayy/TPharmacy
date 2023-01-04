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
    public class StaffsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<StaffsController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<StaffsController> logger)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
        }
        // GET: api/Staffs
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Staffs.ToListAsync();
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> GetStaff(int id)
        {
            //Refactored
            //var staff = await _context.Staffs.FindAsync(id);
            var staff = await _unitOfWork.Staffs.Get(q => q.ID == id);

            if (staff == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(staff).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(staff);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!StaffExists(id))
                if (!await StaffExists(id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            //Refactored
            //_context.Staffs.Add(staff);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetStaff", new { id = staff.ID }, staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            //Refactored
            //var staff = await _context.Staffs.FindAsync(id);
            var staff = await _unitOfWork.Staffs.Get(q => q.ID == id);
            if (staff == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Staffs.Remove(staff);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool StaffExists(int id)
        private async Task<bool> StaffExists(int id)
        {
            //Refactored
            //return _context.Staffs.Any(e => e.ID == id);
            var staff = await _unitOfWork.Staffs.Get(q => q.ID == id);
            return staff != null;
        }
    }
}


