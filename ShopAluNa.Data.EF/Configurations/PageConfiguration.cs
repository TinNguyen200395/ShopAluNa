using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAluNa.Data.EF.Extensions;
using ShopAluNa.Data.Entities;

namespace ShopAluNa.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
