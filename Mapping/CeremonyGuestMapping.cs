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
    public class CeremonyGuestMapping : IEntityTypeConfiguration<CeremonyGuest>
    {
        public void Configure(EntityTypeBuilder<CeremonyGuest> builder)
        {
            builder.ToTable("Tbl_CeremonyGuest");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CeremonyId);
            builder.Property(x => x.GuestId); 
            builder.Property(x => x.CeremonyDate);
            builder.Property(x => x.Satisfication);
            builder.Property(x => x.IsLive);
            builder.Property(x => x.BannerFile);
            builder.Property(x => x.Status);

            builder.HasOne(x => x.Guest).WithMany(x => x.CeremonyGuests).HasForeignKey(x => x.GuestId);
            builder.HasOne(x => x.Ceremony).WithMany(x => x.CeremonyGuests).HasForeignKey(x => x.CeremonyId);
            builder.HasMany(x => x.Multimedias).WithOne(x => x.CeremonyGuest).HasForeignKey(x => x.Id);

        }
    }
}
