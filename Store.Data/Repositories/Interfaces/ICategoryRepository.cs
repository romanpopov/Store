using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Data.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string name);
    }
}
