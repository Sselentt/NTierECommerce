using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Abstracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Task<Product> GetById(int id);
        Task<string> Create(Product entity);
        Task<string> Update(Product entity);
    }
}
