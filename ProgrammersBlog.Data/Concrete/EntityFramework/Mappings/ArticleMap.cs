using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            builder.HasData(new Article {
                Id = 1,
                CategoryId = 1,
                Title = "C# 9.0 ve .NET 5 Yenilikleri",
                Content = "Lorem Ipsum, dizgi ve bask?? end??strisinde kullan??lan m??g??r metinlerdir. Lorem Ipsum, ad?? bilinmeyen bir matbaac??n??n bir hurufat numune kitab?? olu??turmak ??zere bir yaz?? galerisini alarak kar????t??rd?????? 1500'lerden beri end??stri standard?? sahte metinler olarak kullan??lm????t??r. Be??y??z y??l boyunca varl??????n?? s??rd??rmekle kalmam????, ayn?? zamanda pek de??i??meden elektronik dizgiye de s????ram????t??r. 1960'larda Lorem Ipsum pasajlar?? da i??eren Letraset yapraklar??n??n yay??nlanmas?? ile ve yak??n zamanda Aldus PageMaker gibi Lorem Ipsum s??r??mleri i??eren masa??st?? yay??nc??l??k yaz??l??mlar?? ile pop??ler olmu??tur.",
                Thumbnail = "Default.jpg",
                SeoDescription = "C# 9.0 ve .NET 5 Yenilikleri",
                SeoTags = "C#, C# 9, .NET5, .NET Framework, .NET Core",
                SeoAuthor = "Berk Koca",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# 9.0 ve .NET 5 Yenilikleri",
                UserId = 1,
                ViewCount = 100,
                CommentCount = 1
            });
        }
    }
}