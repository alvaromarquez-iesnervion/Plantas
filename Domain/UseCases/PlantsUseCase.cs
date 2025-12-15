using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class PlantsUseCase :  IPlantsUseCase
    {
        private IPlantRepository plantRepository;
        private ICategoryRepository categoryRepository;

        public PlantsUseCase(IPlantRepository plantRepository, ICategoryRepository categoryRepository)
        {
            this.plantRepository = plantRepository;
            this.categoryRepository = categoryRepository;
        }

        public IndexDTO GetHomeIndexData(int? categoryId)
        {
            IndexDTO result = new IndexDTO(categoryRepository.GetAllCategories(), null);

            if (categoryId != null)
            {
                result = new IndexDTO(categoryRepository.GetAllCategories(), plantRepository.GetPlantsByCategoryId(categoryId));
            }
            

            return result;
        }

        public PlantDetailDTO GetPlantDetailUseCase(int plantId)
        {
            Plant plant = plantRepository.GetPlantById(plantId);
            PlantDetailDTO result = new PlantDetailDTO(plant, categoryRepository.GetCategoryName(plant.categoryId));
            return result;
        }

        public bool UpdatePlantPriceUseCase(int plantId, decimal newPrice)
        {
            Boolean result = false;
            Plant plant = plantRepository.GetPlantById(plantId);
            if (plant.price< newPrice)
            {
                plantRepository.UpdatePlantPrice(plantId, newPrice);
                result = true;
            }
            return result;
        }
    }
}
