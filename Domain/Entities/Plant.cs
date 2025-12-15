using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Plant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int categoryId { get; set; }

        public Plant()
        {
            this.id = 0;
            this.name = "";
            this.description = "";
            this.price = 0;
            this.categoryId = 0;
        }

        public Plant(int id, string name, string description, decimal price, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.categoryId = categoryId;
        }
    }
}
