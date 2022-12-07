using BookIT.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookIT.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Hotel>()
                .HasOne(h => h.Category)
                .WithMany(c => c.Hotels)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<Hotel>()
                .HasOne(h => h.Region)
                .WithMany(r => r.Hotels)
                .HasForeignKey(h => h.RegionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Hotel>()
                .HasOne(h => h.Country)
                .WithMany(c => c.Hotels)
                .HasForeignKey(h => h.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Region>()
                .HasOne(r => r.Country)
                .WithMany(c => c.Regions)
                .HasForeignKey(r => r.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Booking>()
                .HasOne(b => b.Hotel)
                .WithMany(h => h.Bookings)
                .HasForeignKey(b => b.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

        public DbSet<Booking> Bookings { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        public DbSet<Hotel> Hotels { get; set; } = null!;

        public DbSet<Message> Messages { get; set; } = null!;

        public DbSet<Region> Regions { get; set; } = null!;

        public DbSet<Room> Rooms { get; set; } = null!;

        public DbSet<Host> Hosts { get; set; } = null!;

        public DbSet<Company> Companies { get; set; } = null!;
    }
}
