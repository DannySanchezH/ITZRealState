﻿using System.Data.Entity.ModelConfiguration;

namespace ITZRealState.Models.Mapping
{
    public class Room_ListingMap : EntityTypeConfiguration<Room_Listing>
    {
        public Room_ListingMap()
        {
        // Properties
            this.Property(t => t.IdListing)
                .IsRequired();

            this.Property(t => t.IdRoom)
                .IsRequired();
            
            this.Property(t => t.Amount)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ROOM_LISTING");
            this.Property(t => t.IdListing).HasColumnName("IDLISTING");
            this.Property(t => t.IdRoom).HasColumnName("IDROOM");
            this.Property(t => t.Amount).HasColumnName("AMOUNT");
        }   
    }
}