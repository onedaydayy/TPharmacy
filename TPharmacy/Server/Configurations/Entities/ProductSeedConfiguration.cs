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
                        ProdDesc = "BLACKMORES Bio Vitamin C 1000mg 120 Tablets",
                        ProdPrice = 35.00m,
                        ProdImg = "Vitamin C .jpeg",
                        ProdCategory = "Supplement",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 2,
                        ProdBrand = "Swisse",
                        ProdName = "Omega 3 Fish Oil",
                        ProdDesc = "Swisse Omega 3 Fish Oil 1500mg 100 Tablets",
                        ProdPrice = 58.00m,
                        ProdImg = "Omega 3 Fish Oil .jpeg",
                        ProdCategory = "Supplement",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 3,
                        ProdBrand = "Wastons",
                        ProdName = "Calcium",
                        ProdDesc = "Wastons Calcium 500mg 150 Tablets",
                        ProdPrice = 45.00m,
                        ProdImg = "Calcium .jpeg",
                        ProdCategory = "Supplement",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 4,
                        ProdBrand = "Telfast",
                        ProdName = "Panadol",
                        ProdDesc = "Telfast Panadol 10mg",
                        ProdPrice = 20.00m,
                        ProdImg = "Panadol .jpeg",
                        ProdCategory = "Prescriptions",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 5,
                        ProdBrand = "Cellucor",
                        ProdName = "Whey Protein Powder",
                        ProdDesc = "Cellucor Whey Protein Powder 5LBS",
                        ProdPrice = 60.00m,
                        ProdImg = "Whey Protein Powder .jpeg",
                        ProdCategory = "Sports",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 6,
                        ProdBrand = "Solaray",
                        ProdName = "Kids Multi Vitamins & Minerals Gummies",
                        ProdDesc = "Solaray Kids Multi Vitamins & Minerals Gummies 120S",
                        ProdPrice = 30.00m,
                        ProdImg = "Kids Multi Vitamins & Minerals Gummies .jpeg",
                        ProdCategory = "Baby",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 7,
                        ProdBrand = "Claritin",
                        ProdName = "Clarityn",
                        ProdDesc = "CLARITYN - Non - drowsy 24H Allergy Relief Tablets 10's",
                        ProdPrice = 25.00m,
                        ProdImg = "Clarityn .jpeg",
                        ProdCategory = "Prescriptions",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Product
                    {
                        ID = 8,
                        ProdBrand = "Strepsils",
                        ProdName = "Soothing Relief Lozenges",
                        ProdDesc = "Lozenges Soothing Relief for Sore Throat Soothing Honey & Lemon 24s",
                        ProdPrice = 20.00m,
                        ProdImg = "Strepsils Lozenges .jpeg",
                        ProdCategory = "Prescriptions",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );        
        }

    }
}
