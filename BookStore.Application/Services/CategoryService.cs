using BookStore.Application.Contracts;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _CategoryRepository { get; set; }

        public CategoryService(ICategoryRepository categoryRepository) =>
          _CategoryRepository = categoryRepository;
        public bool AddCategory(Category Category)
        {
            bool isAdded = _CategoryRepository.Create(Category);
            if (isAdded)
                _CategoryRepository.Save();
            return isAdded;
        }
        public bool DeleteCategory(int categoryId)
        {
            Category category = GetbyId(categoryId);
            bool isDeleted = _CategoryRepository.Delete(category);
            if (isDeleted)
                _CategoryRepository.Save();
            return isDeleted;
        }
        public List<Category> GetAllCategories() => _CategoryRepository.GetAll().ToList();
        public Category GetbyId(int id) => _CategoryRepository.GetById(id);
        public bool UpdateCategory(Category Category)
        {
            Category updCategory = GetbyId(Category.Id);
            updCategory.Name = Category.Name;
            bool isUpdated = _CategoryRepository.Update(Category);
            if (isUpdated)
                _CategoryRepository.Save();
            return isUpdated;
        }
    }
}
