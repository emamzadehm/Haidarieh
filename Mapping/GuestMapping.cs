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
    public class GuestMapping : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.ToTable("Tbl_Guest");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.FullName);
            builder.Property(x => x.Tel);
            builder.Property(x => x.Coordinator);
            builder.Property(x => x.GuestType);
            builder.Property(x => x.Image);

            builder.HasMany(x => x.CeremonyGuests).WithOne(x => x.Guest).HasForeignKey(x => x.GuestId);

        }
    }
}
