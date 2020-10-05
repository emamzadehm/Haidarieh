using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.Mapping
{
    public class CeremonyMapping : IEntityTypeConfiguration<Ceremony>
    {
        public void Configure(EntityTypeBuilder<Ceremony> builder)
        {
            builder.ToTable("Tbl_Ceremony");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.CeremonyDate);
            builder.Property(x => x.Status);

            builder.HasMany(x => x.CeremonyGuests).WithOne(x => x.Ceremony).HasForeignKey(x => x.CeremonyId);
            
        }
    }
}
