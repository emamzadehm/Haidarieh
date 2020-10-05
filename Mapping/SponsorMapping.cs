using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.Mapping
{
    public class SponsorMapping : IEntityTypeConfiguration<Sponsor>
    {
        public void Configure(EntityTypeBuilder<Sponsor> builder)
        {
            builder.ToTable("Tbl_Sponsor");
            builder.Property(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Tel);
            builder.Property(x => x.Image);
            builder.Property(x => x.IsVisible);
            builder.Property(x => x.Status);
            builder.Property(x => x.Bio);

            builder.HasKey(x => x.Id);
        }
    }
}
