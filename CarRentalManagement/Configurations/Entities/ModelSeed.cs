using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
new Model
{
    Id = 1,
    Name = "i4",
    CreatedDate = DateTime.Now,
    UpdatedDate = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new Model
{
    Id = 2,
    Name = "X5",
    CreatedDate = DateTime.Now,
    UpdatedDate = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new Model
{
    Id =3 ,
    Name = "Prius",
    CreatedDate = DateTime.Now,
    UpdatedDate = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new Model
{
    Id = 4,
    Name = "C-HR",
    CreatedDate = DateTime.Now,
    UpdatedDate = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);

        }
    }
}
