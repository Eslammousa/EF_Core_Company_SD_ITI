using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Config
{
    public class ConfigEmployee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x=>x.SSN);
            builder.Property(x=>x.SSN).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.LName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(x => x.Gender)
                 .IsRequired(false);

            builder.Property(x => x.DBDate)
                .IsRequired(false);


            // RelationShip 1 : M Dept and Emp and FK is DNo
            builder.HasOne(x => x.Departments)
               .WithMany(x => x.Employees)
               .HasForeignKey(x=>x.DNo)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder.HasOne(x=>x.Employees)
                .WithMany(x=>x.SuperVisor)
                .HasForeignKey(x=>x.SuperId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();






        }
    }
}

