using Domain.Entities;
using Domain.Repos;
using System.Collections.Generic;

namespace Data.repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories { get; set; }

        public CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category(1, "Plantas de interior"),
                new Category(2, "Plantas de exterior"),
                new Category(3, "Plantas aromáticas"),
                new Category(4, "Plantas medicinales"),
                new Category(5, "Suculentas"),
                new Category(6, "Cactus"),
                new Category(7, "Plantas ornamentales"),
                new Category(8, "Plantas acuáticas"),
                new Category(9, "Árboles frutales"),
                new Category(10, "Plantas trepadoras")
            };
        }
    
    
    
        public List<Category> GetAllCategories()
        {
            return categories;
        }
        public String  GetCategoryName(int id)
        {
            String categoryName= "";
            foreach (Category category in categories)
            {
                if (category.id == id)
                {
                    categoryName = category.name;
                }
            }

            return categoryName;
        }

    }
}
