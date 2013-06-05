using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class DesireMap : EntityTypeConfiguration<Desire>

    {
        public DesireMap()
        {
            // Properties
<<<<<<< HEAD
            this.HasKey(t => t.IdDesire);
=======
            this.Property(t => t.IdDesire)
                .IsRequired();
>>>>>>> Listings(Create,Edit,Delete)

            this.Property(t => t.IdListing)
                .IsRequired();

            this.Property(t => t.IdUser)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DESIRELIST");
<<<<<<< HEAD
            this.Property(t => t.IdDesire).HasColumnName("");
=======
            this.Property(t => t.IdDesire).HasColumnName("IDDESIRE");
>>>>>>> Listings(Create,Edit,Delete)
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
        }
    }
}