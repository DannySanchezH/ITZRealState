using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class ListingMap : EntityTypeConfiguration<Listing>

    {
        public ListingMap()
        {
            // Primary Key
            this.HasKey(t => t.IdListing);

            // Properties
            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.lotSize)
                .IsRequired();

            this.Property(t => t.constSize)
                .IsRequired();

            this.Property(t => t.price)
                .IsRequired();

            this.Property(t => t.IdUser)
                .IsRequired();

            this.Property(t => t.zipcode)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("LISTING");
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
            this.Property(t => t.Address).HasColumnName("ADDRESS");
            this.Property(t => t.lotSize).HasColumnName("LOTSIZE");
            this.Property(t => t.constSize).HasColumnName("CONSTSIZE");
            this.Property(t => t.price).HasColumnName("PRICE");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
            this.Property(t => t.zipcode).HasColumnName("ZIPCODE");
        }
    }
}