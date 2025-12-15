using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PlantDetailDTO
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string CategoryName { get; }
        public decimal CurrentPrice { get; set; }

        public PlantDetailDTO(Plant planta, string categoryName)
        {
            this.Id = planta.id;
            this.Name = planta.name;
            this.Description = planta.description;
            this.CategoryName = categoryName;
            this.CurrentPrice = planta.price;
        }
    }
}
