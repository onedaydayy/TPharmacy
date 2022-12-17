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
                        CusAddress = "Tampines Ave 1",
                        CusPassword = "James1234*",
                        CusPoints = 100,
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Customer
                    {
                        ID = 2,
                        CusName = "Alice",
                        CusEmail = "alice@gmail.com",
                        CusAddress = "Bedok Ave 1",
                        CusPassword = "Alice1234*",
                        CusPoints = 50,
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Customer
                    {
                        ID = 3,
                        CusName = "Grey",
                        CusEmail = "grey@gmail.com",
                        CusAddress = "Temasek Polytechnic",
                        CusPassword = "Grey1234*",
                        CusPoints = 89,
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }

    }
}
