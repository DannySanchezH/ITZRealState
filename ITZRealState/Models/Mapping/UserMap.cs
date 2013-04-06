using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>

    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUser);

            // Properties
            this.Property(t => t.firstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.lastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.userName)
                .IsRequired()
                .HasMaxLength(20);


            this.Property(t => t.facebookId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.zipCode)
                .IsRequired();

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("USER");
            this.Property(t => t.IdUser).HasColumnName("IDUSER");
            this.Property(t => t.firstName).HasColumnName("FIRSTNAME");
            this.Property(t => t.lastName).HasColumnName("LASTNAME");
            this.Property(t => t.userName).HasColumnName("USERNAME");
            this.Property(t => t.facebookId).HasColumnName("FACEBOOKID");
            this.Property(t => t.zipCode).HasColumnName("ZIPCODE");
            this.Property(t => t.email).HasColumnName("EMAIL");
        }
    }
}