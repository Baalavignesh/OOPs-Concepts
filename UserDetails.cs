using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class UserDetails:FoodDetails
    {
        private string username = "Baalavignesh";
        private int age = 22;
        private float weight = 75;
        private float height = 170;
        protected double calories_limit;
        private Dictionary<string, int> food_consumed = new Dictionary<string, int>();

        public UserDetails() {
            Console.WriteLine("User Details Class");
        }

        private double CalculateDailyLimit()
        {
            double calLimit = 66.5 + 13.8 * weight + 5 * 170 / (6.8 * age);
            return calLimit;
        }

        public void CreateUser()
        {
            Console.WriteLine("username set");
            calories_limit = CalculateDailyLimit();
            Console.WriteLine(calories_limit);
        }

        public void FoodConsumed()
        {
            int quantity = 0;
            Console.Write("How many bannana did you eat? : ");
            quantity = Convert.ToInt16( Console.ReadLine());

            food_consumed.Add("banana", quantity);

            Console.Write("How many egg did you eat? : ");
            quantity = Convert.ToInt16(Console.ReadLine());

            food_consumed.Add("egg", quantity);
        }

        public double CalculateCalories()
        {
            double result = 0;
            
            foreach (KeyValuePair<string, int> x in food_consumed)
            {
                result = result + x.Value * food[x.Key];

            }

            result = calories_limit - result;
            
            return result;
        }
    }
}
