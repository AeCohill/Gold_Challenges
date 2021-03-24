using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGES01_Classes
{
    public class Content
    {
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public List<string> Ingredients { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
