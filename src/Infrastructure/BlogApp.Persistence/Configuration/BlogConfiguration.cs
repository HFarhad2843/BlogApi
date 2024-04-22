using BlogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApp.Persistence.Configuration;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.Property(x=>x.Title).IsRequired().HasMaxLength(200);
        builder.Property(x=>x.Description).IsRequired().HasMaxLength(1200);
    }
}