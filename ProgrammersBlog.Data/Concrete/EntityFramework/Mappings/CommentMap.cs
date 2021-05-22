using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            builder.HasData(new Comment {
                Id = 1,
                ArticleId = 1,
                Text = "Lorem ipsum sşdlkfsdşkl sdlkfsdkljfg dslfgjkjfds gldfjklgjklsd f gjkl sdfgjkdsfg kjdfjklg ldsfjgdfs jkjlgdfjkgdskjdg",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Makale Yorumu"
            },
            new Comment {
                Id = 2,
                ArticleId = 1,
                Text = "Lorem ipsum sşdlkfsdşkl sdlkfsdkljfg dslfgjkjfds gldfjklgjklsd f gjkl sdfgjkdsfg kjdfjklg ldsfjgdfs jkjlgdfjkgdskjdg",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Makale Yorumu"
            },
            new Comment {
                Id = 3,
                ArticleId = 1,
                Text = "Lorem ipsum sşdlkfsdşkl sdlkfsdkljfg dslfgjkjfds gldfjklgjklsd f gjkl sdfgjkdsfg kjdfjklg ldsfjgdfs jkjlgdfjkgdskjdg",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Makale Yorumu"
            });
        }
    }
}