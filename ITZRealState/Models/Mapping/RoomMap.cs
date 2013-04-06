using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class RoomMap : EntityTypeConfiguration<Room>

    {
        public RoomMap()
        {
            // Primary Key
            this.HasKey(t => t.IdRoom);

            // Properties
            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ROOM");
            this.Property(t => t.IdRoom).HasColumnName("IDROOM");
            this.Property(t => t.type).HasColumnName("TYPE");
        }
    }
}