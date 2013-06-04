using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Zipcode)
                .IsRequired();

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.phone)
                .HasMaxLength(20);

            this.Property(t => t.cellular)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("UserProfile");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Zipcode).HasColumnName("Zipcode");
            this.Property(t => t.email).HasColumnName("Email");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.cellular).HasColumnName("cellular");
        }
    }
}