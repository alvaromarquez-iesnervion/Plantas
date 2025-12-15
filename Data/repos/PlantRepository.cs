using Domain.Entities;
using Domain.Repos;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Data.repos
{
    public class PlantRepository : IPlantRepository
    {
        private List<Plant> plants { get;  }

        public PlantRepository()
        {
            plants = new List<Plant>()
                    {
                        new Plant(1, "Monstera deliciosa", "Planta tropical de interior con hojas grandes", 25.99m, 1),
                        new Plant(2, "Ficus elastica", "Planta resistente ideal para interiores", 19.50m, 1),
                        new Plant(3, "Sansevieria", "Planta purificadora y de bajo mantenimiento", 15.00m, 1),
                        new Plant(4, "Pothos", "Planta colgante fácil de cuidar", 12.99m, 1),
                        new Plant(5, "Calathea", "Planta decorativa de hojas vistosas", 22.00m, 1),

                        new Plant(6, "Lavanda", "Planta aromática con aroma relajante", 8.50m, 2),
                        new Plant(7, "Romero", "Planta aromática muy usada en cocina", 6.99m, 2),
                        new Plant(8, "Albahaca", "Hierba aromática fresca", 5.50m, 2),
                        new Plant(9, "Tomillo", "Planta aromática resistente", 6.00m, 2),
                        new Plant(10, "Menta", "Planta aromática de crecimiento rápido", 5.99m, 2),

                        new Plant(11, "Aloe Vera", "Planta medicinal con múltiples usos", 9.99m, 4),
                        new Plant(12, "Manzanilla", "Planta medicinal calmante", 4.99m, 4),
                        new Plant(13, "Valeriana", "Planta medicinal relajante", 7.50m, 4),
                        new Plant(14, "Eucalipto", "Planta medicinal y aromática", 14.00m, 4),
                        new Plant(15, "Árnica", "Planta medicinal para uso tópico", 6.99m, 4),

                        new Plant(16, "Cactus columna", "Cactus decorativo de crecimiento vertical", 11.99m, 6),
                        new Plant(17, "Cactus bola", "Cactus pequeño y decorativo", 8.99m, 6),
                        new Plant(18, "Opuntia", "Cactus resistente y fácil de cuidar", 10.50m, 6),
                        new Plant(19, "Cactus barril", "Cactus ornamental clásico", 13.99m, 6),
                        new Plant(20, "Cactus lunar", "Cactus decorativo de colores", 9.50m, 6),

                        new Plant(21, "Echeveria", "Suculenta ornamental compacta", 6.99m, 5),
                        new Plant(22, "Crassula", "Suculenta conocida como árbol de jade", 12.00m, 5),
                        new Plant(23, "Haworthia", "Suculenta pequeña ideal para interiores", 7.50m, 5),
                        new Plant(24, "Sedum", "Suculenta resistente al sol", 5.99m, 5),
                        new Plant(25, "Aeonium", "Suculenta de rosetas grandes", 9.99m, 5),

                        new Plant(26, "Rosa", "Planta ornamental de flor", 14.99m, 7),
                        new Plant(27, "Tulipán", "Planta ornamental bulbosa", 3.99m, 7),
                        new Plant(28, "Orquídea", "Planta ornamental elegante", 29.99m, 7),
                        new Plant(29, "Geranio", "Planta ornamental muy común", 7.99m, 7),
                        new Plant(30, "Petunia", "Planta ornamental de flor abundante", 4.50m, 7),

                        new Plant(31, "Nenúfar", "Planta acuática ornamental", 18.99m, 8),
                        new Plant(32, "Loto", "Planta acuática de flor grande", 22.99m, 8),
                        new Plant(33, "Jacinto de agua", "Planta acuática flotante", 9.50m, 8),
                        new Plant(34, "Papiro", "Planta acuática decorativa", 15.00m, 8),
                        new Plant(35, "Elodea", "Planta acuática oxigenadora", 6.99m, 8),

                        new Plant(36, "Limonero", "Árbol frutal de cítricos", 34.99m, 9),
                        new Plant(37, "Naranjo", "Árbol frutal muy productivo", 32.99m, 9),
                        new Plant(38, "Manzano", "Árbol frutal clásico", 29.99m, 9),
                        new Plant(39, "Peral", "Árbol frutal resistente", 28.50m, 9),
                        new Plant(40, "Higuera", "Árbol frutal mediterráneo", 26.99m, 9),

                        new Plant(41, "Hiedra", "Planta trepadora de crecimiento rápido", 8.99m, 10),
                        new Plant(42, "Jazmín", "Planta trepadora aromática", 12.50m, 10),
                        new Plant(43, "Buganvilla", "Planta trepadora ornamental", 19.99m, 10),
                        new Plant(44, "Madreselva", "Planta trepadora de flor fragante", 14.99m, 10),
                        new Plant(45, "Glicinia", "Planta trepadora de floración espectacular", 24.99m, 10),

                        new Plant(46, "Helecho", "Planta verde de sombra", 11.50m, 1),
                        new Plant(47, "Palmera areca", "Palmera decorativa de interior", 27.99m, 1),
                        new Plant(48, "Dracaena", "Planta resistente y elegante", 18.99m, 1),
                        new Plant(49, "Yucca", "Planta ornamental muy resistente", 21.99m, 1),
                        new Plant(50, "Zamioculca", "Planta de interior casi indestructible", 23.50m, 1)
                    };
        }

        public List<Plant> GetPlantsByCategoryId(int? categoryId)
        {
            List<Plant> list = new List<Plant>();

            foreach (Plant plant in this.plants)
            {
                if (plant.categoryId == categoryId)
                {
                    list.Add(plant);
                }
            }

            return list;
        }

        public Plant GetPlantById(int plantId)
        {
            Plant result = new Plant();
            foreach (Plant plant in this.plants)
            {
                if (plant.id == plantId)
                {
                    result = plant;
                }
            }   

            return result;
        }

        public Boolean UpdatePlantPrice(int plantId, decimal newPrice)
        {
            Boolean result = false;
            foreach (Plant plant in this.plants)
            {
                if (plant.id == plantId)
                {
                    plant.price = newPrice;
                    result = true;
                }
            }
            return result;
        }
    }

}
