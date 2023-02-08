﻿using System;
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
    public class ProductsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<OrdersController> logger;
        //Refactored 
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ProductsController(ApplicationDbContext context)
        public ProductsController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager,
        ILogger<OrdersController> logger, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.logger = logger;
            this.roleManager = roleManager;
        }

        // GET: api/Products
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        public async Task<ActionResult> GetProducts()
        {
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                logger.LogInformation($"User.Identity.Name: {user.UserName}");
            }
            //Refactored
            //return await _context.Products.ToListAsync(); includes: q => q.Include(x => x.OrderItems).Include(x => x.Prescriptions)
            var products = await _unitOfWork.Products.GetAll();
            return Ok(products);
        }

        [HttpGet("{action}/{id}")]
        public async Task<ActionResult> GetCategoryProducts(string id)
        {
            //Refactored
            //return await _context.Products.ToListAsync(); includes: q => q.Include(x => x.OrderItems).Include(x => x.Prescriptions)
            var products = await _unitOfWork.Products.GetAll(q => q.ProdCategory == id);
            return Ok(products);
        }

        [HttpGet("{action}/{id}")]
        public async Task<ActionResult> SearchProducts(string id)
        {
            //Refactored
            //return await _context.Products.ToListAsync(); includes: q => q.Include(x => x.OrderItems).Include(x => x.Prescriptions)
            var products = await _unitOfWork.Products.GetAll(q => q.ProdCategory == id || q.ProdName == id);
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Product>> GetProduct(int id)
        public async Task<IActionResult> GetProduct(int id)
        {
            //Refactored
            //var product = await _context.Products.FindAsync(id);
            var product = await _unitOfWork.Products.Get(q => q.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(product).State = EntityState.Modified;
            _unitOfWork.Products.Update(product);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ProductExists(id))
                if (!await ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            //Refactored
            //_context.Products.Add(product);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Products.Insert(product);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetProduct", new { id = product.ID }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            //Refactored
            //var product = await _context.Products.FindAsync(id);
            var product = await _unitOfWork.Products.Get(q => q.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Products.Remove(product);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Products.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ProductExists(int id)
        private async Task<bool> ProductExists(int id)
        {
            //Refactored
            //return _context.Products.Any(e => e.ID == id);
            var product = await _unitOfWork.Products.Get(q => q.ID == id);
            return product != null;
        }
    }
}
