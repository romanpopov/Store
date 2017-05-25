using Store.Data.Infrastructure;
using Store.Data.Repositories.Interfaces;
using Store.Model;
using System;
using System.Linq;

namespace Store.Data.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Category GetCategoryByName(string categoryName)
        {
            Category category = this.DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return category;
        }

        public override void Update(Category entity)
        {
            entity.DateCreated = DateTime.Now;
            base.Update(entity);
        }
    }
}
