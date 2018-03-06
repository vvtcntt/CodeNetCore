using CodeNetCore.Data.EF.Extentions;
using CodeNetCore.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CodeNetCore.Data.EF.Configruations
{
    class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(p => p.Id).HasMaxLength(128)
                .IsRequired().HasColumnType("varchar(128)");
        }
    }
}
