using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>

    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUser);

            // Table & Column Mappings
            this.ToTable("CLIENT");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
        }
    }
}