using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }


        

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
