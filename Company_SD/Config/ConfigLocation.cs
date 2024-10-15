using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_SD.Config
{
    public class ConfigLocation : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {

            builder.HasKey(x => new { x.DNum, x.Loc }); // Comp Key

            builder.Property(x => x.Loc)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired();


            builder.HasOne(x => x.Departments)
                .WithMany(x => x.Locations)
                .HasForeignKey(x => x.DNum)
                .IsRequired();

        }
    }

}

