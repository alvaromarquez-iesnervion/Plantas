using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
    public interface IPlantRepository
    {
        public List<Plant> GetPlantsByCategoryId(int? categoryId);

        public Plant GetPlantById(int plantId);

        public Boolean UpdatePlantPrice(int plantId, decimal newPrice);
        
    }
}
