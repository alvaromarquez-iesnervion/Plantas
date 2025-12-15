using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
    public interface ICategoryRepository
    {
        public List<Category> GetAllCategories();
        public String GetCategoryName(int id);
    }
}
