using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAluNa.Data.EF.Extensions;
using ShopAluNa.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ShopAluNa.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasColumnType("varchar(50)");
            // etc.
        }
    }
}
