using Store.Data.Infrastructure;
using Store.Data.Repositories.Interfaces;
using Store.Model;
using Store.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Store.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categorysRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categorysRepository, IUnitOfWork unitOfWork)
        {
            _categorysRepository = categorysRepository;
            _unitOfWork = unitOfWork;
        }

        #region ICategoryService members

        public void CreateCategory(Category category)
        {
            _categorysRepository.Add(category);
        }

        public IEnumerable<Category> GetCategories(string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                return _categorysRepository.GetAll();
            else
                return _categorysRepository.GetAll().Where(c => c.Name == name);
        }

        public Category GetCategory(string name)
        {
            return _categorysRepository.GetCategoryByName(name);
        }

        public Category GetCategory(int id)
        {
            return _categorysRepository.GetById(id);
        }

        public void SaveCategory()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
