﻿using NTierECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerce.BLL.Abstracts
{
    public interface ICategoryReposiyory
    {
        IEnumerable<Category> GetAllCategories();
        Task<Category> GetById(int id);
        Task<string> Create (Category entity);
        Task<string> Update (Category entity);
    }
}
