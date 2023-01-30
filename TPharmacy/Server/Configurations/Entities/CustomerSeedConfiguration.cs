using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;


namespace TPharmacy.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                    new Customer
                    {
                        ID = 1,
                        CusName = "James",
                        CusEmail = "james@gmail.com",
                        CusNumber = "87439653",
                        CusAddress = "Tampines Ave 1",
                        CusPassword = "June1234*",
                        CusPoints = 100,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Customer
                    {
                        ID = 2,
                        CusName = "Alice",
                        CusEmail = "alice@gmail.com",
                        CusNumber = "96512845",
                        CusAddress = "Bedok Ave 1",
                        CusPassword = "June1234*",
                        CusPoints = 50,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Customer
                    {
                        ID = 3,
                        CusName = "Sheila",
                        CusEmail = "sheila@gmail.com",
                        CusNumber = "87511773",
                        CusAddress = "Jurong Ave 1",
                        CusPassword = "June1234*",
                        CusPoints = 89,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }

    }
}
