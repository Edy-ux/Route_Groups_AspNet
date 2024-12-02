using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route_Groups_AspNet.Models;

namespace Route_Groups_AspNet.Context.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category> 
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Url).HasMaxLength(600).IsRequired();

        List<Category> categories =
        [
            new Category(title: "Tecnologias",
                url: "https://http2.mlstatic.com/D_NQ_NP2X_660966-MLA80300585057_102024-B.webp"),

            new Category(title: "Casa E Móveis",
                url:
                "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1729294158019-desktop26.png"),

            new Category(title: "Esportes e Fitnes",
                url:
                "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1731421475975-desk-01-v2.jpg")
        ];
        builder.HasData(
            categories
        );
    }
}