using Domain.Entities;
using System.Collections.Generic;

namespace Data.repos
{
    internal class CategoryRepository
    {
        private List<Category> categories;

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
    
    
    
    
    }
}
