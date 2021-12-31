using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAluNa.Data.EF.Extensions;
using ShopAluNa.Data.Entities;

namespace ShopAluNa.Data.EF.Configurations
{
    class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
