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
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger<StaffsController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<StaffsController> logger, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }
        // GET: api/Staffs
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        public async Task<ActionResult> GetStaffs()
        {
            var staffs = await _unitOfWork.Staffs.GetAll();
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> GetStaff(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.ID == id);

            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            var user = await userManager.FindByIdAsync(staff.StafName);
            if (user == null)
            {
                return NotFound();
            }
            var currentRoles = await userManager.GetRolesAsync(user);
            await userManager.RemoveFromRolesAsync(user, currentRoles);
            if (staff.StafRole == "Admin")
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
            if (staff.StafRole == "Pharmacist")
            {
                await userManager.AddToRoleAsync(user, "Pharmacist");
            }
            if (staff.StafRole == "Packer")
            {
                await userManager.AddToRoleAsync(user, "Packer");
            }
            if (id != staff.ID)
            {
                return BadRequest();
            }

            user.Id = staff.StafName;
            user.UserName = staff.StafEmail;
            user.Email = staff.StafEmail;
            user.Name = staff.StafName;
            user.Password = staff.StafPassword;

            var updateResult = await userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                return BadRequest();
            }
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetResult = await userManager.ResetPasswordAsync(user, token, staff.StafPassword);
            if (!passwordResetResult.Succeeded)
            {
                return BadRequest();
            }
            _unitOfWork.Staffs.Update(staff);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = staff.StafEmail, Email = staff.StafEmail, Id = staff.StafName, Name = staff.StafName, Role = "Staff" };
                var result = await userManager.CreateAsync(user, staff.StafPassword);
                if (result.Succeeded)
                {
                    logger.LogInformation("User created a new account with password.");
                    await roleManager.RoleExistsAsync("Staff");
                    await userManager.AddToRoleAsync(user, "Staff");

                    if (staff.StafRole == "Admin")
                    {
                        await roleManager.RoleExistsAsync("Admin");
                        await userManager.AddToRoleAsync(user, "Admin");
                    }
                    if (staff.StafRole == "Pharmacist")
                    {
                        await roleManager.RoleExistsAsync("Pharmacist");
                        await userManager.AddToRoleAsync(user, "Pharmacist");
                    }
                    if (staff.StafRole == "Packer")
                    {
                        await roleManager.RoleExistsAsync("Packer");
                        await userManager.AddToRoleAsync(user, "Packer");
                    }
                }
            }
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
            var staff = await _unitOfWork.Staffs.Get(q => q.ID == id);
            if (staff == null)
            {
                return NotFound();
            }
            //Delete Staff
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            var user = await userManager.FindByNameAsync(staff.StafName);
            if (user != null)
            {
                //Remove User
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    //Remove user from the staff role
                    await userManager.RemoveFromRoleAsync(user, "Staff");
                    return Ok();
                }
            }

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


