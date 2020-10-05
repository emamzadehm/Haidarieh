using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore.Mapping
{
    public class MemberMapping : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("Tbl_Member");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Mobile).IsRequired();
            builder.Property(x => x.Status);

            
        }
    }
}
