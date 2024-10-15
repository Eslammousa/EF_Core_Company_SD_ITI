using Company_SD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company_SD.Config
{
    public class ConfigWork : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {

            builder.HasKey(x => new { x.SSN, x.PNumber }); // Comp Key

            builder.Property(x => x.Hours)
                .IsRequired(false);
        }
    }

}

