using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_SD.Config
{
    public class ConfigProject : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.PNum);
            builder.Property(x => x.PNum).ValueGeneratedNever();


            builder.Property(x=> x.PName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.City)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.Loc)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired(false);

            // RelationShip 1 : M between Dept and Project as Fk form table Dept is DNum
            builder.HasOne(x => x.Departments)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.DNum)
                .IsRequired();

            // RelationShip M : M between Dept and Project as Fk form table Emp is Project
            builder.HasMany(x => x.Employees)
                .WithMany(x => x.Projects)
                .UsingEntity<Work>();












        }
    }
}

