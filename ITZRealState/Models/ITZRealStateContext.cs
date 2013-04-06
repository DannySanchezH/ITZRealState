using ITZRealState.Models.Mapping;
using System.Data.Entity;
using ITZRealState.Models;

namespace BusinessLMS.Models
{
    public class ITZRealStateContext : DbContext
    {
        static ITZRealStateContext()
        {
            Database.SetInitializer<ITZRealStateContext>(null);
        }

        public ITZRealStateContext()
            : base("Name=ITZRealStateContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Amenitie> Amenities { get; set; }
        public DbSet<AmenitieListing> AmenitieListings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Desire> Desires { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomListing> RoomListings { get; set; }
        public DbSet<SalesAgent> SalesAgents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministratorMap());
            modelBuilder.Configurations.Add(new AmenitieMap());
            modelBuilder.Configurations.Add(new AmenitieListingMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new DesireMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new ListingMap());
            modelBuilder.Configurations.Add(new RoomListingMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new SalesAgentMap());
            modelBuilder.Configurations.Add(new UserMap());
        }

        

    }
}
