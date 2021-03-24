using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGES01_Classes
{
    public class Order
    {
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public List<string> Ingredients { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Order()
        {
        }

        public Order(int mealNumber, string mealName, decimal price, List<string> ingredients, string description)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Price = price;
            Description = description;
            Ingredients = ingredients;
            
        }



    }
}
