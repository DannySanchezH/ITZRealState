using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class RoomListingMap : EntityTypeConfiguration<RoomListing>

    {
        public RoomListingMap()
        {
        
            // Properties
            this.Property(t => t.IdListing)
                .IsRequired();

            this.Property(t => t.IdRoom)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ROOM_LISTING");
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
            this.Property(t => t.IdRoom).HasColumnName("IDROOM");
        }
    }
}