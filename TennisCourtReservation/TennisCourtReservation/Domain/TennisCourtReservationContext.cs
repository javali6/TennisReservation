using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TennisCourtReservation.Domain
{
    public class TennisCourtReservationContext : DbContext
    {
        private static readonly string ConnectionString =
            "server=localhost;port=5432;database=Tennis;uid=postgres;password=postgres;";

        private static TennisCourtReservationContext? instance = null;

        public static TennisCourtReservationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TennisCourtReservationContext();
                }
                return instance;
                
            }
        }

        private TennisCourtReservationContext() {}

        public DbSet<User> Users { get; set; }
        public DbSet<TennisCourt> TennisCourt { get; set; }
        public DbSet<Reservations> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TennisCourt>(ts =>
                {
                    ts.ToTable("TennisCourt");
                    ts.HasMany(x => x.Reservations).WithOne(r => r.TennisCourt).HasForeignKey(x => x.ReservationId);
                }

            );
        }
    }
}
