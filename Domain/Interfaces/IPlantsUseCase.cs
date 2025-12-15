using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPlantsUseCase
    {
        public IndexDTO GetHomeIndexData(int? categoryId);
        public PlantDetailDTO GetPlantDetailUseCase(int plantId);
        public bool UpdatePlantPriceUseCase(int plantId, decimal newPrice);
    }
}
