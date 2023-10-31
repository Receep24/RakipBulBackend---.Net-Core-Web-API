using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class UserEventsConfiguration : IEntityTypeConfiguration<UserEvents>
    {
        public void Configure(EntityTypeBuilder<UserEvents> builder)
        {
            builder.HasKey(a => a.UserEventsID);
            builder.Property(a => a.UserEventsID).ValueGeneratedOnAdd();
            builder.Property(a => a.UserID);
            builder.Property(a => a.EventID);
        }
    }
}
