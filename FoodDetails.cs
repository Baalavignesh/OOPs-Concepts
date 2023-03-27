using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class FoodDetails
    {
        protected Dictionary<string, int> food = new Dictionary<string, int>()
        {
            {"banana", 120},
            {"egg", 40},
            {"dosa", 160},
        };

        public FoodDetails() {
            Console.WriteLine("Food Details Class");
        }

        public void AddFood(string new_food,int new_cal)
        {
            food.Add(new_food, new_cal);
        }


    }
}
