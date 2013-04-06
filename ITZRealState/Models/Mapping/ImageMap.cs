using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>

    {
        public ImageMap()
        {
            
            this.Property(t => t.IdListing)
                .IsRequired();

            
            this.Property(t => t.source)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("IMAGE");
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
            this.Property(t => t.source).HasColumnName("SOURCE");
        }
    }
}