using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public  class IndexDTO
    {
        public List<Category> categories { get; }
        public List<Plant>? plants { get; }
        public int SelectedCategoryId { get; set; } 

        public IndexDTO(List<Category> categories, List<Plant>? plants) 
        {
            if (plants == null)
            {
                this.plants = null;

            }
            else
            {
                this.plants = plants;
            }
                this.categories = categories;
        }
    }
}
