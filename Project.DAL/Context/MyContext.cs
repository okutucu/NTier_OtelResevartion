using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;
using Project.MAP.Options;

namespace Project.DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {
         

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new HouseKeepingMap());
            modelBuilder.Configurations.Add(new OtelMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RoomReservationMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<HouseKeeping> HouseKeepings { get; set; }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}
