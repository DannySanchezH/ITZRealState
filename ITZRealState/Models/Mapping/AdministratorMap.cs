using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class AdministratorMap :EntityTypeConfiguration<Administrator>
    {
        public AdministratorMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUser);

            // Table & Column Mappings
            this.ToTable("ADMINISTRATOR");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
        }
    }
}