using NTierECommerce.BLL.Abstracts;
using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Concretes
{
    public class CategoryRepository : ICategoryReposiyory
    {
        private IRepository<Category> _categoryRep;


        public CategoryRepository(IRepository<Category> categoryRep)
        {
            _categoryRep = categoryRep;
        }

        public async Task<string>Create(Category entity)
        {
            return await _categoryRep.Create(entity);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRep.GetAll();
        }

        public async Task<Category> GetById(int id)
        {
            return await _categoryRep.GetById(id);
        }

        public async Task<string> Update(Category entity)
        {
            return await _categoryRep.Update(entity);
        }

    }
}
