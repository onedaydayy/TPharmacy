using TPharmacy.Server.Configurations.Entities;
using TPharmacy.Server.Models;
using TPharmacy.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TPharmacy.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductSeedConfiguration());

            builder.ApplyConfiguration(new StaffSeedConfiguration());

            builder.ApplyConfiguration(new CustomerSeedConfiguration());

            builder.ApplyConfiguration(new OrderSeedConfiguration());

            builder.ApplyConfiguration(new OrderItemSeedConfiguration());

            builder.ApplyConfiguration(new PaymentSeedConfiguration());

            builder.ApplyConfiguration(new PrescriptionSeedConfiguration());

            builder.ApplyConfiguration(new ConsultationSeedConfiguration());

        }
    }
}
