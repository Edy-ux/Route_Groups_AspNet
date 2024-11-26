
using Route_Groups_AspNet.Model;
using Route_Groups_AspNet.Services.Interfaces;

namespace Route_Groups_AspNet.Services;

public class CategoryService : ICategoryService
{

    public Category InsertAsync(Category entity)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Category> GetAsync()
    {
        return [

           new Category(title: "Tecnologias", url: "https://http2.mlstatic.com/D_NQ_NP2X_660966-MLA80300585057_102024-B.webp"),
           new Category(title: "Casa E Móveis", url: "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1729294158019-desktop26.png"),
           new Category(title: "Esportes e Fitnes", url: "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1731421475975-desk-01-v2.jpg")

        ];
    }



}
