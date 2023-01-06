using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;


namespace TPharmacy.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product
                    {
                        ID = 1,
                        ProdBrand = "Blackmores",
                        ProdName = "Vitamin C",
                        ProdDesc = "BLACKMORES Bio 1000mg Vitamin C 120 Tablets",
                        ProdPrice = 35.00m,
                        ProdCategory = "Supplements",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 2,
                        ProdBrand = "Swisse",
                        ProdName = "Omega 3 Fish Oil",
                        ProdDesc = "Omega 3 Fish Oil 1500mg 100 Tablets",
                        ProdPrice = 58.00m,
                        ProdCategory = "Supplements",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 3,
                        ProdBrand = "Wastons",
                        ProdName = "Calcium",
                        ProdDesc = "Calcium 500mg 150 Tablets",
                        ProdPrice = 45.00m,
                        ProdCategory = "Supplements",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 4,
                        ProdBrand = "Telfast",
                        ProdName = "Panadol",
                        ProdDesc = "Panadol 10mg",
                        ProdPrice = 20.00m,
                        ProdCategory = "Prescriptions",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }

    }
}
