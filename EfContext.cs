using Microsoft.EntityFrameworkCore;
using WebApplicationEFCore.Mapping;
using WebApplicationEFCore.Models;

namespace WebApplicationEFCore
{
    public class EfContext:DbContext
    {
        public DbSet<Ceremony> Ceremonies { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<CeremonyGuest> CeremonyGuests { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public EfContext(DbContextOptions<EfContext> options): base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CeremonyGuestMapping());
            modelBuilder.ApplyConfiguration(new CeremonyMapping());
            modelBuilder.ApplyConfiguration(new GuestMapping());
            modelBuilder.ApplyConfiguration(new MultimediaMapping());
            modelBuilder.ApplyConfiguration(new MemberMapping());
            modelBuilder.ApplyConfiguration(new SponsorMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
