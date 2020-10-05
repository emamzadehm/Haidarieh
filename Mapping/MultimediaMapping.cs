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
    public class MultimediaMapping:IEntityTypeConfiguration<Multimedia>
    {
        public void Configure(EntityTypeBuilder<Multimedia> builder)
        {
            builder.ToTable("Tbl_Multimedia");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.Property(x => x.FileAddress).IsRequired();
            builder.Property(x => x.CeremonyGuestId).IsRequired();
            builder.Property(x => x.Status);

            builder.HasOne(x => x.CeremonyGuest).WithMany(x => x.Multimedias).HasForeignKey(x => x.CeremonyGuestId);
        }
    }
}
