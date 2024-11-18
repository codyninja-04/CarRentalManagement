﻿using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {

        public void Configure(EntityTypeBuilder<Make> builder)
        {
        builder.HasData(
            new Make
            {
                Id = 1,
                Name = "BMW",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Make
            {
                Id = 2,
                Name = "Toyota",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
    }
}
