using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace Company_SD.Config
{
    public class ConfigDependent : IEntityTypeConfiguration<Dependent>
    {
        public void Configure(EntityTypeBuilder<Dependent> builder)
        {

            builder.HasKey(x => new { x.DName, x.SSN }); // Comp Key

            builder.Property(x=>x.DName).IsRequired();

            builder.Property(x => x.BDate)
                .IsRequired(false);

            builder.Property(x=>x.Gender)
                .HasMaxLength(255)
                .HasColumnType("VARCHAR")
                .IsRequired(false);

            builder.HasOne(x => x.Employees)
                .WithMany(x => x.Dependents)
                .HasForeignKey(x => x.SSN)
                .IsRequired();
        }
    }

}

