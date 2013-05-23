using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    
    public class SalesAgentMap : EntityTypeConfiguration<SalesAgent>

    {
        public SalesAgentMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUser);

            // Properties
            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.cellular)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SALESAGENT");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
            this.Property(t => t.phone).HasColumnName("PHONE");
            this.Property(t => t.cellular).HasColumnName("CELLULAR");
        }
    }
}