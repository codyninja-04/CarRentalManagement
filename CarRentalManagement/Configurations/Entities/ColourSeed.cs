﻿using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {

            builder.HasData(
 new Colour
 {
     Id = 1,
     Name = "Black",
     CreatedDate = DateTime.Now,
     UpdatedDate = DateTime.Now,
     CreatedBy = "System",
     UpdatedBy = "System"
 },
 new Colour
 {
     Id = 2,
     Name = "Blue",
     CreatedDate = DateTime.Now,
     UpdatedDate = DateTime.Now,
     CreatedBy = "System",
     UpdatedBy = "System"
 }
 );

        }
    }
}
