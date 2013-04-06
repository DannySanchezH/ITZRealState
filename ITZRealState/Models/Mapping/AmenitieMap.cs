using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class AmenitieMap : EntityTypeConfiguration<Amenitie>

    {
        public AmenitieMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAmenitie);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AMENITIE");
            this.Property(t => t.IdAmenitie).HasColumnName("IDAMENITIE");
            this.Property(t => t.name).HasColumnName("NAME");
        }
    }
}