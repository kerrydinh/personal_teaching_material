using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KerryExample.Entity
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder
                .HasMany(o => o.Orders)
                .WithOne(u => u.User)
                .HasForeignKey(o => o.UserId);

        }
    }
}
