using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class AmenitieListingMap : EntityTypeConfiguration<AmenitieListing>

    {
        public AmenitieListingMap()
        {
            this.Property(t => t.IdAmenitie)
                .IsRequired();

            this.Property(t => t.IdListing)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("AMENITIE_LISTING");
            this.Property(t => t.IdAmenitie).HasColumnName("IDAMENITIE");
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
        }
    }
}