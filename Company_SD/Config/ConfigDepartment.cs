using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace Company_SD.Config
{
    public class ConfigDepartment : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DNum);
            builder.Property(x => x.DNum).ValueGeneratedNever();

            builder.Property(x => x.DName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.hireDate)
                .IsRequired(false);

            // RelationShip 1 : 1 between Employee And Department as FK is MrgSSN 
            builder.HasOne(x=>x.OtherEmployees)
                .WithOne(x=>x.OtherDepartments)
                .HasForeignKey<Department>(x=>x.MrgSSN)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


             
        

    }
    }
}

